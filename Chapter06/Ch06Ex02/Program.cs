using System;

namespace Ch06Ex02
{
    internal class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxValue = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxValue)
                {
                    maxValue = intArray[i];
                }
            }
            return maxValue;
        }
     
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxValue = MaxValue(myArray);
            Console.WriteLine($"The maximum value in vs is {maxValue}");
        }
    }
}
