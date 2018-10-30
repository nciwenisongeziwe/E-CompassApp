<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="theWebTest.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblText" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnLoadDB" runat="server" Text="Load DB" OnClick="BtnLoadDB_Click" />
        </div>
    </form>
</body>
</html>
