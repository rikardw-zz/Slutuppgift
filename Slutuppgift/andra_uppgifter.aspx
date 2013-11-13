<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="andra_uppgifter.aspx.cs" Inherits="Slutuppgift.WebForm5" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h2>Ändra uppgifter</h2>  
    Här kan du ändra uppgifter kring ditt jaktlag
    <hr />     
    <div class="statsname">
            Jaktledare:        
        <br />
            <asp:TextBox ID="txtJaktledare" runat="server" Width="145px"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ControlToValidate="txtJaktledare" EnableClientScript="false" Text="Namn fattas" runat="server" ForeColor="Red" ID="RFVtxtJaktledare" />
        <asp:RegularExpressionValidator ID="REVtxtJaktledare" runat="server" ErrorMessage="Endast bokstäver tillåtna" ControlToValidate="txtJaktledare" ForeColor="Red" ValidationExpression="^[a-zA-ZåäöÅÄÖ ]+$" />
        <br />
            E-post:
        <br />
        <asp:TextBox ID="txtEpostJaktledare" runat="server" Width="145px"></asp:TextBox>
        <br />
            <asp:RegularExpressionValidator ID="REVEpostJaktledare" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEpostJaktledare" ErrorMessage="Felaktigt epostformat" ForeColor="Red" />
        <br />
            Telefon:
        <br />
        <asp:TextBox ID="txtTelefonJaktledare" runat="server" Width="145px"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorJaktledare" runat="server" ErrorMessage="1-12 siffror" ControlToValidate="txtTelefonJaktledare" ForeColor="Red" ValidationExpression=\d{12} />
        <br />
        <asp:Button ID="submitRapportör" runat="server" Text="Uppdatera" OnClick="submitRapportör_Click" />
    </div>
    <div class="statsinfo">
            Rapportör:
        <br />
            <asp:TextBox ID="txtRapportör" runat="server" Width="145px"></asp:TextBox>
        <br />
            <asp:RequiredFieldValidator ControlToValidate="txtRapportör" EnableClientScript="false" Text="Namn fattas" runat="server" ForeColor="Red" ID="RFVtxtRapportör" />
            <asp:RegularExpressionValidator ID="REVtxtRapportör" runat="server" ErrorMessage="Endast bokstäver tillåtna" ControlToValidate="txtRapportör" ForeColor="Red" ValidationExpression="^[a-zA-ZåäöÅÄÖ ]+$" />
            <br />
            E-post:
        <br />
            <asp:TextBox ID="txtEpostRapportör" runat="server" Width="145px"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="REVtxtEpostRapportör" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEpostRapportör" ErrorMessage="Felaktigt epostformat" ForeColor="Red" />
            <br />
            Telefon:
         <br />
            <asp:TextBox ID="txtTelefonRapportör" runat="server" Width="145px"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="REVtxtTelefonRapportör" runat="server" ErrorMessage="1-12 siffror" ControlToValidate="txtTelefonRapportör" ForeColor="Red" ValidationExpression=\d{12} />
            <br />
    </div>   
</asp:Content>
