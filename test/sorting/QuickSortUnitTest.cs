using src.algorithms.sorting;
using Xunit;

namespace test.sorting
{

    public class QuickSortUnitTest
    {
        [Fact]
        public void WhenSortingAnArrayShouldBeRearrangeTheArray()
        {
            int[] array = new int[10] { 10, 45, 14, 11, 22, 34, 98, 25, 9, 8 };
            int[] expectedArray = new int[10] { 8, 9, 10, 11, 14, 22, 25, 34, 45, 98 };
            QuickSort.sorting(array);

            Assert.Equal(expectedArray[0], array[0]);
            Assert.Equal(expectedArray[9], array[9]);
        }

        [Theory]
        [InlineData(null)]
        public void WhenTrySortingInvalidArrayShouldReturnException(int[] array)
        {
            Assert.Throws<System.Exception>(() => QuickSort.sorting(array));
        }
    }
}