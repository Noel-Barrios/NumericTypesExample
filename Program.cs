using System;

namespace NumericTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicIntegerMath();
            //OrderOfOperations();
            //IntegerPrecisionAndLimits();
            ExploringIntegerLimits();
        }


        static void BasicIntegerMath()
        {
            int a = 18;
            int b = 6;

            // addition
            int c = a + b;
            display(c);

            // subtration
            c = a - b;
            display(c);

            //multiplication
            c = a * b;
            display(c);

            //division
            c = a / b;
            display(c);
        }

        static void OrderOfOperations()
        {
            // EXPLORING THE ORDER OF OPERATIONS
            // The rules are consistent with the rules you learned in mathematics.
            int a = 5;
            int b = 4;
            int c = 2;
            int d;

            d = a + b * c;
            display(d);

            d = (a + b) * c;
            display(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            display(d);

            //REMEMBER: Integer division always produces an integer result, 
            //even when you'd expect the result to include a decimal or fractional portion.
        }

        static void IntegerPrecisionAndLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine($"Quotient: {d}");
            Console.WriteLine($"Remainder: {e}");

        }

        static void ExploringIntegerLimits()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            display(max);
            display(min);


            //if a calculation produces a value that exceeds those limits, you have an underflow
            // or overflow condition. Here is an example of overflow.
            int what = max + 3;
            display(what);
        }


        static void display(int num)
        {
            //Console.WriteLine("\n");
            Console.WriteLine(num);
        }
    }
}
