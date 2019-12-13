<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmhome.aspx.cs" Inherits="mylibrary.frmhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
&nbsp;<asp:DataList ID="DataList1" runat="server" CellPadding="3" Height="100px" RepeatColumns="2" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal">
        <AlternatingItemStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
       <ItemTemplate>
           <h2><%#Eval("heading") %></h2>
           <%#Eval("detail") %>
           <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("picture") %>' Height="100px" Width="200px" /><br />   
       </ItemTemplate> 
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
</asp:DataList>
&nbsp;
</asp:Content>
