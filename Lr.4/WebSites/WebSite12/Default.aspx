<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    
    <div>
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1"/>
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1"/>
        <br />
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1"/>
        <br />
        <br />

        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ответить" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>

        <br />
        <br />
        <asp:Button ID="Button3" runat="server"  Height="0px" Text="0" Width="0px" BackColor="White" BorderColor="White" BorderStyle="None" />
        <asp:Button ID="Button2" runat="server"  Height="0px" Text="0" Width="0px" BackColor="White" BorderColor="White" BorderStyle="None" />
        &nbsp;<br />
        <br />
        

    </div>
    </form>
</body>
</html>
