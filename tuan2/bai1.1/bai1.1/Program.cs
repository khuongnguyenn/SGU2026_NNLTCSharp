using System;
namespace bai1_1;
class SinhVien
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
    }
    public int TinhTuoi()
    {
        int NamHienTai = DateTime.Now.Year;
        int Tuoi = NamHienTai - NamSinh;
        return Tuoi;
    }
    public void XuatThongTin()
    {
        Console.WriteLine("Tuoi sinh vien la: " + TinhTuoi());
    }
}
class Program
{
    static void Main(string[] args)
    {
        SinhVien sv = new SinhVien();
        sv.NhapThongTin();
        sv.XuatThongTin();
        Console.ReadKey();
    }
}