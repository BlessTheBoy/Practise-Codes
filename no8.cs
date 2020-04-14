using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no8
    {
        public static void SelectionSort()
        {
            Console.Write("Enter length of array, N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        switchElements(arr, j);
                    }
                }
            }

            Console.Write("The array in ascending order is");
            for (int i = 0; i < n; i++)
            {
                Console.Write(", {0}", arr[i]);
            }
        }

        static int[] switchElements (int[] array, int r)
        {
            int temp = array[r];
            array[r] = array[r + 1];
            array[r + 1] = temp;
            return array;
        }
    }
}
