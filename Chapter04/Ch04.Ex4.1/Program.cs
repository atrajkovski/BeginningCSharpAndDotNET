using System;

namespace Ch04.Ex4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 5, var2 = 30;
            Console.WriteLine("What Boolean test can you perform to determine whether one or the other (but not both) is greater than 10?");
            bool isGreaterThen10Var1 = var1 > 10;
            bool isGreaterThen10Var2 = 10 < var2;
            Console.WriteLine(isGreaterThen10Var1 ^ isGreaterThen10Var2);

        }
    }
}
