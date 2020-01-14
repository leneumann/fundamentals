using System;

namespace src.dataStructures.array
{
    public class ArrayTraversalDiagonally
    {
        public static string TraverseMatrix(string[,] matrix)
        {
            int totalRows = matrix.GetUpperBound(0) - matrix.GetLowerBound(0);
            int totalCols = matrix.GetUpperBound(1) - matrix.GetLowerBound(1);
            var row = 0;
            var col = 0;
            string result = "";

            for (int i = 0; i <= totalRows; i++)
            {
                row = i;
                col = 0;

                while (row >= 0 && col <= totalCols)
                {
                    result += matrix[row, col];
                    row -= 1;
                    col += 1;
                }

            }

            for (int i = 1; i <= totalCols; i++)
            {
                row = totalRows;
                col = i;

                while (row >= 0 && col <= totalCols)
                {

                    result += matrix[row, col];
                    row -= 1;
                    col += 1;
                }
            }

            return result;
        }

        public static string TraverseMatrixInverted(string[,] matrix)
        {
            int totalRows = matrix.GetUpperBound(0) - matrix.GetLowerBound(0);
            int totalCols = matrix.GetUpperBound(1) - matrix.GetLowerBound(1);
            var row = 0;
            var col = totalCols;
            string result = "";

            for (int i = 0; i <= totalRows; i++)
            {
                row = i;
                col = totalCols;

                while (row >= 0 && col >= 0)
                {
                    result += matrix[row, col];
                    row -= 1;
                    col -= 1;
                }
            }

            for (int i = totalCols - 1; i >= 0; i--)
            {
                row = totalRows;
                col = i;

                while (col >= 0 && row >= 0)
                {
                    result += matrix[row, col];
                    row -= 1;
                    col -= 1;
                }
            }
            return result;
        }
    }
}