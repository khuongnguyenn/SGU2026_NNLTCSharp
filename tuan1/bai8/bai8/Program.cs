using System;
namespace bai8;
class Program
{
    static void HoanVi( ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap so thuc a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap so thuc b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Trang thai ban dau: a = " + a + ", b = " + b);
        HoanVi(ref a, ref b);
        Console.WriteLine("Trang thai sau khi hoan vi: a = " + a + ", b = " + b);
        Console.ReadKey();
    }
}
