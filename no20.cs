using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no20
    {
        public static void MergeSortCall()
        {
            Console.Write("Enter length of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            MergeSort(arr, 0, (arr.Length - 1));
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);                
            }
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (right > left)
            {
                int mid = (right + left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, (mid + 1), right);
                Merge(arr, left, mid, right);
            }            
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[(right - left + 1)];
            int i = left , j = mid + 1 ,k = 0;
            while(i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }
            for (int r = 0; r < (right - left + 1); r++)
            {
                arr[left + r] = temp[r];
            }
        }
    }
}
