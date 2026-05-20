<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="CustomerConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lblConfirm" runat="server" style="position: absolute; left: 10px; top: 20px;" Text="Are you sure you want to delete this Customer"></asp:Label>
             <asp:Button ID="btnYes" runat="server" style="position: absolute; left: 10px; top: 60px;" Text="Yes" OnClick="btnYes_Click" />
             <asp:Button ID="btnNo" runat="server" style="position: absolute; left: 60px; top: 60px;" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
