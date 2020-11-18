<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="anwarsaleh4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        TEXT1<p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            TEXT2</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="replace" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="send" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="set" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="restore" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
