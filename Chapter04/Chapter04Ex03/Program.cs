using System;

namespace Chapter04Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "aleksandra";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case "aleksandra":
                    Console.WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    Console.WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;
            }
            Console.WriteLine($"Hello {name}!");
            }
        }
    }

