﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs ${4}",
                                year, make, model, miles, price);
            Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and costs {price:C2}");

            Console.WriteLine($"This car is a {year} {make} {model}, with {{{miles * 1.6}}} km and costs {price:C2}");

            Console.ReadKey();
        }
    }
}
