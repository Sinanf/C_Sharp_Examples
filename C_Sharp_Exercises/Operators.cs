using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Exercises
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            /*
             * CompareX_Y();
             * GradeCalculator();
             * XtoY();
             * XtoY_Even();
             * XtoY_Sum();
             * XtoY_Average();
             */

        }

        static void CompareX_Y()
        {
            int x = 0;
            Console.WriteLine("X: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y = 0;
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");

            if (x > y)
            {
                Console.WriteLine("X is higher than Y");
            }
            else if (x == y)
            {
                Console.WriteLine("X is equal Y");
            }
            else if (x < y)
            {
                Console.WriteLine("X is lower than Y");
            }
        }

        static void GradeCalculator()
        {
            int exam1 = 0;
            Console.Write("First Exam: ");
            exam1 = Convert.ToInt32(Console.ReadLine());

            int exam2 = 0;
            Console.Write("Second Exam: ");
            exam1 = Convert.ToInt32(Console.ReadLine());


            int final = 0;
            Console.Write("Final Exam: ");
            final = Convert.ToInt32(Console.ReadLine());


            int grade = (exam1 * 40 / 100) + (exam2 * 40 / 100) + (final * 60 / 100);
            if (grade < 50)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }

        static void XtoY()
        {
            int x;
            Console.Write("Starting number: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y = 0;
            Console.Write("Last number: ");
            y = Convert.ToInt32(Console.ReadLine());


            for (int i = x; i <= y; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void XtoY_Even()
        {
            int x;
            Console.Write("Starting number: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y = 0;
            Console.Write("Last number: ");
            y = Convert.ToInt32(Console.ReadLine());


            for (int i = x; i <= y; i += 2)
            {
                Console.WriteLine(i);

            }

        }

        static void XtoY_Sum()
        {
            int x;
            Console.Write("Starting number: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.Write("Last number: ");
            y = Convert.ToInt32(Console.ReadLine());

            int sum = 0;


            for (int i = x; i <= y; i++)
            {
                sum += i;

            }

            Console.WriteLine(sum);

        }

        static void XtoY_Average()
        {
            int x;
            Console.Write("Starting number: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.Write("Last number: ");
            y = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int total = (y - x) + 1;


            for (int i = x; i <= y; i++)
            {
                sum += i;

            }

            Console.WriteLine(sum / total);

        }
    }
}
