<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jaktlag.aspx.cs" Inherits="Slutuppgift.WebForm2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Jaktlag</h2>
    <p>Här kan du se uppgifter från jaktlagen</p>
    <asp:DropDownList runat="server" ID="jaktlagInfo" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="jaktlagInfo_SelectedIndexChanged" />                                    
    <br />
    <br />
    <h3>Kontaktuppgifter Jaktledare:</h3>
    <asp:Label ID="jaktledarnamn" runat="server" Text="Namn:"></asp:Label>
    <asp:Label ID="getjaktledarnamn" runat="server" Text="-"></asp:Label>
    <br />
    <asp:Label ID="telefon" runat="server" Text="Telefon:"></asp:Label>    
    <asp:Label ID="gettelefon" runat="server" Text="-"></asp:Label>
    <br />
    <asp:Label ID="epost" runat="server" Text="E-post:"></asp:Label>
    <asp:Label ID="getepost" runat="server" Text="-"></asp:Label>
    <br />
    <br />
    <h3>Fällda älgar:</h3>
    <asp:Label ID="falltaalghanar" runat="server" Text="Tjurar:"></asp:Label>
    <asp:Label ID="getfalldaalghanar" runat="server" Text="-"></asp:Label>
    <br />
    <asp:Label ID="falldaälghonor" runat="server" Text="Kvigor:"></asp:Label>
    <asp:Label ID="getfalldaalghonor" runat="server" Text="-"></asp:Label>
    <br />  
    <asp:Label ID="falldahankalvar" runat="server" Text="Tjurkalvar:"></asp:Label>
    <asp:Label ID="getfalldahankalvar" runat="server" Text="-"></asp:Label>
    <br />   
    <asp:Label ID="falldahonkalvar" runat="server" Text="Kvigkalvar:"></asp:Label>
    <asp:Label ID="getfalldahonkalvar" runat="server" Text="-"></asp:Label>
    <br />
</asp:Content>
