using System;
using System.Text;
namespace bai12;
class Program
{
    static string DaoChuoi(string s)
    {
        // tao mot doi tuong StringBuilder de luu tru chuoi dao nguoc
        StringBuilder chuoiDao = new StringBuilder();
        // chay vong lap tu cuoi chuoi den dau chuoi va them tung ky tu vao chuoi dao nguoc
        for (int i = s.Length - 1; i >= 0; i--)
        {
            chuoiDao.Append(s[i]); // them ky tu vao chuoi dao nguoc
        }
        // tra ve chuoi dao nguoc
        return chuoiDao.ToString();
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        string chuoiDao = DaoChuoi(s);
        Console.WriteLine("Chuoi dao nguoc la: " + chuoiDao);
        Console.ReadKey();
    }
}