<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="andra_uppgifter.aspx.cs" Inherits="Slutuppgift.WebForm5" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h2>Ändra uppgifter</h2>   
    <div class="statsname">
        <p>
            Jaktledare:        
        </p>
        <p>
            <asp:TextBox ID="txtJaktledare" runat="server" Width="250px"></asp:TextBox>
        </p>
        <asp:RequiredFieldValidator ControlToValidate="txtJaktledare" EnableClientScript="false" Text="Namn fattas" runat="server" ForeColor="Red" ID="RFVtxtJaktledare" />
        <asp:RegularExpressionValidator ID="REVtxtJaktledare" runat="server" ErrorMessage="Endast bokstäver tillåtna" ControlToValidate="txtJaktledare" ForeColor="Red" ValidationExpression="^[a-zA-ZåäöÅÄÖ ]+$" />
        <p>
            E-post:
        </p>
        <asp:TextBox ID="txtEpostJaktledare" runat="server" Width="250px"></asp:TextBox>
        <p>
            <asp:RegularExpressionValidator ID="REVEpostJaktledare" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEpostJaktledare" ErrorMessage="Felaktigt epostformat" ForeColor="Red" />
        <p>
            Telefon:
        </p>
        <asp:TextBox ID="txtTelefonJaktledare" runat="server" Width="250px"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorJaktledare" runat="server" ErrorMessage="Endast siffror" ControlToValidate="txtTelefonJaktledare" ForeColor="Red" ValidationExpression=[0-9]+ />
        <br />
        <asp:Button ID="submitRapportör" runat="server" Text="Uppdatera" OnClick="submitRapportör_Click" />
        <br>
    </div>
    <div class="statsinfo">
        <p>
            Rapportör:
        </p>
        <p>
            <asp:TextBox ID="txtRapportör" runat="server" Width="250px"></asp:TextBox>
        </p>
        <p>
            <asp:RequiredFieldValidator ControlToValidate="txtRapportör" EnableClientScript="false" Text="Namn fattas" runat="server" ForeColor="Red" ID="RFVtxtRapportör" />
            <asp:RegularExpressionValidator ID="REVtxtRapportör" runat="server" ErrorMessage="Endast bokstäver tillåtna" ControlToValidate="txtRapportör" ForeColor="Red" ValidationExpression="^[a-zA-ZåäöÅÄÖ ]+$" />
        </p>
        <p>
            E-post:
        </p>
        <p>
            <asp:TextBox ID="txtEpostRapportör" runat="server" Width="250px"></asp:TextBox>
        </p>
        <p>
            <asp:RegularExpressionValidator ID="REVtxtEpostRapportör" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEpostRapportör" ErrorMessage="Felaktigt epostformat" ForeColor="Red" />
        </p>
        <p>
            Telefon:
        </p>
        <asp:TextBox ID="txtTelefonRapportör" runat="server" Width="250px"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="REVtxtTelefonRapportör" runat="server" ErrorMessage="Endast siffror" ControlToValidate="txtTelefonRapportör" ForeColor="Red" ValidationExpression=[0-9]+ />
        <br />
    </div>
    <br />
</asp:Content>
