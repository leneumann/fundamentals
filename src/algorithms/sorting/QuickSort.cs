namespace src.algorithms.sorting
{
    public static class QuickSort
    {
        public static int[] sorting(int[] arrayToBeSorted)
        {
            try
            {
                validateArray(arrayToBeSorted);
                sort(arrayToBeSorted, 0, arrayToBeSorted.Length - 1);
                return arrayToBeSorted;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        private static void validateArray(int[] arrayToBeValidated)
        {
            if(isAnValidArray(arrayToBeValidated))
            {
            return;
            }
            throw new System.Exception("Invalid Array");
        }
        private static bool isAnValidArray(int[] arrayToBeValidated) =>
             arrayToBeValidated != null && arrayToBeValidated.Length > 0 ? true : false;

        private static void sort(int[] arrayToBeSorted, int leftSide, int rightSide)
        {
            if (leftSide < rightSide)
            {
                int pivot = partition(arrayToBeSorted, leftSide, rightSide);
                if (pivot > 1)
                {
                    sort(arrayToBeSorted, leftSide, pivot - 1);
                }
                if (pivot + 1 < rightSide)
                {
                    sort(arrayToBeSorted, pivot + 1, rightSide);
                }
            }
        }

        private static int partition(int[] arrayToBeSorted, int leftSide, int rightSide)
        {
            int pivot = arrayToBeSorted[leftSide];
            while (true)
            {
                while (arrayToBeSorted[leftSide] < pivot)
                    leftSide++;

                while (arrayToBeSorted[rightSide] > pivot)
                    rightSide--;


                if (leftSide < rightSide)
                {
                    int tem;
                    tem = arrayToBeSorted[leftSide];
                    arrayToBeSorted[leftSide] = arrayToBeSorted[rightSide];
                    arrayToBeSorted[rightSide] = tem;
                }
                else
                {
                    return rightSide;
                }
            }
        }
    }
}