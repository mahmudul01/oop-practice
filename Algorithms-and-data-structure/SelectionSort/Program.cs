using System;
namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] arr = new int[] { 56, 1, 99, 2, 5, -4, 11, -3, 22, 67, 51, 6, 68, 101, 97 };
            int temp, smallest;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j; 
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("Sorted array is: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
