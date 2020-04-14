using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
    Below is the list of all available code and their number:
    3   -   LexicographicalOrder
    4   -   ConsecutiveEqualElements
    5   -   ConsecutiveIncreasingElements
    6   -   IncreasingSequence
    7   -   KMaximalSum
    8   -   SelectionSort
    9   -   MaximalSum
    10  -   MostOccuring
    12  -   SquareMatrix
    13  -   Maximal3x3
    14  -   LongestString
    16  -   LongestString
    19  -   seiveOfErathostenes
    20  -   MergeSort
    21  -   QuickSort
    22  -   LargestArea");

            Console.Write("Enter the name or number of the code you want to run: ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "8":
                case "SelectionSort":
                    no8.SelectionSort();
                    break;
                case "9":
                case "MaximalSum":
                    no9.MaximalSum();
                    break;
                case "10":
                case "MostOccuring":
                    no10.MostOccuring();
                    break;
                case "12":
                case "SquareMatrix":
                    no12.SquareMatrix();
                    break;
                case "13":
                case "Maximal3x3":
                    no13.Maximal3x3();
                    break;
                case "16":
                case "LongestString":
                    no16.BinarySearch();
                    break;
                case "19":
                case "SeiveOfErathostenes":
                    no19.seiveOfErathostenes();
                    break;
                case "20":
                case "MergeSort":
                    no20.MergeSortCall();
                    break;
                case "21":
                case "QuickSort":
                    no21.QuickSortCall();
                    break;
                case "22":
                case "LargestArea":
                    no22.LargestArea();
                    break;
                default:
                    break;
            }
        }
        public static void PrintMatrix(int[][] squareMatrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,5}", squareMatrix[i][j]);
                }
                Console.Write("\n");
            }

            Console.Write("\n\n\n");
        }
    }
}
