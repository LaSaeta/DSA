using System;

namespace Data_Structures
{
    public static class Arrays
    {
        public static void GreatestLHS(int[] arr)
        {
            if (arr.Length == 0)
                return;

            int n = arr.Length;
            int greatestLHS = -1;

            for (int i = 0; i < n; i++)
            {
                int temp = arr[i];
                arr[i] = greatestLHS;
                greatestLHS = Math.Max(greatestLHS, temp);
            }
        }

        public static void GreatestRHSIncluding(int[] arr)
        {
            if (arr.Length == 0)
                return;
            int n = arr.Length;

            int greatestRHS = arr[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                greatestRHS = Math.Max(greatestRHS, arr[i]);
                arr[i] = greatestRHS;
            }
        }

        public static void GreatestRHS(int[] arr)
        {
            if (arr.Length == 0)
                return;

            int greatestRHS = -1;
            int lastElement = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                lastElement = arr[i];
                arr[i] = greatestRHS;
                greatestRHS = Math.Max(greatestRHS, lastElement);
            }
        }
        public static int[][] Transpose(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            int[][] result = new int[n][];

            for (int i = 0; i < n; i++)
            {
                result[i] = new int[m];
            }

            for (int i = 0; i < matrix.Length; i++)
            {

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }

            return result;
        }
        public static void Frequency(char[] arr)
        {
            if (arr.Length == 0)
                return;

            int[] freq = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] != '-' && arr[i] == arr[j])
                    {
                        freq[i] += 1;
                        arr[j] = '-';
                    }
                }
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (arr[i] != '-')
                {
                    Console.WriteLine(string.Format("{0} : {1}", arr[i], freq[i]));
                }
            }

        }

        public static void Frequency2(char[] arr)
        {
            if (arr.Length == 0)
                return;

            int[] freq = new int[256];

            for (int i = 0; i < arr.Length; i++)
            {
                freq[arr[i]]++;
            }

        }

        public static void Reverse(char[] arr)
        {
            if (arr.Length <= 1)
            {
                Console.WriteLine(arr);
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.Write(arr[i]);
                }
            }
        }

        public static void Reverse2(char[] arr)
        {
            if (arr.Length <= 1)
            {
                Console.WriteLine(arr);
            }
            else
            {
                int i = 0;
                int j = arr.Length - 1;

                while (i < j)
                {
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }

                Console.WriteLine(arr);
            }
        }

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
