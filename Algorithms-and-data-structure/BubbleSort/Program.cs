using System;

namespace BubbleSort
{
    public class bubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 78, 55, 45, 43, 23, 42, 32, 56, 84, 54, 45, 13 };

            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {

                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            Console.Write("Sorted array is: ");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.WriteLine();
        }
    }
   
}
