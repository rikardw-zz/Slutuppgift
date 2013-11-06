<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="andra_uppgifter.aspx.cs" Inherits="Slutuppgift.WebForm5" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h2>Uppdatera uppgifter</h2>   
    <p/>
    <asp:DropDownList runat="server" ID="jaktledare" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="jaktledare_SelectedIndexChanged">                                
    </asp:DropDownList>  
    <div class ="statsname">
    <p>
        Jaktledare:        
    </p>
    <asp:TextBox ID="txtJaktledare" runat="server"></asp:TextBox>
    <p>
        E-post:
    </p>
    <asp:TextBox ID="txtEpostJaktledare" runat="server"></asp:TextBox>
    <p>
        Telefon:
    </p>
    <asp:TextBox ID="txtTelefonJaktledare" runat="server"></asp:TextBox>
    <br>
    <asp:Button ID="submitJaktledare" runat="server" Text="Uppdatera" OnClick="submitJaktledare_Click" />
    
    </div>
     <div class ="statsinfo">        
    <p>
        Rapportör:
    </p>   
    <asp:TextBox ID="txtRapportör" runat="server"></asp:TextBox>
    <p>
        E-post:
    </p>     
    <asp:TextBox ID="txtEpostRapportör" runat="server"></asp:TextBox>
    <p>
        Telefon:
    </p>   
    <asp:TextBox ID="txtTelefonRapportör" runat="server"></asp:TextBox>
    <asp:Button ID="submitRapportör" runat="server" Text="Uppdatera" OnClick="submitRapportör_Click" />
    </div>
    <br />
</asp:Content>
