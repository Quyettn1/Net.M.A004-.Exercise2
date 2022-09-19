using System;

namespace Net.M.A004_.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int b;
            Console.WriteLine("Luoc do Hoocne giai da thuc f(x) = a.x^n +a1.x^(n-1) + ... + an) / x -a");

            do Console.Write("Nhap so mu cao nhat cua f(x) la n= ");
            while (!int.TryParse(Console.ReadLine(), out n));
            int[] a = new int[n+1];
            for (int i = n; i >= 0; i--)  // Nhap f(x)
            {
                do Console.Write("Nhap thua so a cua x^{0} : ", i);
                while (!int.TryParse(Console.ReadLine(), out a[n - i]));
            }

            do Console.Write("Nhap thua so a cho bieu thuc g(x)= x-a: a= ");  // Nhap g(x)
            while (!int.TryParse(Console.ReadLine(), out b));

            int[] result = new int[n];
            result[0] = a[0];
            // Tinh toan:
            for (int i = 1; i < n; i++)  
            {
                result[i] = b * result[i - 1] + a[i];
            }

            // Hien thi ket qua:
            Console.WriteLine("Ket qua cua phep chia f(x) / g(x) la:  ");
            for (int i = 0; i < n -1; i++)
            {
                Console.Write("{0}*x^{1} + ",result[i],n-i-1);
            };
            Console.Write("{0} ", result[n-1]);
        }
    }
}
