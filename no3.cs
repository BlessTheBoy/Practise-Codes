using System;

namespace Chapter7
{
    class Program
    {
        static void Gain(string[] args)
        {
            char[] firstWord = new char[] { 'a', 'b', 'c' };
            char[] secondWord = new char[] { 'a', 'b', 'c', 'a' };

            int smaller = 0;
            int small = (firstWord.Length < secondWord.Length) ? firstWord.Length : secondWord.Length;
            for (int i = 0; i < small; i++)
            {
                if (firstWord[i] < secondWord[i])
                {
                    smaller = 1;
                    break;
                }
                else if (secondWord[i] < firstWord[i])
                {
                    smaller = 2;
                    break;
                }                
            }

            switch (smaller)
            {
                case 0:
                    if (firstWord.Length == secondWord.Length)
                    {
                        Console.WriteLine("The arrays are lexographically equal.");
                    }
                    else if (firstWord.Length < secondWord.Length)
                    {
                        Console.WriteLine("The first word comes first lexographically.");
                    }
                    else
                    {
                        Console.WriteLine("The second word comes first lexographically.");
                    }
                    
                    break;
                case 1:
                    Console.WriteLine("The first word comes first lexographically.");
                    break;
                case 2:
                    Console.WriteLine("The second word comes first lexographically.");
                    break;
                default:
                    break;
            }
        }
    }
}
