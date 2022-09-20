﻿using System;

namespace ExchangingData
{
    internal class Program
    {
        static int val;
        static void ShowDouble()
        {
            val *= 2;
            Console.WriteLine($"val doubled = {val}");
        }
        static void Main(string[] args)
        {
            val = 5;
            Console.WriteLine($"val = {val}");
            ShowDouble();
            Console.WriteLine($"val = {val}");
            Console.ReadLine();

            CustomerName myCustomer;
            myCustomer.firstName = "Aleksandra";
            myCustomer.lastName = "Trajkovski"
            Console.WriteLine($"myCustomer.firstName {myCustomer.lastName}");
            Console.WriteLine($"{myCustomer.FullName}");
            Console.WriteLine($"{myCustomer.FullName}"});
        }
        struct CustomerName
        {
            public string firstName, lastName;
            public string fullName => $"{firstName} {lastName}";
            public string FullName => $"{firstName} {lastName}";
    }
  }
   
}

