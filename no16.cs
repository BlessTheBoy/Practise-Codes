using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no16
    {
        public static void BinarySearch()
        {
            Console.WriteLine("\n\n I would help you find the index of any element in a sorted array.");
            Console.WriteLine("To get started, enter the length of the matrix and its elements below.");

            

            Console.Write("\nEnter the length of the matrix: ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int [len];

            Console.WriteLine("Enter the cells of the matrix:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(" Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter element whose index is to be found: ");
            int x = int.Parse(Console.ReadLine());

            int result = BinSearch(arr, 0, (arr.Length - 1), x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element {0} is found at index {1}", x, result);
        }

        private static int BinSearch(int[] arr, int l, int r, int x)
        {
            if (r >= 1)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return BinSearch(arr, l, mid - 1, x);
                return BinSearch(arr, mid + 1, r, x);
            }
            return -1;
        }
    }
}
