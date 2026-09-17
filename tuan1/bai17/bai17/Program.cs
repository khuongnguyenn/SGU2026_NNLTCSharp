using System;
using System.Collections.Generic; 
namespace bai17;
class Program
{
    static int[,] sinhMangNgauNhien(int n, int m)
    {
        int[,] A = new int[n, m];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                // lay so ngau nhien tu 10 den 100
                // rand.Next(a, b) se lay tu n den m-1, nen m phai la 101
                A[i, j] = rand.Next(10, 101);
            }
        }
        return A;
    }
    static void inMang(int[,] A)
    {
        int n = A.GetLength(0);
        int m = A.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + "\t"); // \t giup tao khoang cach
            }
            Console.WriteLine();
        }
    }
    static void layChanLe(int[,] A, out int[] mangChan, out int[] mangLe)
    {
        List<int> chan = new List<int>();
        List<int> le = new List<int>();
        foreach (int so in A)
        {
            if (so % 2 == 0)
            {
                chan.Add(so);
            }
            else
            {
                le.Add(so);
            }
        }
        mangChan = chan.ToArray();
        mangLe = le.ToArray();
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap so hang n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine());
        int[,] maTran = sinhMangNgauNhien(n, m);
        Console.WriteLine("\nMa tran ngau nhien vua tao la: ");
        inMang(maTran);
        layChanLe(maTran, out int[] chan, out int[] le);
        Console.WriteLine("\nMang cac so chan: " + string.Join(", ", chan));
        Console.WriteLine("Mang cac so le: " + string.Join(", ", le));
        Console.ReadKey();
    }
}