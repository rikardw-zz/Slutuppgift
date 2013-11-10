<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="Slutuppgift.WebForm1" %>    

<asp:Content ID="Startsida" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
     
    <asp:DropDownList ID="väljår" runat="server" AutoPostBack="true" OnSelectedIndexChanged="väljår_SelectedIndexChanged" Width="127px" >
        <asp:ListItem>2011</asp:ListItem>
        <asp:ListItem>2012</asp:ListItem>
        <asp:ListItem>2013</asp:ListItem>
    </asp:DropDownList>
    <h2>Skjutna älgar:</h2>    
    <div class="statsname">
        <p>
            Älghanar:
        </p>
        <p>
            Älghonor
        </p>
        <p>
            Hankalvar:
        </p>
         <p>
            Honkalvar:
        </p>
        <h2>
            Snittvikt:
        </h2>
        <p>
            Älghanar:
        </p>
        <p>
            Älghonor
        </p>
        <p>
            Kalvar:
        </p>
        <h2>
            Snittålder:
        </h2>
        <p>
            Älghanar:
        </p>
        <p>
            Älghonor
        </p>
        <h2>
            Snittaggar:
        </h2>
        <p>
            Älghanar:
        </p>
    </div>
    <div class="statsinfo">
        <p>
            <asp:Label ID="skjutnahanar" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="skjutnahonor" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="skjutnahankalvar" runat="server" Text="-"></asp:Label>
        </p>
                <p>
            <asp:Label ID="skjutnahonkalvar" runat="server" Text="-"></asp:Label>
        </p>
        <h2>
            <br />
        </h2>
        <p>
            <asp:Label ID="snittvikthanar" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="snittvikthonor" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="snittviktkalvar" runat="server" Text="-"></asp:Label>
        </p>
         <h2>
             <br />
         </h2>
        <p>
            <asp:Label ID="snittalderhanar" runat="server" Text="-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="snittalderhonor" runat="server" Text="-"></asp:Label>
        </p>
        <h2>
             <br />
         </h2>
        <p>
            <asp:Label ID="taggar" runat="server" Text="-"></asp:Label>
        </p>
    </div>   
    <br>           
   
</asp:Content>
