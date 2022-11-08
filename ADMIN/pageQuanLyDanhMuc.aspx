<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageQuanLyDanhMuc.aspx.cs" Inherits="QuanLySanPhamTHTKW.ADMIN.pageQuanLyDanhMuc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 402px;
            width: 483px;
        }
        .auto-style2 {
            height: 80px;
        }
        .auto-style3 {
            height: 79px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            height: 80px;
            width: 161px;
        }
        .auto-style6 {
            height: 79px;
            width: 161px;
        }
        .auto-style7 {
            height: 40px;
            width: 161px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <p>Mã danh mục</p>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMaDanhMuc" runat="server" Width="205px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <p>Tên danh mục</p>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtTenDanhMuc" runat="server" Width="203px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" ></td>
                <td class="auto-style4" >
                    <asp:Button ID="buttonsave" runat="server" Text="Lưu" OnClick="btn_Luu_Click"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grvDANHMUC" runat="server" Height="158px" Width="481px" AllowPaging="True" PageSize="3" OnPageIndexChanging="grvDANHMUC_PageIndexChanging">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
