using src.dataStructure.array;
using Xunit;

namespace test.dataStructure.array
{
    public class ArrayTraversalTest
    {
        [Fact]
        public void GivenValidMatrixWhenTraverseHorizontallyThenReturnValidResult()
        {
            //Given
            string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" } };

            //When
            string result = ArrayTraversal.TraverseHorizontally(matrix);
            
            //Then
            Assert.Equal("abcdefghi",result);
            
        }

        [Fact]
        public void Given10rowsX5ColsMatrixWhenTraverseHorizontallyThenReturnValidResult()
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
        string result = ArrayTraversal.TraverseHorizontally(matrix);
        //Then
        Assert.Equal("1234567891012345678910123456789101234567891012345678910",result);
        }

        [Fact]
        public void Given5rowsX10colsMatrixWhenTraverseHorizontallyThenReturnValidResult()
        {
        //Given
         string[,] matrix = {
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"}};
        //When
        string result = ArrayTraversal.TraverseHorizontally(matrix);
        //Then
        Assert.Equal("1234567891012345678910123456789101234567891012345678910",result);
        }

        [Fact]
        public void GivenValidMatrixWhenTraverseVerticallyThenReturnValidResult()
        {
        //Given
         string[,] matrix = {
                { "a", "b", "c" },
                { "d", "e", "f" },
                { "g", "h", "i" } };
        //When
        string result = ArrayTraversal.TraverseVertically(matrix);
        //Then
        Assert.Equal("adgbehcfi",result);
        }

        [Fact]
        public void Given10rowsX5ColsMatrixWhenTraverseVerticallyThenReturnValidResult()
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
        string result = ArrayTraversal.TraverseVertically(matrix);
        //Then
        Assert.Equal("1616161616272727272738383838384949494949510510510510510",result);
        }

        [Fact]
        public void Given5rowsX10colsMatrixWhenTraverseVerticallyThenReturnValidResult()
        {
        //Given
         string[,] matrix = {
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"},
                { "1", "2", "3","4", "5", "6","7", "8", "9","10"}};
        
        //When
        string result = ArrayTraversal.TraverseVertically(matrix);
        //Then
        Assert.Equal("1111122222333334444455555666667777788888999991010101010",result);
        }
    }
}