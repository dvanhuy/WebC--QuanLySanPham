using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySanPhamTHTKW
{
    public partial class GioHang : System.Web.UI.Page
    {
        public void LoadCard()
        {
            App_code.Cart cart = (App_code.Cart)Session["CART"];
            this.grvCART.DataSource = cart.LISTCARTS.Values.ToList();
            this.grvCART.DataBind();
            this.grvCART.FooterRow.Cells[0].Text = "Tổng tiền :";
            this.grvCART.FooterRow.Cells[4].Text = cart.TotalBill().ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCard();
            }
        }

        protected void btn_DELETE_Click(object sender, EventArgs e)
        {
            App_code.Cart cart = (App_code.Cart)Session["CART"];
            foreach(GridViewRow row in grvCART.Rows)
            {
                CheckBox check = (CheckBox)row.FindControl("ckbREMOVEITEM");
                if (check.Checked)
                {
                    String masanpham = row.Cells[0].Text;
                    cart.RemoveCart(masanpham);
                }
                Session["CART"] = cart;
                LoadCard();
            }
        }

    }
}