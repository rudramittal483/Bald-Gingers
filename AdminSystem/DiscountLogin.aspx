<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiscountLogin.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> Discount Login Page
        </div>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 64px; top: 128px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 64px; top: 196px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 177px; top: 122px; position: absolute; height: 28px" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" height="28px" style="z-index: 1; left: 177px; top: 190px; position: absolute" TextMode="Password" width="168px"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 177px; top: 281px; position: absolute; height: 31px; width: 63px; right: 513px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 276px; top: 281px; position: absolute; height: 31px" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 434px; top: 171px; position: absolute"></asp:Label>
    </form>
</body>
</html>
