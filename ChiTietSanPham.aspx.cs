using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySanPhamTHTKW
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {

        QuanLySanPhamTHTKW.App_code.XuLyDuLieu xulydulieu;
        DataTable tbSanPham;
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_code.XuLyDuLieu();
            string masanpham = Request.QueryString.Get("MSP");
            SqlParameter[] pr;
            if (masanpham != null)
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", masanpham) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", DBNull.Value) };

            tbSanPham = xulydulieu.getTable("psGetChiTietSanPham", pr);
            Repeater2.DataSource = tbSanPham;
            Repeater2.DataBind();

            int soluong = Convert.ToInt32(tbSanPham.Rows[0]["SOLUONG"].ToString());
            for (int i = 0; i <= soluong; i++)
            {
                this.DrlSOLUONG.Items.Add(i.ToString());
            }
        }

        protected void btnGiohang_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            App_code.Cart cart = new App_code.Cart();
            if (tbSanPham != null)
            {
                String masanpham = tbSanPham.Rows[0]["MASANPHAM"].ToString();
                String tensanpham = tbSanPham.Rows[0]["TENSANPHAM"].ToString();
                double dongia = Double.Parse(tbSanPham.Rows[0]["DONGIA"].ToString());
                String hinhanh = tbSanPham.Rows[0]["HINHANH"].ToString();
                int soluong = Int16.Parse(DrlSOLUONG.SelectedItem.Text);
                if (Session["CART"] != null)
                    cart = (App_code.Cart)Session["CART"];
                cart.AddCart(masanpham, tensanpham, hinhanh, soluong, dongia);
                Session["CART"] = cart;
                Response.Redirect("GioHang.aspx");
            }
        }
    }
}