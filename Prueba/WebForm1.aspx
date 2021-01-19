<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prueba.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 208px;
            width: 1530px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Button" />

        </div>
        <asp:GridView ID="GridUsuarios" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID_usuario" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" />
                <asp:BoundField DataField="Sexo" HeaderText="Genero" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
