using src.dataStructures.array;
using Xunit;

namespace test.dataStructure.array
{
    public class ArrayTraversalDiagonallyTest
    {

        [Fact]
        public void GivenValidMatrixWhenTraverseDiagonallyThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" } };

            //When
            string result = ArrayTraversalDiagonally.TraverseMatrix(matrix);
            //Then
            Assert.Equal("adbgechfi", result);
        }
        [Fact]
        public void GivenMatrixWithMoreColumsThanRowsWhenTraverseDiagonallyThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
            { "a", "b", "c", "d" },
            { "e", "f", "g", "h" },
            { "i", "j", "k", "l" }
        };
            //When
            string result = ArrayTraversalDiagonally.TraverseMatrix(matrix);
            //Then
            Assert.Equal("aebifcjgdkhl", result);
        }
        [Fact]
        public void GivenMatrixWithMoreRowsThanColumsWhenTraverseDiagonallyThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" },
                { "j", "k", "l" } };
            //When
            string result = ArrayTraversalDiagonally.TraverseMatrix(matrix);
            //Then
            Assert.Equal("adbgecjhfkil", result);
        }

        [Fact]
        public void GivenValidMatrixWhenTraverseDiagonallyInvertedThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" } };

            //When
            string result = ArrayTraversalDiagonally.TraverseMatrixInverted(matrix);

            //Then
            Assert.Equal("cfbieahdg", result);
        }

        [Fact]
        public void GivenMatrixWithMoreColumsThanRowsWhenTraverseDiagonallyInvertedThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
            { "a", "b", "c", "d" },
            { "e", "f", "g", "h" },
            { "i", "j", "k", "l" }
        };
            //When
            string result = ArrayTraversalDiagonally.TraverseMatrixInverted(matrix);
            //Then
            Assert.Equal("dhclgbkfajei", result);
        }

        [Fact]
        public void GivenMatrixWithMoreRowsThanColumsWhenTraverseInvertedThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" },
                { "j", "k", "l" } };
            //When
            string result = ArrayTraversalDiagonally.TraverseMatrixInverted(matrix);

            //Then
            Assert.Equal("cfbiealhdkgj", result);
        }

        [Fact]
        public void Given5rowsX10colsMatrixWhenTraversedThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"}};
            //When
            string result = ArrayTraversalDiagonally.TraverseMatrix(matrix);
            //Then
            Assert.Equal("1121231234123452345634567456785678967891078910891091010", result);
        }

        [Fact]
        public void Given10rowsX5colsMatrixWhenTraversedThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                {"1", "2", "3", "4", "5"},
                {"6", "7", "8", "9", "10"},
                {"1", "2", "3", "4", "5"},
                {"6", "7", "8", "9", "10"},
                {"1", "2", "3", "4", "5"},
                {"6", "7", "8", "9", "10"},
                {"1", "2", "3", "4", "5"},
                {"6", "7", "8", "9", "10"},
                {"1", "2", "3", "4", "5"},
                {"6", "7", "8", "9", "10"}};
            //When
            string result = ArrayTraversalDiagonally.TraverseMatrix(matrix);
            //Then
            Assert.Equal("1621736284173956284101739562841017395628410739584109510",result);
        }
    }
}