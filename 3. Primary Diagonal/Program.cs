using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowAndColCount=int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowAndColCount, rowAndColCount];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            int sum = 0;
            for (int row = 0; row < rowAndColCount; row++)
            {  
                for (int col = 0; col < rowAndColCount; col++)
                {
                    if (row == col) 
                    {
                        sum += matrix[row,col];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
