<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="skotsel.aspx.cs" Inherits="Slutuppgift.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h2>Rapportering</h2>
        <p/>    
            Här kan du rapportera skutna älgar <p/>
            <asp:ListBox ID="lbjaktlag" runat="server" Width="128px"></asp:ListBox>
        </p>
        <p>            
           <asp:TextBox ID="skytt" runat="server" placeholder="Namn på skytt" Style="text-align: left"></asp:TextBox>
        </p>
        <p>                        
            <asp:TextBox ID="datum" runat="server" placeholder="Datum"></asp:TextBox>
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
