using System;
using System.Collections;
namespace bai16;

class Program
{
    static void Main(string[] args)
    {
        ArrayList danhSach = new ArrayList();
        Console.Write("Nhap so luong nguoi: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ho ten nguoi thu " + (i + 1) + ":" );
            string hoTen = Console.ReadLine();
            danhSach.Add(hoTen);
        }
        danhSach.Sort();
        Console.WriteLine("\nDanh sach sau khi sap xep: ");
        foreach (string item in danhSach)
        {
            Console.WriteLine("- " + item);
        }
        Console.ReadKey();
    }
}