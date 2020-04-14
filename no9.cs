using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no9
    {
        public static void MaximalSum()
        {
            int sum = 0, tempSum;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int start =0, count = 0;

            for (int i = 0; i < length - 1; i++)
            {
                tempSum = arr[i];
                

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        start = i;
                        count++;
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Result is {0}. and the subsequence is (", sum);
            for (int i = 0; i < count; i++)
            {
                Console.Write(" {0},",arr[i + start]);
            }
            Console.WriteLine(")");
        }
    }
}
