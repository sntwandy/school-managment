using System;
using Core.Entities.Types;
using Core.Entities;
using static System.Console;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Darcy Institute", 2017, SchoolTypes.HighSchool, city: "La Vega", country:"DR");

            // Create course objects array
            school.Courses = new Course[]
            {
                new Course() { Name = "101" },
                new Course() { Name = "201" },
                new Course() { Name = "301" },
            };
            school = null;

            // Method to print school courses array
            static void PrintSchoolCourses(School school)
            {

                if (school?.Courses != null)
                {
                    WriteLine("==================================");
                    WriteLine($"{school.Name} School courses");
                    WriteLine("==================================");
                    foreach (Course course in school.Courses)
                    {
                        WriteLine($"Course name: {course.Name}, Course Id: {course.UniqueId}");
                    }
                }
                WriteLine("==================================");
            }
            PrintSchoolCourses(school);
        }
    }
}
