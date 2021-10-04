using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Input(int[] A, int n)
        {
            // tạo mảng ngẫu nhiên 
            Random rd = new Random();
            for (int i = 0; i < A.Length; i++)
                A[i] = rd.Next(100) - 50;
        }
        static void Output(int[] A, int n)
        {
            // xuất mảng
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + "\t");
        }
        static void Xuatchanle()
        {
            Console.Write("\nCac phan tu chan la: \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nCac phan tu le la:\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Input(A, n);
            Output(A, n);
            Console.ReadLine();
        }
    }
}
