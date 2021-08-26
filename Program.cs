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

            // Print an course array with differents ways
            static void PrintCourses(Course[] courseArray)
            {
                // Using while
                /*int counterWhile = 0;
                while (counterWhile < courseArray.Length)
                {
                    Console.WriteLine($"Course name: {courseArray[counterWhile].Name}, Course Id: {courseArray[counterWhile].UniqueId}");
                    counterWhile++;
                }*/

                // Using do while
                /*int counterDo = 0;
                do
                {
                    Console.WriteLine($"Course name: {courseArray[counterDo].Name}, Course Id: {courseArray[counterDo].UniqueId}");
                    counterDo++;
                } while (counterDo < courseArray.Length);*/

                // Using for
               /*for (int i = 0; i < courseArray.Length; i++)
                {
                    Console.WriteLine($"Course name: {courseArray[i].Name}, Course Id: {courseArray[i].UniqueId}");
                };*/

                // Using foreach
                foreach (Course course in courseArray)
                {
                    Console.WriteLine($"Course name: {course.Name}, Course Id: {course.UniqueId}");
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
