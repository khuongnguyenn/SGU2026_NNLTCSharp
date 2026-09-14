using System;
namespace bai3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen y: ");
        int y = int.Parse(Console.ReadLine());
        double z = Math.Pow(x, y);
        Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + z);
        Console.ReadKey();
    }
}
