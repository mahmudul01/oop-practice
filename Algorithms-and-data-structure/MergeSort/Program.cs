using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class MergeSort
    {
        public void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
        public void Mergesort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Mergesort(input, left, middle);
                Mergesort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var MergeSort = new MergeSort();

            int[] arr = { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16, 89, -4 };

            MergeSort.Mergesort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

        }
    }
}