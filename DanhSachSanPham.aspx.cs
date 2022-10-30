using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySanPhamTHTKW
{
    public partial class DanhSachSanPham : System.Web.UI.Page
    {
        QuanLySanPhamTHTKW.App_code.XuLyDuLieu xulydulieu;
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_code.XuLyDuLieu();
            string madm = Request.QueryString.Get("MADANHMUC");
            SqlParameter[] pr;
            if (madm != null)
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", madm) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", DBNull.Value) };
            DataList1.DataSource = xulydulieu.getTable("psGetSanPham", pr);
            DataList1.DataBind();
            DataList1.RepeatColumns = 5;

            //SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WEB DESIGN\WEB APSX\QUANLYSANPHAMTHTKW\APP_DATA\QUANLYSANPHAM.MDF;Integrated Security=True";
            //cn.Open();
            //string SQL = "select * from [tbSanPham]";
            //string madanhmuc = Request.QueryString.Get("MADANHMUC");
            //if (madanhmuc != null)
            //{
            //    SQL = "select * from [tbSanPham] Where MAMUCCHA=" + madanhmuc;
            //}
            //SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            //DataTable tbSanPham = new DataTable();
            //adp.Fill(tbSanPham);
            //DataList1.DataSource = tbSanPham;
            //DataList1.DataBind();
            //DataList1.RepeatColumns = 5;
            //cn.Close();

        }
    }
}