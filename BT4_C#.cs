using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void CacHam()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Can bac 2 cua {0}= {1}", a, Math.Sqrt(a));
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} mu {1}= {2}", a,b,Math.Pow(a, b));
            double c = 5.1254555; 
            Console.WriteLine("So c ban dau= {0}", c);
            Console.Write("Nhap so don vi can lam tron: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("So c sau khi lam tron {0} don vi la {1}",d,Math.Round(c, d));
            //Vi du ve Ham Luong Giac
            Console.Write("Nhap 1 goc: ");
            int goc=int.Parse(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine("Sin{0}= {1}", goc,Math.Sin(radian));
            Console.WriteLine("Cos{0}= {1}", goc, Math.Round(Math.Cos(radian),2));
            Console.WriteLine("Tan{0}= {1}", goc, Math.Round(Math.Tan(radian),2));
            Console.WriteLine("Cot{0}= {1}", goc, Math.Round(1/Math.Tan(radian),2));
        }
        static void TaoRandom()
        {
            Random nn = new Random();
            int so = nn.Next(50);
            Console.WriteLine("So nhgau nhien: {0}", so);        
            int so1 = nn.Next(80, 100);
            Console.WriteLine("So nhgau nhien: {0}", so1);
            double so2 = nn.NextDouble();
            Console.WriteLine("So nhgau nhien: {0}", so2);
        }
        static void NgayThang()
        {
            DateTime dt = new DateTime(2000, 06, 30);
            Console.WriteLine("Sinh nhat cua Tuy Nhi la: {0}",dt.ToString("dd/M/yy"));
            Console.WriteLine("Sinh nhat cua Tuy Nhi la: {0}", dt.ToString("M/dd/yyyy"));

            Console.Write("Nhap ngay thang nam sinh:");
            string s = Console.ReadLine();
            DateTime DOB = DateTime.Parse(s);
            Console.WriteLine("Ngay sinh: {0}", DOB.Day);
            Console.WriteLine("Thang sinh: {0}", DOB.Month);
            Console.WriteLine("Nam sinh: {0}", DOB.Year);


        }
        static void Main(string[] args)
        {
            //CacHam();
            //TaoRandom();
            NgayThang();
            Console.ReadLine();
        }
    }
}
