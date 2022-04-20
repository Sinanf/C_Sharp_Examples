using System;

namespace C_Sharp_Loops 
{
    class Loops
    {
        static void Main(string[] args)
        {
            /*
             * ZeroToN();
             * ZeroToN_Even();
             * ExceptOne();
             * EquationSolver();
             * CircleInfo();
             * CelcToFahr();
             * NumberArray();
             * MultiplicationTable();
             */


            MultiplicationTable();

        }

        static void ZeroToN()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + "\t");
            }
        }

        static void ZeroToN_Even()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= n; i+=2)
            {
                sum += i;
                Console.Write(i + "\t");                
                
            }
            Console.Write("\n");
            Console.WriteLine("Total is: " + sum);
        }

        static void ExceptOne()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number for exclusion: ");
            int ex = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == ex)
                {
                    continue;
                }   
                sum += i;   
            }
            
            Console.WriteLine("Total is: " + sum);
        }

        static void EquationSolver()
        {
            double a, x, b;

            for (a = 1; a <= 10; a++)
            {
                for (b = 1; b <= 10; b++)
                {
                    x = ((2 * a) - b);
                    Console.WriteLine("a = {0} b = {1} x = {2}", a, b, x);
                }
            }

        }

        static void CircleInfo()
        {
            const double pi = 3.14;
            double radius, area, perimeter;

            for (radius = 1; radius <= 10; radius++)
            {

                area = radius * radius * pi;
                perimeter = 2 * radius * pi;
                Console.WriteLine("Radius = {0}, Perimeter = {1}, Area = {2}", radius, perimeter, area);

            }

        }

        static void CelcToFahr()
        {
            double fahr, celc;
            for (celc = 0; celc <= 100; celc++)
            {
                fahr = ((1.8 * celc) + 32);
                Console.WriteLine("Celcius = {0} == Fahrenheit = {1}", celc, fahr);
            }
        }

        static void NumberArray()
        {
            int start, end, count;

            Console.Write("Enter starting number: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ending number: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter increasement: ");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i < end; i += count)
            {
                Console.WriteLine(i);
            }     

        }

        static void MultiplicationTable()
        {
            
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(i*j + "\t");
                }

                Console.WriteLine();
            }
        }


    }
}