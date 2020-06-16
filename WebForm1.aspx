<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Consumir_Web_services_de_terceros.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>  
    <form id="form1" runat="server">
        <div>

            Num1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />Num2<asp:TextBox ID="Textbox2" runat ="server"></asp:TextBox>
            <br /><asp:Button ID="Button1" runat="server" Text="Suma" OnClick="Button1_Click" />
            <br /><asp:Button ID="Button2" runat="server" Text="Resta" OnClick="Button2_Click" />
            <br /><asp:Button ID="Button3" runat="server" Text="Multiplicacion" OnClick="Button3_Click" />
            <br /><asp:Button ID="Button4" runat="server" Text="Division" OnClick="Button4_Click" />
            <br /><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
