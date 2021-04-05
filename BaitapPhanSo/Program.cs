using System;

namespace BaitapPhanSo
{
    class Program
    {
        
        static void Main(string[] args)
        {

            PhanSo ps1 = new PhanSo();   
            PhanSo ps2 = new PhanSo();
            Console.WriteLine("Nhap phan so thu 1:");
            ps1.NhapPhanSo();
            Console.WriteLine("Nhap phan so thu 2:");
            ps2.NhapPhanSo();


            Console.Write("Tong hai phan so:");
            ps1.CongPhanSo(ps2);
            Console.Write("Hieu hai phan so:");
            ps1.HieuPhanSo(ps2);
            Console.Write("Tich hai phan so:");
            ps1.NhanPhanSo(ps2);
            Console.Write("Thuong hai phan so:");
            ps1.ChiaPhanSo( ps2);

            Console.ReadLine();

        }


        

   




    }
}
