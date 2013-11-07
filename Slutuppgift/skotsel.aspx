﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="skotsel.aspx.cs" Inherits="Slutuppgift.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
      <h2>Älgrapportering</h2>
        <p>            
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
            <asp:Button ID="submit" runat="server" Text="Skicka uppgifter" OnClick="submit_Click"/>
        </p>
    
        <script>
            $(function () {
                $(function () {
                    $("#ContentPlaceHolder1_datum").datepicker({
                        inline: true,
                        monthNames: ["Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December"],
                        dayNamesMin: ["Sön", "Mån", "Tis", "Ons", "Tors", "Fre", "Lör"],
                        dateFormat: "yy-mm-dd",
                        firstDay: 1
                    });
                });
            });

            
        </script>

</asp:Content>
