using System;

namespace Chapter04Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less than 10? {isLessThan10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly oneof the aboveis true? " +
                              $"{isLessThan10 ^ isBetween0And5}");

            string myString = "The number is less than 10" ; "greater than 10";
            string myString = myInt < 10 ? "The number is less than 10" : "greater than 10";
        }
    }
}
