<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="testwcf.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSayHi" runat="server" Text="Say Hello"></asp:Label>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnHala" runat="server" Text="Hala" OnClick="btnHala_Click" />
        </div>
    </form>
</body>
</html>
