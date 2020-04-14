using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no4
    {
        static void Gain(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 2, 2, 2, 2, 2, 3, 3, 5, 5, 5, 5, 5, 7, 7, 9, 9, 9 };
            int lenght = 0;
            int index = 0;
            int count = 1;
            int Pindex = 0;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    count++;                    
                }
                else
                {
                    count = 1;
                    Pindex = i + 1;
                    
                }
                if (lenght < count)
                {
                    lenght = count;
                    index = Pindex;
                }
            }

            Console.WriteLine("Below is the longest repeating number\n");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("{0}", numbers[index + i]);
            }
        }
    }
}
