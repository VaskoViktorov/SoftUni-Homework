using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;

namespace _01._Stud
{
    using Data;

    public class Program
    {
        private static Random random = new Random();

        public static void Main()
        {
            using (var db = new StudentSystemDbContext())
            {
                db.Database.Migrate();
                //SeedInitialData(db);
                SeedLicenses(db);
                //PrintStudentsWithHomeworks(db);
                //PrintCoursesAndResourses(db);
                //PrintAllCoursesWithMoreThanFiveResources(db);
                //PrintAllCoursesByGivenDate(db);
                //PrintStudentsCourses(db);
                //PrintAllCoursesWithResoursesAndLicenses(db);
                PrintStudentsCoursesResourses(db);

                db.SaveChanges();
            }
        }
       
        private static void SeedInitialData(StudentSystemDbContext db)
        {
            const int totalStudents = 25;
            const int totalCourses = 10;
            var currentDate = DateTime.Now;

            //Students
            for (int i = 0; i < totalStudents; i++)
            {
                db.Students.Add(new Student()
                {
                    Name = $"Student {i}",
                    RegistrationDate = currentDate.AddDays(i),
                    BirthDay = currentDate.AddYears(-21).AddMonths(i).AddDays(i),
                    PhoneNumber = $"Rnd Phone {i}"
                });
            }

            //Courses
            var addedCourses = new List<Course>();

            for (int i = 0; i < totalCourses; i++)
            {
                var course = new Course()
                {
                    Name = $"Course {i}",
                    Description = $"some description {i}",
                    Price = 10m + i * 10m,
                    StartDate = currentDate.AddDays(i + 1),
                    EndDate = currentDate.AddMonths(i)
                };
                addedCourses.Add(course);
                db.Courses.Add(course);
            }

            db.SaveChanges();

            //Students in Courses
            var studentsIds = db
                .Students
                .Select(s => s.Id)
                .ToList();

            for (int j = 0; j < totalCourses; j++)
            {
                var currentCourse = addedCourses[j];
                var studentsInCourse = random.Next(2, totalStudents / 2);

                for (int i = 0; i < studentsInCourse; i++)
                {
                    var studentId = studentsIds[random.Next(0, studentsIds.Count)];
                    if (currentCourse.Students.All(s => s.StudentId != studentId))
                    {
                        currentCourse.Students.Add(new StudentCourse()
                        {
                            StudentId = studentId
                        });
                    }
                    else
                    {
                        i--;
                    }
                }


                var resourcesInCourse = random.Next(2, 20);
                var types = new[] { 0, 1, 2, 999 };

                for (int k = 0; k < resourcesInCourse; k++)
                {
                    currentCourse.Resources.Add(new Resource()
                    {
                        Name = $"Resource {k}",
                        Url = $"URL: 123{k}",
                        Type = (ResourceType)types[random.Next(0, types.Length)]
                    });
                }
            }

            db.SaveChanges();

            //Homeworks
            for (int i = 0; i < totalCourses; i++)
            {
                var currentCourse = addedCourses[i];

                var studentsInCourseIds = currentCourse
                    .Students
                    .Select(s => s.StudentId)
                    .ToList();

                for (int j = 0; j < studentsInCourseIds.Count; j++)
                {

                    var totalHomeworks = random.Next(2, 5);

                    for (int k = 0; k < totalHomeworks; k++)
                    {
                        db.Homeworks.Add(new Homework()
                        {
                            Content = $"Content [{k}]",
                            SubmissionDate = currentDate.AddDays(-i),
                            Type = ContentType.Pdf,
                            StudentId = studentsInCourseIds[j],
                            CourseId = currentCourse.Id
                        });
                    }

                }

                db.SaveChanges();
            }
        }

        private static void PrintStudentsWithHomeworks(StudentSystemDbContext db)
        {
            var result = db
                .Students
                .Select(s => new
                {
                    s.Name,
                    Homeworks = s.Homeworks.Select(h => new
                    {
                        h.Content,
                        h.Type
                    })
                })
                .ToList();

            foreach (var student in result)
            {
                Console.WriteLine(student.Name);
                foreach (var homework in student.Homeworks)
                {
                    Console.WriteLine($"{homework.Content}-{homework.Type}");
                }

            }
        }

        private static void PrintCoursesAndResourses(StudentSystemDbContext db)
        {
            var result = db
                .Courses
                .OrderBy(c => c.StartDate)
                .ThenBy(c => c.EndDate)
                .Select(c => new
                {
                    c.Name,
                    c.Description,
                    Resources = c.Resources.Select(r => new
                    {
                        r.Name,
                        r.Url,
                        r.Type
                    })
                });

            foreach (var course in result)
            {
                Console.WriteLine($"{course.Name} - {course.Description}");

                foreach (var resource in course.Resources)
                {
                    Console.WriteLine($"{resource.Name} - {resource.Type} - {resource.Url}");
                }

            }
        }

