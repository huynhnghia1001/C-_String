using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Gues_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thingking  of a number  between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            Random rd = new Random();
            int soCuaMay, soNguoiChoiDoan;
            Console.WriteLine("Nhap so: ");
            soCuaMay= rd.Next(20
                );
            soNguoiChoiDoan = int.Parse(Console.ReadLine());
            do
            {
                if (soCuaMay > soNguoiChoiDoan)
                {
                    Console.WriteLine("Nhap lon hon");
                    soNguoiChoiDoan = int.Parse(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine("Nhap nho hon");
                    soNguoiChoiDoan = int.Parse(Console.ReadLine());
                }
            } while (soCuaMay != soNguoiChoiDoan);
            Console.WriteLine("You win!");

            Console.ReadKey();  
        }
    }
}
