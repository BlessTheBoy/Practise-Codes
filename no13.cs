using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no13
    {
        public static void Maximal3x3()
        {
            Console.WriteLine("\n\n I would help you find the maximal 3x3 matrix from any rectangular matrix n by m.");
            Console.WriteLine("To get started, enter the the size of the matrix n by m and its elements below.");

            Console.Write("\nEnter the number of rows, n: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the number of columns, m: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix:");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            int maxSum = 0;
            int[] index = new int[] { 0, 0 };
            
            for (int row = 0; row < (rows - 2); row++)
            {
                for (int col = 0; col < (cols - 2); col++)
                {
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            sum += matrix[i,j];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        index[0] = row;
                        index[1] = col;
                    }
                    sum = 0;
                }
            }

            Console.WriteLine("\nThe maximal sum of 3x3 matrix is {0} and below is the 3x3 matrix", maxSum);
            for (int i = index[0]; i < index[0] + 3; i++)
            {
                for (int j = index[1]; j < index[1] + 3; j++)
                {
                    Console.Write("{0,5}", matrix[i,j]);
                }
                Console.Write("\n");
            }
        }
    }
}
