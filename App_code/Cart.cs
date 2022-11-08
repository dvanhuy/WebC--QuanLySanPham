using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySanPhamTHTKW.App_code
{
    public class Cart
    {
        Dictionary<string,Item> listcarts;
        public Dictionary<string, Item> LISTCARTS
        {
            get { return this.listcarts; }
        }
        public Cart()
        {
            listcarts = new Dictionary<string, Item>();
        }
        public void AddCart(String masanpham,string tensanpham,string hinhanh,int soluong,double dongia)
        {
            Item item = new Item(masanpham, tensanpham, hinhanh, soluong, dongia);
            if (listcarts.ContainsKey(item.Masanpham))
                listcarts[item.Masanpham].Soluong += item.Soluong;
            else
                listcarts.Add(item.Masanpham, item);
        }

        public void RemoveCart(string masanpham)
        {
            listcarts.Remove(masanpham);
        }


        public double TotalBill()
        {
            double total=0;
            foreach (Item item in listcarts.Values)
                total += item.ThanhTien;
            return total;
        }
    }

}