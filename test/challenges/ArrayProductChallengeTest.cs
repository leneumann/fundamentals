using src.challenges;
using Xunit;

namespace test.challenges
{
    public class ArrayProductChallengeTest
    {
        [Fact]
        public void GivenAnValidArrayWhenExecuteThenReturnNewArrayWithResultOfProducts()
        {
            //Given
            int[] array = { 1, 2, 3 };
            ArrayProductChallenge arrayProduct = new ArrayProductChallenge();
            //When
            int[] result = arrayProduct.Execute(array);
            //Then
            Assert.Equal(6, result[0]);
            Assert.Equal(3, result[1]);
            Assert.Equal(2, result[2]);
        }

        [Fact]
        public void GivenAnFiveElementsValidArrayWhenExecuteThenReturnNewArrayWithResultOfProducts()
        {
            //Given
            int[] array = { 1, 2, 3, 4, 5 };
            ArrayProductChallenge arrayProduct = new ArrayProductChallenge();
            //When
            int[] result = arrayProduct.Execute(array);
            //Then
            Assert.Equal(120, result[0]);
            Assert.Equal(60, result[1]);
            Assert.Equal(40, result[2]);
            Assert.Equal(30, result[3]);
            Assert.Equal(24, result[4]);
        }

        [Fact]
        public void GivenAnEmptyArrayWhenExecuteProductChallengeThenReturnNull()
        {
        //Given
        int[] array = new int[0];
        ArrayProductChallenge arrayProduct = new ArrayProductChallenge();

        //When
        int[] result = arrayProduct.Execute(array);

        //Then
        Assert.Null(result);
        }
    }
}