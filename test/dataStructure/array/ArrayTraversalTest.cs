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
            Assert.Equal("aebifcjgdkhl",result);
        }
        [Fact]
        public void GivenAnMatrixWithMoreRowsThanColumsWhenTraverseThenReturnValidResult()
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
    }
}