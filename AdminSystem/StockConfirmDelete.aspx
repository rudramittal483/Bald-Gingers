<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 97px; top: 43px; position: absolute; height: 25px; width: 360px" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 132px; top: 105px; position: absolute; width: 73px; height: 31px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" height="31px" OnClick="btnNo_Click" style="z-index: 1; left: 279px; top: 105px; position: absolute" Text="No" width="73px" />
    </form>
</body>
</html>
