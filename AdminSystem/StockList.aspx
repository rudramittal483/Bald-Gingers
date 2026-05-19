<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="300px" Width="500px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 362px; position: absolute; height: 33px; width: 51px" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" height="33px" OnClick="btnDelete_Click" style="z-index: 1; left: 195px; top: 362px; position: absolute" Text="Delete" />
        </p>
        <asp:Button ID="btnEdit" runat="server" height="33px" OnClick="btnEdit_Click" style="z-index: 1; left: 104px; top: 362px; position: absolute" Text="Edit" width="51px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 590px; position: absolute"></asp:Label>
        <asp:Label ID="lblFilterBrand" runat="server" style="z-index: 1; left: 17px; top: 449px; position: absolute" Text="Enter a Brand"></asp:Label>
        <asp:TextBox ID="txtFilterBrand" runat="server" style="z-index: 1; left: 161px; top: 443px; position: absolute; height: 28px; width: 175px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 38px; top: 508px; position: absolute; height: 34px; width: 122px" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" height="34px" OnClick="btnClear_Click" style="z-index: 1; left: 217px; top: 508px; position: absolute" Text="Clear Filter" width="122px" />
    </form>
</body>
</html>
