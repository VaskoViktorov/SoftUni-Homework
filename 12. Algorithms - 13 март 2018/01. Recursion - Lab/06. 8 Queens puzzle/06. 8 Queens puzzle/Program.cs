using System;
using System.Collections.Generic;

namespace _06._8_Queens_puzzle
{
    class Program
    {
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
        static bool[] attackedColumns = new bool[Size];
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static bool[] attackedRightDiagonals = new bool[Size * Size];
        //private static int SolutionsFound = 0;

        public static void Main(string[] args)
        {
            PutQueens(0);
            //Console.WriteLine(SolutionsFound);
        }

        static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }

            for (int col = 0; col < Size; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    MarkAllAttackedPositions(row, col);
                    PutQueens(row + 1);
                    UnMarkAllAttackedPositions(row, col);
                }
            }
        }

        private static void UnMarkAllAttackedPositions(int row, int col)
        {
            attackedColumns[col] = false;
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals[row + col + 1] = false;
            chessboard[row, col] = false;
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            attackedColumns[col] = true;
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals[row + col + 1] = true;
            chessboard[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied =
                attackedColumns[col] ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRightDiagonals[row + col + 1];

            return !positionOccupied;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (chessboard[row, col])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();
           // SolutionsFound++;
        }
    }
}

