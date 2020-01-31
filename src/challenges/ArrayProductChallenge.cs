namespace src.challenges
{
    public class ArrayProductChallenge
    {
        public int[] Execute(int[] array)
        {
            if(array.Length==0)
             return null;
            int[] new_array = new int[array.Length];
            int product = 1;
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                while (j < array.Length)
                {
                    if (i != j)
                        product *= array[j];
                    j++;
                }
                new_array[i] = product;
                j = 0;
                product = 1;
            }
            return new_array;
        }
    }
}