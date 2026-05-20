<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="OrderConfirmDelete" %>
<!DOCTYPE html>
<html>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirm" runat="server" style="position: absolute; left: 10px; top: 20px;" Text="Are you sure you want to delete this order"></asp:Label>
            <asp:Button ID="btnYes" runat="server" style="position: absolute; left: 10px; top: 60px;" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" style="position: absolute; left: 60px; top: 60px;" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>