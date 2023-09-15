<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="eCommerce.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <h1>LE NOSTRE POZIONI:</h1>

    <asp:Repeater ID="PotionRepeater" runat="server">
    <ItemTemplate>
        <div class="container">
          <div class="row">
            <div class="col col-xl-2 col-md-2 mb-4 ">
                <div class="card"> 
                   <img src='<%# Eval("ImageName") %>' class="w-100"/><br />
                      <div class="card-body">
                       Name: <%# Eval("Name") %><br />
                       Category: <%# Eval("PotionType") %><br />
                       Price: <%# Eval("Price") %> <br />
                          <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button1_Click" CommandArgument='<%# Eval("Description") %>'>Dettagli</asp:LinkButton> <br />
                          
                          <asp:LinkButton ID="LinkButton2" runat="server" OnClick="Button2_Click" CommandArgument='<%# Eval("Name") %>'>Aggiungi</asp:LinkButton>
                      </div>
                </div>
            </div>
         </div>
       </div>
        
    </ItemTemplate>
</asp:Repeater>



</asp:Content>
