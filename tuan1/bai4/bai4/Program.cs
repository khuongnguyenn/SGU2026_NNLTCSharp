using System;
namespace bai4;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        Console.Write("Nhap so nguyen x: ");
        while (! int.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("X khong hop le. Vui long nhap lai: ");
        }
        Console.Write("Nhap so nguyen y: ");
        while (! int.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Y khong hop le. Vui long nhap lai: "); 
        }
        double z = Math.Pow(x, y);
        Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + z);
        Console.ReadKey();
    }
}