<%@ Page Title="" Language="C#" MasterPageFile="~/User_masterPage.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="QuanLySanPhamTHTKW.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <h2>Đây là trang mô tả sản phẩm</h2>
            <img alt="" src="image/<%# Eval("HINHANH") %>" width="200px" height="200px" style="border:1px solid black"/>
            <h3>Tên Sản phẩm :<%# Eval("TENSANPHAM") %> </h3>
            <p><%# Eval("MOTA") %></p>
        </ItemTemplate>
    </asp:Repeater>
    <asp:DropDownList ID="DrlSOLUONG" runat="server"></asp:DropDownList>
    <asp:Button ID="btn_GIOHANG" runat="server" Text="Giỏ hàng" />
</asp:Content>
