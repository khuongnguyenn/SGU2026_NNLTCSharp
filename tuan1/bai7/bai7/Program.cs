using System;
namespace bai7;

class Program
{
    static bool kiemTraSoNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap so n: ");
        int n = int.Parse(Console.ReadLine());
        bool snt = kiemTraSoNguyenTo(n);
        if (snt == true)
        {
            Console.WriteLine(n + " la so nguyen to");
        }
        else
        {
            Console.WriteLine(n + " khong phai la so nguyen to");
        }
        Console.ReadKey();
    }
}