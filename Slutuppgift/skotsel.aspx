<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="skotsel.aspx.cs" Inherits="Slutuppgift.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>

    <h2>Rapportering</h2>
    Här kan du rapportera skutna älgar 
    <p />
    <asp:ListBox ID="lbjaktlag" runat="server" Width="128px"></asp:ListBox>
    <asp:RequiredFieldValidator ControlToValidate="lbjaktlag" EnableClientScript="false" Text="Du måste välja ett jaktlag" runat="server" ForeColor="Red" ID="RequiredFieldValidatorJaktlag" />    
    <p>
        <asp:TextBox ID="skytt" runat="server" placeholder="Namn på skytt" Style="text-align: left"></asp:TextBox>
         <asp:RequiredFieldValidator ControlToValidate="skytt" EnableClientScript="false" Text="Du måste fylla i namn" runat="server" ForeColor="Red" ID="RequiredFieldValidatorNamn" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorSkytt" runat="server" ErrorMessage="Endast bokstäver tillåtna" ControlToValidate="skytt" ValidationExpression="^[a-z]*$" />
    </p>
    <p>
        <asp:TextBox ID="datum" runat="server" placeholder="Datum"></asp:TextBox>
        <asp:RangeValidator ControlToValidate="datum" MinimumValue="2011-01-01" MaximumValue="2014-12-30" Type="Date" EnableClientScript="false" Text="Du kan bara rapportera älgar från 2011 tills 2014" runat="server" ForeColor="Red" ID="RangeValidatorDatum" />
        <asp:RequiredFieldValidator ControlToValidate="datum" EnableClientScript="false" Text="Du måste fylla i datum" runat="server" ForeColor="Red" ID="RequiredFieldValidatorDatum" />
    </p>
    <p>
        <asp:DropDownList ID="kön" runat="server" Width="157px">
            <asp:ListItem>Hane</asp:ListItem>
            <asp:ListItem>Hona</asp:ListItem>
        </asp:DropDownList>

    </p>
    <p>
        <asp:TextBox ID="vikt" runat="server" placeholder="Vikt (kilo)"></asp:TextBox>
        <asp:RangeValidator ControlToValidate="vikt" MinimumValue="10" MaximumValue="850" Type="Integer" EnableClientScript="false" Text="Vikt anges mellan 10 och 850 kilo" runat="server" ForeColor="Red" ID="RangeValidatorVikt" />
        <asp:RequiredFieldValidator ControlToValidate="vikt" EnableClientScript="false" Text="Du måste fylla i vikt" runat="server" ForeColor="Red" ID="RequiredFieldValidatorVikt" />
    </p>

    <p>
        <asp:TextBox ID="taggar" runat="server" placeholder="Antal taggar"></asp:TextBox>
        <asp:RangeValidator ControlToValidate="taggar" MinimumValue="0" MaximumValue="50" Type="Integer" EnableClientScript="false" Text="Max antal taggar är 50" runat="server" ForeColor="Red" ID="RangeValidatorTaggar" />
        <asp:RequiredFieldValidator ControlToValidate="taggar" EnableClientScript="false" Text="Du måste fylla i antal taggar" runat="server" ForeColor="Red" ID="RequiredFieldValidatorTaggar" />
    </p>

    <p>
        <asp:TextBox ID="ålder" runat="server" placeholder="Ålder"></asp:TextBox>
        <asp:RangeValidator ControlToValidate="ålder" MinimumValue="0" MaximumValue="50" Type="Integer" EnableClientScript="false" Text="Maxålder är 50 år" runat="server" ForeColor="Red" ID="RangeValidatorÅlder" />
        <asp:RequiredFieldValidator ControlToValidate="ålder" EnableClientScript="false" Text="Du måste fylla i ålder" runat="server" ForeColor="Red" ID="RequiredFieldValidatorÅlder" />
    </p>
    <p>
        <asp:Button ID="submit" runat="server" Text="Skicka uppgifter" OnClick="submit_Click" />
    </p>

    <script type="text/javascript" src="slutuppgift.js"></script>
</asp:Content>
