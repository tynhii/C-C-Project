using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {   static void XuLyChuoi1()
        {
            Console.Write("Nhap vao mot chuoi s1: ");
            string s1 = Console.ReadLine();
            Console.Write("Nhap vao mot chuoi s2: ");
            string s2 = Console.ReadLine();
            s1 = s1.Replace("internet", s2);
            Console.WriteLine("Chuoi s1 sau khi thay the: " +s1);
            Console.Write("Nhap chuoi s3: ");
            string s3 = Console.ReadLine();
            int i;
            i = s3.CompareTo(s2);
            if (i == 0)
            {
                Console.WriteLine("hai chuoi bang nhau");
            }
            else if (i == 1)
            {
                Console.WriteLine("s3 < s2");
            }
            else if (i == -1)
            {
                Console.WriteLine("s3 < s2");
            }
        }
        static void XuLyChuoi2()
        {
            Console.WriteLine("Nhap vao mot chuoi: ");
            string str = Console.ReadLine();
                       //Tra ve mang gom {"mot", "hai", "ba"}
            string[] str2 = str.Split(';');
            Console.WriteLine("\nKet qua:");
            Console.WriteLine("Ma={0}",str2[0]);
            Console.WriteLine("Ma={0}", str2[1]);
            Console.WriteLine("Ma={0}", str2[2]);
        }
        static void Main(string[] args)
        {
            //XuLyChuoi1();
            XuLyChuoi2();
            Console.ReadLine();
        }
    }
}
