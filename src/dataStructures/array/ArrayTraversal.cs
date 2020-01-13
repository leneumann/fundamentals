namespace src.dataStructures.array
{
    public class ArrayTraversal
    {
        public static string TraverseMatrixDiagonally(string[,] matrix)
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

                while (row >= 0 && col <=totalCols)
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

                while (col <= totalCols)
                {

                    result += matrix[row, col];
                    row -= 1;
                    col += 1;
                }
            }

            return result;
        }
    }
}