using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 5, 5, 5, 5, 5, 5, 5 };
            int maxElement = Array.MaxElement(input);
            int minElement = Array.MinElement(input);
            int[] minAndMaxElement = Array.MinAndMax(input);
            Console.WriteLine(minElement);
        }
    }
}
