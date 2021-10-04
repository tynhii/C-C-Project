using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void DoanSo()
        {
            int Socuamay;
            int Socuaban;
            int Solandoan = 0;
            Console.Write("May tao ra 1 so NN trong khoang (0-500). Moi ban doan!");
            Random rd = new Random();
            Socuamay = rd.Next(501);
            while (true)
            {
                Socuaban = int.Parse(Console.ReadLine());
                Solandoan++;
                Console.WriteLine("Ban doan lan thu {0}", Solandoan);
                if (Socuamay == Socuaban)
                {
                    Console.WriteLine("Ban da doan dung.Chuc mung!");
                    break;
                }
                if (Socuaban < Socuamay)
                {
                    Console.WriteLine("So cua ban< so cua may");               
                }
                else
                {
                    Console.WriteLine("So cua ban > so cua may");               
                }
                if (Solandoan==7)
                {
                    Console.WriteLine("GameOver.Ban da doan sai");
                    break;
                }
            }

        }
        static void Main(string[] args)
        {
            while (true)
            {
                DoanSo();
                Console.WriteLine("Ban co tiep tuc khong (c/k)");
                string tt = Console.ReadLine();
                if (tt == "k")
                    break;
                Console.ReadLine();
            }
        }
    }
}
