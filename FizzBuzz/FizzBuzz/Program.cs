using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            int[] numbersArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                numbersArray[i] = i + 1;
            }

            foreach (int i in numbersArray)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                { Console.WriteLine(i); }

            }

        }
    }
}
