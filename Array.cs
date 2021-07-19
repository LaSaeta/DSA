namespace Data_Structures
{
    public static class Array
    {
        public static int MaxElement(int[] arr)
        {
            int max = int.MinValue;
            if (arr.Length > 0)
            {
                foreach (int num in arr)
                {
                    if (num >= max)
                    {
                        max = num;
                    }
                }

                return max;
            }
            else
            {
                return max;
            }
        }

        public static int MinElement(int[] arr)
        {
            int min = int.MaxValue;
            if (arr.Length > 0)
            {
                foreach (int num in arr)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            }
            else
            {
                return min;
            }
        }

        public static int[] MinAndMax(int[] arr)
        {
            int[] result = new int[2];
            result[0] = int.MaxValue;
            result[1] = int.MinValue;

            if (arr.Length == 0)
                return result;

            foreach (int num in arr)
            {
                if (num < result[0])
                {
                    result[0] = num;
                }
                if (num > result[1])
                {
                    result[1] = num;
                }
            }

            return result;
        }
    }
}
