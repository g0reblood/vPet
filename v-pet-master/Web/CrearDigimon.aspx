<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CrearDigimon.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 195px;
            height: 19px;
        }
        .auto-style2 {
            width: 195px;
            height: 24px;
        }
        .auto-style3 {
            height: 24px;
        }
        .auto-style4 {
            width: 195px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            height: 19px;
        }
        .auto-style7 {
            height: 24px;
            width: 294px;
        }
        .auto-style8 {
            height: 26px;
            width: 294px;
        }
        .auto-style9 {
            height: 19px;
            width: 294px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style7"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style4">nombre de v-pet:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5"><a align="right" href="Registro.aspx" style="color:yellow">
                <h5 class="auto-style6">Registrate</h5>
                </a></td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style9">
                <asp:Button ID="btnRegistrar" runat="server" Text="registrar" OnClick="btnRegistrar_Click" />
            </td>
            <td class="auto-style6"></td>
        </tr>
    </table>
</asp:Content>

