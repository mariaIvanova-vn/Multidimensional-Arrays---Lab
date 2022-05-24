using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numOfRowsAndCols, numOfRowsAndCols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               string rowInput=Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currChar = rowInput[col];
                    matrix[row, col] = currChar;
                }
            }
            string symbol = Console.ReadLine();  
            for (int row = 0; row < numOfRowsAndCols; row++)
            {
                for (int col = 0; col < numOfRowsAndCols; col++)
                {
                    if (matrix[row,col] == char.Parse(symbol))
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
