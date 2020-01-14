using System;

namespace src.dataStructure.array
{
    public class ArrayTraversal
    {
        public static string TraverseHorizontally(string[,] matrix)
        {
            int totalRows = matrix.GetUpperBound(0) - matrix.GetLowerBound(0);
            int totalCols = matrix.GetUpperBound(1) - matrix.GetLowerBound(1);
            string result = "";
            for (int row = 0; row <= totalRows; row++)
            {
                for (int col = 0; col <= totalCols; col++)
                {
                    result += matrix[row, col];
                }
            }
            return result;
        }

        public static string TraverseVertically(string[,] matrix)
        {
            int totalRows = matrix.GetUpperBound(0) - matrix.GetLowerBound(0);
            int totalCols = matrix.GetUpperBound(1) - matrix.GetLowerBound(1);
            string result = "";
            for (int col = 0; col <= totalCols; col++)
            {
                for (int row = 0; row <= totalRows; row++)
                {
                    result += matrix[row, col];
                }
            }
            return result;
        }
    }
}