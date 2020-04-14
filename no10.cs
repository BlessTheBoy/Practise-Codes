using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no10
    {
        public static void MostOccuring()
        {
            Console.WriteLine("");
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int num = arr[0];
            
            int maxCount = 1;

            for (int i = 0; i < length; i++)
            {
                int count = 0;
                for (int j = 0; j < length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;                       
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        num = arr[i];
                    }
                }
            }

            Console.WriteLine("\nThe most occuring number is {0}, it appeared {1} times in the set.", num, maxCount);
        }
    }
}
