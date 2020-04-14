using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no22
    {
        static int[,] arr;
        static int largest = 0;
        static int area;
        public static void LargestArea()
        {
            Console.Write("Enter number of rows of array: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of colums of array: ");
            int cols = int.Parse(Console.ReadLine());

            arr = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Enter element [{0},{1}]: ", row, col);
                    arr[row, col] = int.Parse(Console.ReadLine());
                }                
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (arr[row, col] != 0)
                    {
                        area = 1;
                        FindArea(row, col, arr[row, col]);
                    }
                }
            }

            Console.WriteLine("\n\nThe largest area in the matrix is {0}", largest);
        }

        static void FindArea(int row, int col, int element)
        {            
            arr[row, col] = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (!(i == row && j == col))
                    {
                        try
                        {
                            if (arr[i, j] == 0)
                            {
                                continue;
                            }
                            else if (arr[i, j] == element)
                            {
                                area++;
                                if (area > largest)
                                {
                                    largest = area;
                                }
                                FindArea(i, j, element);
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            
                        }
                    }
                }
            }
        }
    }
}
