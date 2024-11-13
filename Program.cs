using System;

namespace NewC_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lengthArray = 10;
            int minRandomNumbers = 1;
            int maxRandomNumbers = 11;
            int inputUser;

            int[] numbers = new int[lengthArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumbers, maxRandomNumbers);
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine($"\nВведите количество здвигов массива.");
            inputUser = Convert.ToInt32(Console.ReadLine());

            while (inputUser != 0)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    int bufferNumder = numbers[i - 1];
                    numbers[i - 1] = numbers[i];
                    numbers[i] = bufferNumder;
                }

                inputUser--;
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.ReadKey();
        }
    }
}