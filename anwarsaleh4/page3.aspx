<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="anwarsaleh4.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        NAME<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        EMAIL<br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go To page2" Width="173px" />
    
    </div>
    </form>
</body>
</html>
