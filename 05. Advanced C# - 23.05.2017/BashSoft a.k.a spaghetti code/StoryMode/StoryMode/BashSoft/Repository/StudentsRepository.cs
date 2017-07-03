﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BashSoft.Models;

namespace BashSoft
{
    public class StudentsRepository
    {
        private Dictionary<string, Course> courses;
        private Dictionary<string, Student> students;
        private bool isDataInitialized = false;
        private Dictionary<string, Dictionary<string, List<int>>> studentByCourse;
        private RepositoryFilter filter;
        private RepositorySorter sorter;

        public StudentsRepository( RepositoryFilter filter, RepositorySorter sorter)
        {
            this.filter = filter;
            this.sorter = sorter;
            this.studentByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
        }

        public void LoadData(string fileName)
        {
            if (this.isDataInitialized)
            {
                throw new ArgumentException(ExceptionMessages.DataAlreadyInitialisedException);              
                return;               
            }
                 OutputWriter.WriteMessageOnNewLine("Reading data...");
                this.students = new Dictionary<string, Student>();
                this.courses = new Dictionary<string, Course>();                         
                this.ReadData(fileName);
            
        }

        public void UnloadData()
        {
            if (!this.isDataInitialized)
            {
                throw  new ArgumentException(ExceptionMessages.DataNotInitializedExceptionMessage);               
            }

            this.students = null;
            this.courses = null;
            this.isDataInitialized = false;
        }

        private void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\"+fileName;
            
            
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
                            int[] scores = scoresStr.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToArray();
                            if (scores.Any(x => x > 100 || x < 0))
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidScore);
                            }
                            if (scores.Length > Course.NumberOfTasksOnExam)
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
                                continue;
                            }

                            if (!this.students.ContainsKey(username))
                            {
                                this.students.Add(username, new Student(username));
                            }
                            if (!this.courses.ContainsKey(courseName))
                            {
                                this.courses.Add(courseName,new Course(courseName));
                            }
                            Course course = this.courses[courseName];
                            Student student = this.students[username];

                            student.EnrollInCourse(course);
                            student.SetMarkOnCourse(courseName, scores);

                            course.EnrollStudent(student);
                        }
                        catch (FormatException fex)
                        {
                            throw new FormatException(fex.Message + $"at line : {line}");                           
                        }
                    }
                }

                isDataInitialized = true;
                OutputWriter.WriteMessageOnNewLine("Data read!");
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidPath);
            }                                 
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (this.courses.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InexistingCourseInDataBase);
                }
                
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataNotInitializedExceptionMessage);
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

        public void GetStudentsScoreFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentsPossible(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, double>(username, this.courses[courseName].StudentsByName[username].MarksByCourseName[courseName]));
            }
        }

        public void GetAllStudentFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var studentMarksEntry in this.courses[courseName].StudentsByName)
                {
                    this.GetStudentsScoreFromCourse(courseName,studentMarksEntry.Key);
                }
            }
        }

        public void FilterAndTake(string courseName, string givenFilther, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                studentsToTake = this.courses[courseName].StudentsByName.Count;

            }
            Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                .ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);
            
            this.filter.FilterAndTake(marks,givenFilther,studentsToTake.Value);
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
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

    }
}