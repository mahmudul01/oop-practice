using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 5, -4, 11, -3, 22, 67, 51, 6, 68, 101 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            
            Console.WriteLine("Sorted Array Elements :");
            Console.WriteLine("");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

        }
    }
}
