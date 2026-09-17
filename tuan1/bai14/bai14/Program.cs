using System;
namespace bai14;
class NhanVien
{
    public string hoTen { get; set; }
    public double luong { get; set; }
    public int soNgayVang { get; set; }
    public void nhapThongTinNV()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap muc luong co ban: ");
        luong = double.Parse(Console.ReadLine());
        Console.Write("Nhap so ngay vang: ");
        soNgayVang = int.Parse(Console.ReadLine());
    }
    public double tinhLuong()
    {
        double luongSauTinhToan = luong - (soNgayVang * 100000);
        return luongSauTinhToan;
    }
    public void xuatThongTinNV()
    {
        Console.WriteLine("Luong nhan vien sau khi tinh toan la: " + tinhLuong());
    }
}
class Program
{
    static void Main(string[] args)
    {
        NhanVien nv = new NhanVien();
        nv.nhapThongTinNV();
        nv.xuatThongTinNV();
        Console.ReadKey();
    }
}