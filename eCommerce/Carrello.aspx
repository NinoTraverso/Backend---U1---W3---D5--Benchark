<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="eCommerce.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />

<h1>CARRELLO</h1>

    <asp:Label ID="NameOfPotion" runat="server" Text=""></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Delete_Click"/>

</asp:Content>
