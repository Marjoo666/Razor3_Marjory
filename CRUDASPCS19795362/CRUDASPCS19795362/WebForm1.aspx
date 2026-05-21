<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CRUDASPCS19795362.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 77%;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: x-large;
            width: 201px;
        }
        .auto-style4 {
            font-size: x-large;
            width: 177px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>REGISTRO DE ESTUDIANTE<table class="auto-style1">
                    <tr>
                        <td class="auto-style3">ID</td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:Button ID="Button6" runat="server" Text="Search" OnClick="Button6_Click" />
                            <br />
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Nombre</td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Genero</td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style2">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem>Masculino</asp:ListItem>
                                <asp:ListItem>Femenino</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Email</td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Ciudad</td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    </table>

                </h1>
            </center>
        </div>
        <center>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Text="New" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style2" Text="Save" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style2" Text="Update" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" CssClass="auto-style2" Text="Delete" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" CssClass="auto-style2" Text="Show" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" GridLines="None" Height="185px" Width="461px" ForeColor="#333333">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </center>
    </form>
</body>
</html>