        private static void PrintAllCoursesWithMoreThanFiveResources(StudentSystemDbContext db)
        {
            var result = db
                .Courses
                .Where(c => c.Resources.Count > 5)
                .Select(c => new
                {
                    c.Name,
                    Resources = c.Resources.Count,
                    c.StartDate
                })
                .OrderByDescending(c => c.Resources)
                .ThenByDescending(c => c.StartDate);

            foreach (var course in result)
            {
                Console.WriteLine($"{course.Name} - {course.Resources}");
            }
        }

        private static void PrintAllCoursesByGivenDate(StudentSystemDbContext db)
        {
            var result = db
                    .Courses
                    .Where(c => c.StartDate > new DateTime(2017, 9, 28))
                    .Select(c => new
                    {
                        c.Name,
                        c.StartDate,
                        c.EndDate,
                        Duration = c.EndDate.Subtract(c.StartDate).TotalDays,
                        Students = c.Students.Count
                    })
                    .OrderByDescending(c => c.Students)
                    .ThenByDescending(c => c.Duration);

            foreach (var course in result)
            {
                Console.WriteLine($"Course: {course.Name} -> {course.StartDate} - {course.EndDate}");
                Console.WriteLine($"Duration in days: {course.Duration}");
                Console.WriteLine($"Enrolled students: {course.Students}");
            }
        }

        private static void PrintStudentsCourses(StudentSystemDbContext db)
        {
            var result = db
                .Students
                .Where(s => s.Courses.Count >0)
                .Select(s => new
                {
                    s.Name,
                    Courses = s.Courses.Count,
                    TotalPrice = s.Courses.Sum(c => c.Course.Price),
                    AveragePrice = s.Courses.Average(c => c.Course.Price)

                    
                })
                .OrderByDescending(s => s.TotalPrice)
                .ThenByDescending(s => s.Courses)
                .ThenBy(s => s.Name);

            foreach (var student in result)
            { 
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Num of courses: {student.Courses}");
                Console.WriteLine($"Total price: {student.TotalPrice}");
                Console.WriteLine($"Average price per course: {student.AveragePrice:f2}");
            }
        }

        private static void SeedLicenses(StudentSystemDbContext db)
        {
            var resourses = db.Resources.Select(r => r.Id).ToList();

            for (int i = 0; i <resourses.Count(); i++)
            {
                var totalLicenses = random.Next(1, 4);

                for (int j = 0; j < totalLicenses; j++)
                {
                    db.Licenses.Add(new License
                    {
                        Name = $"License {i}{j}",
                        ResourceId =  resourses[i]
                    });
                }
            }

            db.SaveChanges();
        }

        private static void PrintAllCoursesWithResoursesAndLicenses(StudentSystemDbContext db)
        {
            var result = db
                .Courses
                .OrderByDescending(c => c.Resources.Count)
                .ThenBy(c => c.Name)
                .Select(c => new
            {
                c.Name,
                Resourses = c
                .Resources
                .OrderByDescending(r => r.Licenses.Count)
                .ThenBy(r => r.Name)
                .Select(r => new
                {
                    r.Name,
                    Licenses = r.Licenses.Select(l => l.Name)
                })             
            })
            .ToList();

            foreach (var course in result)
            {
                Console.WriteLine(course.Name);
                foreach (var resourse in course.Resourses)
                {
                    Console.WriteLine($"--{resourse.Name}");

                    foreach (var license in resourse.Licenses)
                    {
                        Console.WriteLine($"---{license}");
                    }
                }
                
            }
        }

        private static void PrintStudentsCoursesResourses(StudentSystemDbContext db)
        {
            var result = db
                .Students
                .Where(s => s.Courses.Any())
                .Select(s => new
                {
                    s.Name,
                    Courses = s.Courses.Count,
                    Resourses = s.Courses.Sum(c => c.Course.Resources.Count),
                    Licenses = s.Courses.Sum(c => c.Course.Resources.Sum(r => r.Licenses.Count()))
                })
                .Take(10)
                .ToList();

            foreach (var student in result)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine($"Courses: {student.Courses}");
                Console.WriteLine($"Resourses {student.Resourses}");
                Console.WriteLine($"Licenses {student.Licenses}");
                Console.WriteLine("-------");
            }
        }

    }
}
