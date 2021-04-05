using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhanSo
{
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;


        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
            

        }
        public PhanSo()
        {

        }
        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }

        public void NhapPhanSo()
        {
            Console.WriteLine("Nhap tu so:");
            tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Nhap mau so:");
                mauSo = int.Parse(Console.ReadLine());
                if (mauSo == 0)
                {
                    Console.WriteLine("Moi nhap lai");
                }
            } while (mauSo == 0);


        }



        public PhanSo CongPhanSo(PhanSo ps2)
        {
            int tu = this.tuSo * ps2.mauSo + this.mauSo * ps2.tuSo;
            int mau = this.mauSo * ps2.mauSo;

            PhanSo tong = new PhanSo(tu, mau);
            tong.rutGon();
            return tong;


        }
        public PhanSo HieuPhanSo(PhanSo ps2)
        {
            int tu = this.tuSo * ps2.mauSo - this.mauSo * ps2.tuSo;
            int mau = this.mauSo * ps2.mauSo;
           
            PhanSo hieu = new PhanSo(tu, mau);
            hieu.rutGon();
            return hieu;
        }
        public PhanSo NhanPhanSo(PhanSo ps2)
        {
            int tu = this.tuSo * ps2.tuSo;
            int mau = this.mauSo * ps2.mauSo;


            PhanSo tich = new PhanSo(tu, mau);
            tich.rutGon();
            return tich;


        }
        public PhanSo ChiaPhanSo(PhanSo ps2)
        {
            int tu = this.tuSo * ps2.mauSo;
            int mau = this.mauSo * ps2.tuSo;
            
            PhanSo thuong = new PhanSo(tu, mau);
            thuong.rutGon();
            return thuong;
        }

        private int UCLN(int a, int b)
        {

            if (a != 0)
            {
                if (a > 0)
                {
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
                else
                {
                    a = -a;
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
            }
            else return 0;

        }

        public void rutGon()
        {
            int a = UCLN(this.tuSo, this.mauSo);

            if (a != 0)
            {
                if (a > 0)
                {
                    this.tuSo = this.tuSo / a;
                    this.mauSo = this.mauSo / a;
                }
                else
                {
                    this.tuSo = this.tuSo / (-a);
                    this.mauSo = this.mauSo / (a);
                }
            }

            Console.WriteLine(this.tuSo + "/" + this.mauSo);

        }
    }
}
