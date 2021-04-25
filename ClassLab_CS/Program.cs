﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Course cs101 = new Course("cs101", 6, "Computer Science", "Mr. Smith");
            Course cs102 = new Course();

            cs102.Title = "cs102";
            cs102.CreditHours = 6;
            cs102.Program = "Computer Science";
            cs102.Instructor = "Mrs. Jones";

            Console.WriteLine("{0}, {1}, {2}, {3}", cs101.Title, cs101.CreditHours, cs101.Program, cs101.Instructor);
            Console.WriteLine();
            Console.WriteLine("{0}, {1}, {2}, {3}", cs102.Title, cs102.CreditHours, cs102.Program, cs102.Instructor);
            Console.WriteLine();
            Console.WriteLine(cs101.GetTitle());
            Console.WriteLine();
            Console.WriteLine(cs102.GetTitle());
        }
    }
}
