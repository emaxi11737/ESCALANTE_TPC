<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/login.Master" CodeBehind="loginInicio.aspx.cs" Inherits="ESCALANTE_WEB.loginInicio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
   <div class="login">
    <asp:TextBox ID="TextBox1" runat="server" placeholder="User" ></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Contrasena" TextMode="Password"></asp:TextBox>
    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Ingresar" OnClick="Button1_Click" />
 
</div>

</asp:Content>