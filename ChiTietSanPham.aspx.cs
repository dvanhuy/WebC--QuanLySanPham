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
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_code.XuLyDuLieu();
            string masanpham = Request.QueryString.Get("MSP");
            SqlParameter[] pr;
            if (masanpham != null)
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", masanpham) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", DBNull.Value) };

            DataTable tbSanPham = xulydulieu.getTable("psGetChiTietSanPham", pr);
            Repeater2.DataSource = tbSanPham;
            Repeater2.DataBind();

            int soluong = Convert.ToInt32(tbSanPham.Rows[0]["SOLUONG"].ToString());
            for (int i = 0; i <= soluong; i++)
            {
                this.DrlSOLUONG.Items.Add(i.ToString());
            }
        }
    }
}