<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderLineList" runat="server" style="position: absolute; left: 10px; top: 20px;" Height="300px" Width="500px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="position: absolute; left: 10px; top: 330px;" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" style="position: absolute; left: 60px; top: 330px;" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Label ID="lblError" runat="server" style="position: absolute; left: 10px; top: 370px;" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
