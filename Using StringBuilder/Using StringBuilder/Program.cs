﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Using_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int JumpCount = 10;
            string[] animals = { "goats", "cats", "pigs" };

            StringBuilder sb = new StringBuilder("Initial string.", 200);
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            sb.Append("The quick brown fox");
            sb.Append("Jumped over the lazy dog.");

            sb.AppendLine();

            sb.AppendFormat("He did this {0} times", JumpCount);
            sb.AppendLine();

            sb.Append("He also jumped over ");
            //sb.AppendJoin(',', animals);

            sb.Replace("fox", "cat");

            sb.Insert(0, "This is the ");

            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}