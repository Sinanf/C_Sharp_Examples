using System;

namespace C_Sharp_Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            /*
             * NameInput();
             * SquareOfNumber();
             * Sumof2Num();
             * Averageof3Num();
             * RectangleAreaPerimeter();
             * CircleAreaPerimeter();
             * InchToCm();
             * FahrenToCantigrad();
             * OneUnknownEquation();
             */

            OneUnknownEquation();
        }

        static void NameInput()
        {
            string name = " ";
            Console.Write("Input your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello " + name);
        }

        static void SquareOfNumber()
        {
            int num;
            Console.Write("Input number for square: ");
            num = Convert.ToInt32(Console.ReadLine()) ;
            int square = num * num;
            Console.WriteLine("Square of number is = " + square);
        }

        static void Sumof2Num()
        {
            int num1;
            Console.Write("Input for num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            int num2;
            Console.Write("Input for num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Sum of two number is = " + sum);
        }

        static void Averageof3Num()
        {
            int num1;
            Console.Write("Input for num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            int num2;
            Console.Write("Input for num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int num3;
            Console.Write("Input for num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average is = " + average);


        }

        static void RectangleAreaPerimeter()
        {
            double height;
            Console.Write("Rectangle height: ");
            height = Convert.ToDouble(Console.ReadLine());

            double width;
            Console.Write("Rectangle width: ");
            width = Convert.ToDouble(Console.ReadLine());

            double area = height * width;
            double perimeter = (height + width) * 2;
            Console.WriteLine("Rectangle's area is: " + area + " and perimeter is " + perimeter);
        }

        static void CircleAreaPerimeter()
        {
            const double pi = 3.14;

            double radius;
            Console.Write("Circle radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            
            double area = (2 * pi * radius);
            double perimeter = (pi * radius * radius);
            Console.WriteLine("Circle's area is: " + area + " and perimeter is " + perimeter);
        }

        static void InchToCm()
        {
            const double ratio = 2.54;

            double inch;
            Console.Write("Inch: ");
            inch = Convert.ToDouble(Console.ReadLine());

            double cm = (ratio * inch);            
            Console.WriteLine(inch + " is equal to: " + cm + " cm");
        }

        static void FahrenToCantigrad()
        {

            double fahr;
            Console.Write("Fahr: ");
            fahr = Convert.ToDouble(Console.ReadLine());

            double cant = (fahr - 32)/ 1.8;
            Console.WriteLine(fahr + " is equal to: " + cant + " C'");
        }

        static void OneUnknownEquation()
        {
            double a;
            Console.Write("Input for a: ");
            a = Convert.ToInt32(Console.ReadLine());

            double b;
            Console.Write("Input for b: ");
            b = Convert.ToInt32(Console.ReadLine());

            double x = (-b / a);
            Console.WriteLine("Equation of ({0}x + {1} = 0) x equal to: {2}", a,b,x );
        }
    }    
}


