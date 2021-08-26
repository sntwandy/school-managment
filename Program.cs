using System;
using Core.Entities.Types;
using Core.Entities;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Darcy Institute", 2017, SchoolTypes.HighSchool, city: "La Vega", country:"DR");

            // Create course objects array of 3
            var courseArray = new Course[3];

            // Print an course array
            static void PrintCourses(Course[] courseArray)
            {
                int counter = 0;
                while (counter < courseArray.Length)
                {
                    Console.WriteLine($"Course name: {courseArray[counter].Name}, Course Id: {courseArray[counter].UniqueId}");
                    counter++;
                }
            }

            courseArray[0] = new Course()
            {
                Name = "101"
             };
            courseArray[1] = new Course()
            {
               Name = "201"
             };
            courseArray[2] = new Course()
            {
               Name = "301"
             };

            Console.WriteLine(school);
            PrintCourses(courseArray);
        }
    }
}
