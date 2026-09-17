using System;
namespace bai13;

class SinhVien
{
    public string maSV { get; set; }
    public string hoTen { get; set; }
    public string diaChi { get; set; }
    public int namHoc { get; set; }
    public void NhapThongTinSV()
    {
        Console.Write("Nhap ma sinh vien: ");
        maSV = Console.ReadLine();
        Console.Write("Nhap ho ten sinh vien: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap dia chi sinh vien: ");
        diaChi = Console.ReadLine();
        Console.Write("Nhap nam hoc sinh vien: ");
        namHoc = int.Parse(Console.ReadLine());
    }
    public void XuatThongTinSV()
    {
        Console.WriteLine("\nMa sinh vien: " + maSV);
        Console.WriteLine("Ho ten sinh vien: " + hoTen);
        Console.WriteLine("Dia chi sinh vien: " + diaChi);
        Console.WriteLine("Nam hoc sinh vien: " + namHoc);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SinhVien sv = new SinhVien();
        sv.NhapThongTinSV();
        sv.XuatThongTinSV();
        Console.ReadKey();
    }
}