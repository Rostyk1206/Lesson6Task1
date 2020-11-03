using System;
using System.Data;

namespace Lesson6Task2
{
    class Program
    {
        static int plusNumber(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int minusNumber(int a, int b)
        {
            int result = a - b;
            return result;
        }
        static int mnojNumber(int a, int b)
        {
            int result = a * b;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number 1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your action:");
            string k = Console.ReadLine();

            switch(k)
            {
                case ("+"):
                    {
                        int f = plusNumber(number1, number2);
                        Console.WriteLine(f);
                        break;
                    }
                case ("-"):
                    {
                        int f = minusNumber(number1, number2);
                        Console.WriteLine(f);
                        break;
                    }
                case ("*"):
                    {
                        int f = mnojNumber(number1, number2);
                        Console.WriteLine(f);
                        break;
                    }
            }
        }
    }
}
