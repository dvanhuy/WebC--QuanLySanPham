using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySanPhamTHTKW.App_code
{
    public class Item
    {
        private String masanpham;
        private String tensanpham;
        private double dongia;
        private int soluong;
        private String hinhanh;

        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public double ThanhTien
        {
            get { return this.soluong * this.dongia; }
        }

        public Item(string masanpham, string tensanpham, string hinhanh , int soluong ,  double dongia )
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.dongia = dongia;
            this.soluong = soluong;
            this.hinhanh = hinhanh;
        }
        public Item()
        {
        }
    }
}