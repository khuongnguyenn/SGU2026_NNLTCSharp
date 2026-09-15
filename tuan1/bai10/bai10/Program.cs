using System;
namespace bai10;
class Program
{
    static bool KiemTraDoiXung(string s)
    {
        int doDai = s.Length;
        for(int i = 0; i < doDai / 2; i++)
        {
            if (s[i] != s[doDai - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();
        if (KiemTraDoiXung(chuoi) == true)
        {
            Console.WriteLine("Chuoi doi xung");
        }
        else
        {
            Console.WriteLine("Chuoi khong doi xung");
        }
        Console.ReadKey();
    }
}
