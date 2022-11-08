using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLySanPhamTHTKW.App_code
{
    public class XuLyDuLieu
    {
        SqlConnection con;
        public XuLyDuLieu()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WEB DESIGN\Web apsx\QuanLySanPhamTHTKW\App_data\QuanLySanPham.mdf;Integrated Security=True";
        }


        private void MoKetNoi()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable getTable(String sql)
        {
            MoKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            DongKetNoi();
            return tb;
        }

        public DataTable getTable(String nameprocedure, SqlParameter[] pr)
        {
            MoKetNoi();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedure;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(tb);
            DongKetNoi();
            return tb;
        }

        public void getDataSet(ref DataSet ds,string sql)
        {
            ds.Tables.Add(this.getTable(sql));
        }
        
        public void getDataSet(ref DataSet ds,string nameprocedure,SqlParameter[] pr)
        {
            ds.Tables.Add(this.getTable(nameprocedure, pr));
        }

        /// <summary>
        ///  Thực thi lệnh SQL
        /// </summary>
        /// <param name="sql">SQL(insert,update,delete)</param>
        /// <returns>K(<>0 , =0)</returns>
        public int Execute(string sql)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, this.con);
            this.DongKetNoi();
            int k = (int)cmd.ExecuteNonQuery();
            return k;
        }
        public int Execute(string nameprocedure, SqlParameter[] pr)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedure;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            int k = (int)cmd.ExecuteNonQuery();
            DongKetNoi();
            return k;
        }

    }
}