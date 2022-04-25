using System;

namespace C_Sharp_Exercises
{
    internal class MethodNames
    {
        // Variables
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

        //Operators
        /*
         * CompareX_Y();
         * GradeCalculator();
         * XtoY();
         * XtoY_Even();
         * XtoY_Sum();
         * XtoY_Average();
         */

        //Loops
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

        //Methods
        /*
         * Multiplication();
         * SquareOfNumber();
         * SquareRoot();
         * String10Times();
         * TriangleArea();
         * StringLength();
         * MultiplicationWithSum(); 
         */

        //Arrays
        /*
         * Derby();
         * ClassroomAverage();
         * Lottery();
         * DiceAnalytics();
         * ClassroomArray();
         * ThreeToTwoMatrix();
         */



    }

    internal class Variables
    {
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
            num = Convert.ToInt32(Console.ReadLine());
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

            double cant = (fahr - 32) / 1.8;
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
            Console.WriteLine("Equation of ({0}x + {1} = 0) x equal to: {2}", a, b, x);
        }
    }

    internal class Operators
    {

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

    internal class Loops
    {

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

            for (int i = 0; i <= n; i += 2)
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
                    Console.Write(i * j + "\t");
                }

                Console.WriteLine();
            }
        }
    }

    internal class Methods
    {
        public void Multiplication()
        {
            int x, y, answer;
            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            answer = x * y;
            Console.Write("X({0}) * Y({1}) = {2}", x, y, answer);

        }

        static void SquareOfNumber()
        {
            int x, y, answer = 1;
            Console.Write("Enter number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter square of number: ");
            y = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                answer *= x;
            }

            Console.Write("X({0}) ^ Y({1}) = {2}", x, y, answer);
        }

        static void SquareRoot()
        {
            float x, answer;
            Console.Write("Enter number: ");
            x = Convert.ToInt32(Console.ReadLine());
            answer = MathF.Sqrt(x);
            Console.WriteLine("Square root of X({0}) is = {1}", x, answer);
        }

        static void String10Times()
        {
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(word);
            }
        }

        static void TriangleArea()
        {
            double b, h, area;

            Console.Write("Please enter triangle width: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter triangle height: ");
            h = Convert.ToDouble(Console.ReadLine());

            area = 0.5 * (b * h);
            Console.WriteLine("Area of triangle is: {0}", area);
        }

        static void StringLength()
        {
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(word.Length);
        }

        static void MultiplicationWithSum()
        {
            int x, y, answer = 0;
            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                answer += x;
            }
            Console.Write("Y({1}) times X({0})  = {2}", x, y, answer);
        }
    }

    internal class Arrays
    {
        
        static void Derby()
        {
            string[] gs = new string[11];
            string[] fb = new string[11];

            Console.WriteLine("Enter GS players ");
            for (int i = 0; i < gs.Length; i++)
            {
                Console.Write("Player{0} of GS is: ", i);
                gs[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter FB players ");
            for (int i = 0; i < fb.Length; i++)
            {
                Console.Write("Player{0} of FB is: ", i);
                fb[i] = Console.ReadLine();
            }

            for (int i = 0; i < gs.Length; i++)
            {
                Console.WriteLine("GS_{0} = {1}  -  FB_{0} = {2}", i, gs[i], fb[i]);
            }
        }

        static void ClassroomAverage()
        {
            int[] classroom = new int[10];
            int total = 0;
            int average = 0;

            Console.WriteLine("Enter classroom grades ");
            for (int i = 0; i < classroom.Length; i++)
            {
                Console.Write("{0}. student grade is: ", i + 1);
                classroom[i] = Convert.ToInt32(Console.ReadLine());
                total += classroom[i];
            }

            average = total / classroom.Length;
            Console.WriteLine("Classroom average is {0}", average);

            Array.Sort(classroom);
            int lowest = classroom[0];
            int highest = classroom[classroom.Length - 1];
            Console.WriteLine("Highest score is {0} and Lowest is {1}", highest, lowest);

        }

        static void Lottery()
        {
            int[] lottery = new int[6];
            Random r = new Random();

            for (int i = 0; i < lottery.Length; i++)
            {
                lottery[i] = r.Next(10);
            }

            for (int i = 0; i < lottery.Length; i++)
            {
                Console.Write(lottery[i] + "\t");
            }
        }

        static void DiceAnalytics()
        {
            int[] diceResult = new int[100];
            int[] diceAnalytic = new int[6];
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                diceResult[i] = r.Next(1, 7);
                Console.WriteLine(diceResult[i]);

                switch (diceResult[i])
                {
                    case 1: diceAnalytic[0] += 1; break;
                    case 2: diceAnalytic[1] += 1; break;
                    case 3: diceAnalytic[2] += 1; break;
                    case 4: diceAnalytic[3] += 1; break;
                    case 5: diceAnalytic[4] += 1; break;
                    case 6: diceAnalytic[5] += 1; break;
                    default: break;
                }

            }

            for (int i = 0; i < diceAnalytic.Length; i++)
            {
                Console.WriteLine((i + 1) + " rolled {0} times ", diceAnalytic[i]);
            }

        }

        static void ClassroomArray()
        {
            string[] classroomNames = new string[10];
            int[] classroomGrades = new int[10];
            string[,] classroomMatrix = new string[2, 5];
            int count = 0;

            for (int i = 0; i < classroomNames.Length; i++)
            {
                Console.Write("Enter {0}. Student name: ", i + 1);
                classroomNames[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Enter {0}. Student grade: ", i + 1);
                classroomGrades[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    classroomMatrix[i, j] = classroomNames[count] + Convert.ToString(classroomGrades[count]);
                    Console.Write(classroomMatrix[i, j] + "\t");
                    count++;
                }
                Console.WriteLine();

            }





        }

        static void ThreeToTwoMatrix()
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("Matrix ({0})({1}) ", i, j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Combination
    {
        static void Main(string[] args)
        {
            int n, r; double c;

            Console.Write("n değeri: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("r değeri: ");
            r = Convert.ToInt32(Console.ReadLine());

            c = f(n) / (f(r) * f(n-r));

            Console.Write("Kombi = " + c);

        }

        static int f(int x)
        {
            int fk = 1;
            for (int i = 1; i <= x; i++)
            {
                fk = fk * i;
            }
            return fk;
        }
    }




}


