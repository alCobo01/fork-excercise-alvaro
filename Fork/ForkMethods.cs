namespace Fork
{
    public class ForkMethods
    {
        public static bool ValidateInRange(int num, int min, int max)
        {
            return (num >= min && num <= max);
        }

        public static int CalculateProduct(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}
