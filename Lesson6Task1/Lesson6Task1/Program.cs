using System;

namespace Lesson6Task1
{
    class Program
    {
        static int CalculateIncrement(ref int a)
        {
            int result = ++a;
            return result;
        }
        static int CalculateDecriment(ref int a)
        {
            int result = --a;
            return result;
        }
        static void Main(string[] args)
        {
            int i = 9;
            int result1 = CalculateIncrement(ref i);
            Console.WriteLine(result1);

            int result2 = CalculateDecriment(ref i);
            Console.WriteLine(result2);
        }
    }
}
