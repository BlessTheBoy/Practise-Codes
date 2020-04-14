using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no21
    {
        public static void QuickSortCall()
        {
            Console.Write("Enter length of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            QuickSort(arr, 0, (n - 1));
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
        }

        static void QuickSort(int[] arr, int start, int end)
        {
            if (end > start)
            {
                int pivot = Pivot(arr, start, end);
                QuickSort(arr, start, (pivot - 1));
                QuickSort(arr, (pivot + 1), end);
            }
        }

        static int Pivot (int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int index = start;
            for (int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    int temp = arr[index];
                    arr[index++] = arr[i];
                    arr[i] = temp;
                }
            }
            int hold = arr[index];
            arr[index] = pivot;
            arr[end] = hold;
            return index;
        }
    }
}
