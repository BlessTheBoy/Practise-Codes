using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no19
    {
        public static void seiveOfErathostenes()
        {
            Console.Write("\n\nEnter search limit:\t");
            int limit = int.Parse(Console.ReadLine());
            int[] nums = new int[limit - 1];
            for (int i = 2; i < limit + 1; i++)
            {
                nums[(i - 2)] = i;
            }

            int p = 2;
            int indexAt = 0;
            bool limitReached = false;
            while (!limitReached)
            {
                for (int i = 0; i < (limit - 1); i++)
                {
                    int v = nums[i];
                    if (v % p == 0 && v != p) nums[i] = 0;
                }
                do
                {
                    p = nums[++indexAt];
                    if (indexAt >= (limit/2))
                    {
                        limitReached = true;
                        break;
                    }
                } while (p == 0);
            }


            Console.WriteLine("Below are all prime numbers between 1 and {0}\n", limit);
            for (int i = 0; i < limit - 1; i++)
            {
                if (nums[i] != 0)
                {
                    Console.Write("{0},  ", nums[i]);
                }                
            }
        }
    }
}
