<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAplikacijaMovies.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 33%;
        }
        .style2
        {
            text-align: justify;
        }
        .style3
        {
            text-align: center;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1">
            <tr>
                <td>
                    <asp:ListBox ID="lstFilmovi" runat="server" AutoPostBack="True" Height="241px" 
                        onselectedindexchanged="lstFilmovi_SelectedIndexChanged" Width="286px">
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPoraka" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnNovFilm" runat="server" onclick="btnNovFilm_Click" 
                        Text="Нов Филм" />
&nbsp;
                    <asp:Button ID="btnVnesi" runat="server" onclick="btnVnesi_Click" 
                        Text="Внеси" />
&nbsp;
                    <asp:Button ID="btnZacuvaj" runat="server" onclick="btnZacuvaj_Click" 
                        Text="Измени" />
&nbsp;
                    <asp:Button ID="btnIzbrisi" runat="server" onclick="btnIzbrisi_Click" 
                        Text="Избриши" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Име"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtIme" runat="server" Width="180px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Режисер"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtReziser" runat="server" Width="180px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Машка Улога"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtMaskaUloga" runat="server" Width="180px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="Женска Улога"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="txtZenskaUloga" runat="server" Width="180px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Жанр"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtZanr" runat="server" Width="180px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Година"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtGodina" runat="server" Width="180px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Времетраење"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtVremetraenje" runat="server" Width="180px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
