using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class no12
    {
        public static void SquareMatrix()
        {
            Console.Write("Enter the size of the matrix: ");
            int size = int.Parse(Console.ReadLine());

            int[][] squareMatrix1 = new int[size][];
            for (int i = 0; i < size; i++)
            {
                squareMatrix1[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    squareMatrix1[i][j] = (size * j) + (i + 1);
                    
                }
                
            }
            

            int[][] squareMatrix2 = new int[size][];
            int n = 1;
            for (int i = 0; i < size; i++)
            {
                squareMatrix2[i] = new int[size];
            }
            for (int i = 0; i < size; i++)
            {                
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0)
                    {
                        squareMatrix2[j][i] = n;                       
                        n++;
                    }
                    else
                    {
                        int inv = Math.Abs(size - j - 1);
                        squareMatrix2[inv][i] = n;                        
                        n++;
                    }
                    
                }             
                
            }

            int[][] squareMatrix3 = new int[size][];

            for (int i = 0; i < size; i++)
            {
                squareMatrix3[i] = new int[size];
            }

            n = 1;

            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    squareMatrix3[size - (i - j)][j] = n;
                    n++;
                }
            }
            int r = 1;
            for (int i = (size-1); i > 0; i--)
            {                
                for (int j = 0; j < i; j++)
                {
                    squareMatrix3[j][j + r] = n;
                    n++;
                }
                r++;
            }

            int[][] squareMatrix4 = new int[size][];

            for (int i = 0; i < size; i++)
            {
                squareMatrix4[i] = new int[size];
            }

            int top = 0;
            int bottom = size - 1;
            int left = 0;
            int right = size - 1;
            int dir = 0;
            n = 1;

            for(int u = 1; u < (size*2); u++)
            {
                if (dir == 0)
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        squareMatrix4[i][left] = n;
                        n++;
                    }
                    left++;
                    dir++;
                }
                else if (dir == 1)
                {
                    for (int i = left; i <= right; i++)
                    {
                        squareMatrix4[bottom][i] = n;
                        n++;
                    }
                    bottom--;
                    dir++;
                }
                else if (dir == 2)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        squareMatrix4[i][right] = n;
                        n++;
                    }
                    right--;
                    dir++;
                }
                else if (dir == 3)
                {
                    for (int i = right; i >= left; i--)
                    {
                        squareMatrix4[top][i] = n;
                        n++;
                    }
                    top++;
                    dir = 0;
                }
            }

            Console.Write("\n\n");
            program.PrintMatrix(squareMatrix1, size);
            program.PrintMatrix(squareMatrix2, size);
            program.PrintMatrix(squareMatrix3, size);
            program.PrintMatrix(squareMatrix4, size);



        }
    }
}
