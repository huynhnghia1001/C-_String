using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "this is a string";
            string str3 = "THIS is a STRING";
            string[] strs = { "one", "two", "three", "four" };

            Console.WriteLine(str1.Length);
            Console.WriteLine(str1[14]);
            foreach(char ch in str1)
            {
                Console.WriteLine(ch);
                if (ch == 'b')
                {
                    Console.WriteLine();
                    break;
                }
                
            }
            outstr = String.Concat(strs);
            Console.WriteLine(outstr);

            outstr = String.Join(".",strs);
            Console.WriteLine(outstr);

            outstr = String.Join("---", strs);
            Console.WriteLine(outstr);

            int result = String.Compare(str2, "athis is a string");
            Console.WriteLine(result);

            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            Console.WriteLine(str1.IndexOf('e'));
            Console.WriteLine(str1.IndexOf("fox"));

            Console.WriteLine(str1.LastIndexOf('e'));
            Console.WriteLine(str1.LastIndexOf("the"));

            outstr = str1.Replace("fox", "cat");
            Console.WriteLine(outstr);
            Console.WriteLine(outstr.IndexOf("fox"));

            Console.ReadKey();
        }
    }
}
