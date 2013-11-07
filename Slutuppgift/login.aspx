<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Slutuppgift.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p>
            <asp:TextBox ID="name" runat="server" placeholder="Namn"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="password" type=password runat="server" placeholder="Lösenord"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="submit" runat="server" Text="Skicka uppgifter" OnClick="submit_Click" />
            <asp:Label ID="error" runat="server" Text="" style="color: #FF0000"></asp:Label>
        </p>
</asp:Content>
