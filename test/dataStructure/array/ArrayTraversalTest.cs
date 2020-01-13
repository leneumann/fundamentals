using src.dataStructures.array;
using Xunit;

namespace test.dataStructure.array
{
    public class ArrayTraversalTest
    {

        [Fact]
        public void GivenValidMatrixWhenTraverseThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" } };

            //When
            string result = ArrayTraversal.TraverseMatrixDiagonally(matrix);
            //Then
            Assert.Equal("adbgechfi", result);
        }
        [Fact]
        public void GivenMatrixWithMoreColumsThanRowsWhenTraverseThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
            { "a", "b", "c", "d" },
            { "e", "f", "g", "h" },
            { "i", "j", "k", "l" }
        };
            //When
            string result = ArrayTraversal.TraverseMatrixDiagonally(matrix);
            //Then
            Assert.Equal("aebifcjgdkhl", result);
        }
        [Fact]
        public void GivenMatrixWithMoreRowsThanColumsWhenTraverseThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" },
                { "j", "k", "l" } };
            //When
            string result = ArrayTraversal.TraverseMatrixDiagonally(matrix);
            //Then
            Assert.Equal("adbgecjhfkil", result);
        }

        [Fact]
        public void GivenValidMatrixWhenTraverseInvertedThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" } };

            //When
            string result = ArrayTraversal.TraverseMatrixDiagonallyInverted(matrix);

            //Then
            Assert.Equal("cfbieahdg",result);
        }

        [Fact]
         public void GivenMatrixWithMoreColumsThanRowsWhenTraverseInvertedThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
            { "a", "b", "c", "d" },
            { "e", "f", "g", "h" },
            { "i", "j", "k", "l" }
        };
            //When
            string result = ArrayTraversal.TraverseMatrixDiagonallyInverted(matrix);
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
            string result = ArrayTraversal.TraverseMatrixDiagonallyInverted(matrix);
        
            //Then
            Assert.Equal("cfbiealhdkgj",result);
        }
    }
}