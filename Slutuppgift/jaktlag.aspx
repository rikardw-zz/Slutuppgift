<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jaktlag.aspx.cs" Inherits="Slutuppgift.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Uppgifter för jaktledare</h2>
    <asp:DropDownList runat="server" ID="jaktlagInfo" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="jaktlagInfo_SelectedIndexChanged">                        
        
    </asp:DropDownList>   
    <br />

    <asp:Label ID="kontaktuppgift" runat="server" Text="Kontaktuppgifter Jaktledare:"></asp:Label>
    <br />
    <asp:Label ID="jaktledarnamn" runat="server" Text="Namn:"></asp:Label>
    <asp:Label ID="getjaktledarnamn" runat="server" Text="-"></asp:Label>
    <br />
    <asp:Label ID="telefon" runat="server" Text="Telefon:"></asp:Label>    
    <asp:Label ID="gettelefon" runat="server" Text="-"></asp:Label>
    <br />
    <asp:Label ID="epost" runat="server" Text="E-post:"></asp:Label>
    <asp:Label ID="getepost" runat="server" Text="-"></asp:Label>
    <br />
</asp:Content>
