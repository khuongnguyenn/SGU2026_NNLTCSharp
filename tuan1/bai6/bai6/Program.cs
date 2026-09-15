using System;
namespace bai6;
class Program
{
    static int timMax(int a, int b, int c)
    {
        int max = a;
        if (b > max)
        {
            max = b;
        }
        if ( c > max)
        {
            max = c;
        }
        return max;
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu ba: ");
        int c = int.Parse(Console.ReadLine());
        int max = timMax(a, b, c);
        Console.WriteLine("So lon nhat la: " + max);
        Console.ReadKey();
    }
}