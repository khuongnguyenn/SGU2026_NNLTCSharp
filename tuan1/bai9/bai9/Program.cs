using System;
namespace bai9;

class Program
{
    static void FindMaxMin(double a, double b, double c, out double max, out double min)
    {
        max = Math.Max(a, Math.Max(b, c));
        min = Math.Min(a, Math.Min(b, c));
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap so thuc a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap so thuc b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap so thuc c: ");
        double c = double.Parse(Console.ReadLine());
        double max, min;
        FindMaxMin(a, b, c, out max, out min);
        Console.WriteLine("Gia tri lon nhat la: " + max);
        Console.WriteLine("Gia tri nho nhat la: " + min);
        Console.ReadKey();
    }
}