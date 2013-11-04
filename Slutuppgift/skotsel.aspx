<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="skotsel.aspx.cs" Inherits="Slutuppgift.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h2>Älgrapportering</h2>
        <p>            
            <asp:TextBox ID="jaktlag" placeholder="Jaktlagsnamn" runat="server"></asp:TextBox>
        </p>
        <p>            
           <asp:TextBox ID="shootername" runat="server" placeholder="Namn på skytt" Style="text-align: left"></asp:TextBox>
        </p>
        <p>                        
            <asp:TextBox ID="date" runat="server" placeholder="Datum"></asp:TextBox>
        </p>
        <p>            
            <asp:TextBox ID="kön" runat="server" placeholder="Kön"></asp:TextBox>
        </p>
        <p>          
            <asp:TextBox ID="vikt" runat="server" placeholder="Vikt (kilo)"></asp:TextBox>
        </p>
        <p>            
            <asp:TextBox ID="taggar" runat="server" placeholder="Antal taggar"></asp:TextBox>
        </p>
        <p>            
            <asp:TextBox ID="ålder" runat="server" placeholder="Ålder" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="comfirm" runat="server" Text="Skicka uppgifter" OnClick="comfirm_Click"/>
        </p>
</asp:Content>
