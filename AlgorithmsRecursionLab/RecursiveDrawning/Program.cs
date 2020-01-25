using System;

namespace RecursiveDrawning
{
    class Program
    {
        static void Print(int index)
        {
            if (index == 0)
            {   
                return;
            }

            Console.WriteLine(new string('*', index));

            Print(index - 1);

            Console.WriteLine(new string('#', index));

        }

        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
        
            Print(inputNumber);
        }
    }
}
