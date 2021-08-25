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
            var courseOne = new Course()
            {
                Name = "101"
            };
            var courseTwo = new Course()
            {
                Name = "201"
            };
            var courseThird = new Course()
            {
                Name = "301"
            };
            Console.WriteLine(school);
            Console.WriteLine(courseOne.Name + ", " + courseOne.UniqueId);
        }
    }
}
