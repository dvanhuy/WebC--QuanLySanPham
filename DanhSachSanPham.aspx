<%@ Page Title="" Language="C#" MasterPageFile="~/User_masterPage.Master" AutoEventWireup="true" CodeBehind="DanhSachSanPham.aspx.cs" Inherits="QuanLySanPhamTHTKW.DanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="ChiTietSanPham.aspx?MSP=<%# Eval("MASANPHAM") %>">
                 <img alt="" src="image/<%# Eval("HINHANH") %>" width="200px" height="200px" style="border:1px solid black"/>
            </a>
            <br />
            <h4 style="margin: 10px;text-align: center">Tên SP : <%# Eval("TENSANPHAM") %></h4>
            <br />
            <h5 style="margin-top: -20px; text-align: center">Đơn giá <%# Eval("DONGIA") %></h5>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
