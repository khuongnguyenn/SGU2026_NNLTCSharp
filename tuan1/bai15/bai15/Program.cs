using System;
using System.Linq;
namespace bai15;
class Program
{
    static bool kiemTraNguyenTo(int n)
    {
        if (n < 2) 
        { 
            return false; 
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) 
            { 
                return false; 
            }
        }
        return true;
    }
    static int[] layMangSoNguyenTo(int[] mangGoc)
    { 
        return mangGoc.Where(kiemTraNguyenTo).ToArray();
    }
    static void Main(string[] args)
    {
        
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu: ");
            mang[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nCac phan tu trong mang la: " + string.Join(", ", mang));
        Console.WriteLine("Phan tu lon nhat trong mang la: " + mang.Max());
        Console.WriteLine("Phan tu nho nhat trong mang la: " + mang.Min());
        int[] mangNT = layMangSoNguyenTo(mang);

        if (mangNT.Length > 0)
        {
            Console.WriteLine("Cac so nguyen to trong mang la: " + string.Join(", ", mangNT));
        }
        else
        {
            Console.WriteLine("Mang khong co so nguyen to nao.");
        }
        Console.ReadKey();
    }
}