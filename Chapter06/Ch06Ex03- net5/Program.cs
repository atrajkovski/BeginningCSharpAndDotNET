using System;

namespace Ch06Ex03__net5
{
    internal class Program
    {
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] vals = new int[] { 1, 5, 2, 9, 8 };
            int sum1 = SumVals(vals);
            int sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine($"Summed Values = {sum}");
            Console.ReadKey();

            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 8, 2 };
            Console.WriteLine($"The maximum value in myArray is {MaxValue(myArray, out int maxIndex)}");
            Console.WriteLine($"The first occurence of this value is at element {maxIndex + 1}");
        }

        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }
    }
    }

