using System;
namespace bai12;
class Program
{
    static int DemSoTu(string s)
    {
        string[] tu = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return tu.Length;
    }
    static void Main(string[] args)
    { 
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        Console.WriteLine("Chuyen thanh chu hoa: " + s.ToUpper());
        Console.WriteLine("Chuyen thanh chu thuong: " + s.ToLower());
        Console.WriteLine("Dem so tu trong chuoi: " + DemSoTu(s));
        Console.ReadKey();
    }
}