using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] array = { 53, 19, 71, 3, 66, 62, 20, 84, 45, 65 };
             int length = array.Length;

             for (int h = length / 2; h > 0; h /= 2)
             {
                for (int i = h; i < length; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= h && array[j - h] > temp; j = j - h)
                    {
                        array[j] = array[j - h];
                    }
                    array[j] = temp;
                }
             }
            Console.Write("Sorted array is: ");
             foreach (var item in array)
             {
                Console.Write(item + " ");
             }
            Console.WriteLine();
        }
    }
}
