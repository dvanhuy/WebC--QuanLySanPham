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
    public partial class User_masterPage : System.Web.UI.MasterPage
    {
        QuanLySanPhamTHTKW.App_code.XuLyDuLieu xulydulieu;
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_code.XuLyDuLieu();
            SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", DBNull.Value) };
            Repeater1.DataSource = xulydulieu.getTable("psGetDanhMuc", pr);
            Repeater1.DataBind();

            //SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WEB DESIGN\Web apsx\QuanLySanPhamTHTKW\App_data\QuanLySanPham.mdf;Integrated Security=True";
            //cn.Open();
            //string SQL = "select * from [tbDanhMuc]";          
            //SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            //DataTable tbDANHMUC = new DataTable();
            //adp.Fill(tbDANHMUC);
            //Repeater1.DataSource = tbDANHMUC;
            //Repeater1.DataBind();
        }
    }
}