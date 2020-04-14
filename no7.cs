using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no7
    {
        static void ain(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter K (K < N): ");
            int k = int.Parse(Console.ReadLine());

            int[] maxArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                maxArr[i] = int.MinValue;
            }
            
            int maxSum = 0;
            for (int i = 0; i < k; i++)
            {
                int u = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] >= maxArr[i])
                    {
                        maxArr[i] = arr[j];
                        u = j;
                    }
                }
                maxSum += maxArr[i];
                arr[u] = 0;
            }

            Console.WriteLine("The three largest values are {0}, {1} and {2} and the max sum is equal to {3}", maxArr[0], maxArr[1], maxArr[2], maxSum);
        }
    }
}
