using System;

namespace RecursiveFactorial
{
    class Program
    {
        static long Factorial(int num)
        {
            if (num==0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            long factorial = Factorial(number);

            Console.WriteLine(factorial);
        }
    }
}
