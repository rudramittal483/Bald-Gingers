<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="300px" Width="500px"></asp:ListBox>

            <asp:Button ID="btnAdd" runat="server" style="position: absolute; left: 10px; top: 330px;" Text="Add" OnClick="btnAdd_Click" />

            <asp:Button ID="btnEdit" runat="server" style="position: absolute; left: 60px; top: 330px;" Text="Edit" OnClick="btnEdit_Click" />

            <asp:Button ID="btnDelete" runat="server" style="position: absolute; left: 110px; top: 330px;" Text="Delete" OnClick="btnDelete_Click" />



            <asp:Label ID="lblFilter" runat="server" style="position: absolute; left: 10px; top: 380px;" Text="Enter Email"></asp:Label>

            <asp:TextBox ID="txtFilter" runat="server" style="position: absolute; left: 180px; top: 380px;"></asp:TextBox>



            <asp:Button ID="btnApplyFilter" runat="server" style="position: absolute; left: 10px; top: 420px;" Text="Apply Filter" OnClick="btnApplyFilter_Click" />

            <asp:Button ID="btnClearFilter" runat="server" style="position: absolute; left: 183px; top: 420px;" Text="Clear Filter" OnClick="btnClearFilter_Click" />



            <asp:Label ID="lblError" runat="server" style="position: absolute; left: 10px; top: 470px;" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>
