using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using BashSoft.Contracts;
using BashSoft.DataStructures;
using BashSoft.Exceptions;
using BashSoft.Models;

namespace BashSoft
{
    public class StudentsRepository : IDatabase
    {
        private Dictionary<string, ICourse> courses;
        private Dictionary<string, IStudent> students;
        private bool isDataInitialized = false;
        private Dictionary<string, Dictionary<string, List<int>>> studentByCourse;
        private IDataFilter filter;
        private IDataSorter sorter;

        public StudentsRepository(IDataFilter filter, IDataSorter sorter)
        {
            this.filter = filter;
            this.sorter = sorter;
            this.studentByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
        }

        public void LoadData(string fileName)
        {
            if (this.isDataInitialized)
            {
                throw new DataAlreadyInitialisedException();
            }

            OutputWriter.WriteMessageOnNewLine("Reading data...");
            this.students = new Dictionary<string, IStudent>();
            this.courses = new Dictionary<string, ICourse>();
            this.ReadData(fileName);
        }

        public void UnloadData()
        {
            if (!this.isDataInitialized)
            {
                throw new DataNotInitializedException();
            }

            this.students = null;
            this.courses = null;
            this.isDataInitialized = false;
        }
        
        public void GetStudentsScoreFromCourse(string courseName, string username)
        {
            if (this.IsQueryForStudentsPossible(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, double>(username, this.courses[courseName].StudentsByName[username].MarksByCourseName[courseName]));
            }
        }

        public void GetAllStudentFromCourse(string courseName)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var studentMarksEntry in this.courses[courseName].StudentsByName)
                {
                    this.GetStudentsScoreFromCourse(courseName, studentMarksEntry.Key);
                }
            }
        }

        public ISimpleOrderedBag<ICourse> GetAllCoursesSorted(IComparer<ICourse> cmp)
        {
            SimpleSortedList<ICourse> sortedCourses = new SimpleSortedList<ICourse>(cmp);
            sortedCourses.AddAll(this.courses.Values);

            return sortedCourses;
        }

        public ISimpleOrderedBag<IStudent> GetAllStudentsSorted(IComparer<IStudent> cmp)
        {
            SimpleSortedList<IStudent> sortedStudents = new SimpleSortedList<IStudent>(cmp);
            sortedStudents.AddAll(this.students.Values);

            return sortedStudents;
        }

        public void FilterAndTake(string courseName, string givenFilther, int? studentsToTake = null)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                studentsToTake = this.courses[courseName].StudentsByName.Count;
            }

            Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                .ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);

            this.filter.FilterAndTake(marks, givenFilther, studentsToTake.Value);
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }
            }

            Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                .ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);

            this.sorter.OrderAndTake(marks, comparison, studentsToTake.Value);
        }

        private void ReadData(string fileName)
        {
            string path = SessionData.CurrentPath + "\\" + fileName;

            if (File.Exists(path))
            {
                string pattern = @"([A-Z][a-zA-Z#\++]*_[A-Z][a-z]{2}_\d{4})\s+([A-Za-z]+\d{2}_\d{2,4})\s([\s0-9]+)";
                Regex rgx = new Regex(pattern);
                string[] allInputLines = File.ReadAllLines(path);

                for (int line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]) && rgx.IsMatch(allInputLines[line]))
                    {
                        Match currentMatch = rgx.Match(allInputLines[line]);
                        string courseName = currentMatch.Groups[1].Value;
                        string username = currentMatch.Groups[2].Value;
                        string scoresStr = currentMatch.Groups[3].Value;

                        try
                        {
                            int[] scores = scoresStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToArray();
                            if (scores.Any(x => x > 100 || x < 0))
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidScore);
                            }

                            if (scores.Length > SoftUniCourse.NumberOfTasksOnExam)
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
                                continue;
                            }

                            if (!this.students.ContainsKey(username))
                            {
                                this.students.Add(username, new SoftUniStudent(username));
                            }

                            if (!this.courses.ContainsKey(courseName))
                            {
                                this.courses.Add(courseName, new SoftUniCourse(courseName));
                            }

                            ICourse softUniCourse = this.courses[courseName];
                            IStudent softUniStudent = this.students[username];

                            softUniStudent.EnrollInCourse(softUniCourse);
                            softUniStudent.SetMarkOnCourse(courseName, scores);
                            softUniCourse.EnrollStudent(softUniStudent);
                        }
                        catch (FormatException fex)
                        {
                            throw new FormatException(fex.Message + $"at line : {line}");
                        }
                    }
                }

                this.isDataInitialized = true;
                OutputWriter.WriteMessageOnNewLine("Data read!");
            }
            else
            {
                throw new InvalidPathException();
            }
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (this.isDataInitialized)
            {
                if (this.courses.ContainsKey(courseName))
                {
                    return true;
                }

                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InexistingCourseInDataBase);
            }
            else
            {
                throw new DataNotInitializedException();
            }

            return false;
        }

        private bool IsQueryForStudentsPossible(string courseName, string studentUserName)
        {
            if (this.IsQueryForCoursePossible(courseName) && this.courses[courseName].StudentsByName.ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }
    }
}
