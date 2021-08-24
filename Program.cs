using System;
using Core.Entities;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Darcy Institute", 2017, SchoolTypes.MiddleSchool, city:"La Vega");
            Console.WriteLine(school);
        }
    }
}
