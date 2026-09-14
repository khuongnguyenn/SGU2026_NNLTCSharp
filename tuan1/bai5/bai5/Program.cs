using System;
namespace bai5;
class Program
{
    static void Main(string[] args)
    {
        //khai bao bien
        double x = 0, y = 0;
        bool flag = false;
        int choose = 0;
        do
        {
            //menu dieu khien
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac hai cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            //nhap lua chon
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 4)
            {
                Console.WriteLine("Chi nhap tu 1 den 4. Vui long nhap lai: ");
            }
            // xu ly lua chon
            switch (choose)
            {
                // nhap gia tri x, y
                case 1:
                    Console.Write("Nhap gia tri x: ");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Gia tri x khong hop le. Vui long nhap lai: ");
                    }
                    Console.Write("Nhap gia tri y: ");
                    while (!double.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine("Gia tri y khong hop le. Vui long nhap lai: ");
                    }
                    flag = true;
                    Console.WriteLine("Da nhap hai gia tri x va y.");
                    break;
                // tinh x^y
                case 2:
                    if (! flag)
                    {
                        Console.WriteLine("Chua nhap gia tri x va y. Vui long chon chuc nang 1 de nhap gia tri.");
                    }
                    else
                    {
                        Console.WriteLine("Gia tri x^y la: " + Math.Pow(x, y));
                    }
                    break;
                // tinh can bac hai cua x va y
                case 3:
                    if (! flag)
                    {
                        Console.WriteLine("Chua nhap gia tri cua x va y. Vui long chon chuc nang 1 de nhap gia tri.");
                    }
                    else
                    {
                        if (x < 0 || y < 0)
                        {
                            Console.WriteLine("Khong the tinh can bac hai cua so am.");
                        }
                        else
                        {
                            Console.WriteLine("Can bac hai cua x la: " + Math.Sqrt(x));
                            Console.WriteLine("Can bac hai cua y la: " + Math.Sqrt(y));
                        }
                    }
                    break;
                // thoat chuong trinh
                case 4:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
            }
        }
        while (choose != 4);
        Console.ReadKey();
    }
}