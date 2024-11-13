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

            for (int i = inputUser; i > 0; i--)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    int bufferNumder = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = bufferNumder;
                }
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