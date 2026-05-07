<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineDataEntry.aspx.cs" Inherits="OrderLineDataEntry" %>
<!DOCTYPE html>
<html>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderLineNo" runat="server" style="position: absolute; left: 10px; top: 20px;" Text="Line Number"></asp:Label>
            <asp:TextBox ID="txtOrderLineNo" runat="server" style="position: absolute; left: 150px; top: 20px;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" style="position: absolute; left: 320px; top: 20px;" OnClick="btnFindLine_Click" />
            <asp:Label ID="lblOrderNo" runat="server" style="position: absolute; left: 10px; top: 60px;" Text="Order Number"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server" style="position: absolute; left: 150px; top: 60px;"></asp:TextBox>

            <asp:Label ID="lblLaptopNo" runat="server" style="position: absolute; left: 10px; top: 100px;" Text="Laptop Number"></asp:Label>
            <asp:TextBox ID="txtLaptopNo" runat="server" style="position: absolute; left: 150px; top: 100px;"></asp:TextBox>

            <asp:Label ID="lblQuantity" runat="server" style="position: absolute; left: 10px; top: 140px;" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="position: absolute; left: 150px; top: 140px;"></asp:TextBox>

            <asp:Label ID="lblError" runat="server" style="position: absolute; left: 10px; top: 180px;" Text="" ForeColor="Red"></asp:Label>

            <asp:Button ID="btnOK" runat="server" style="position: absolute; left: 10px; top: 220px;" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="position: absolute; left: 80px; top: 220px;" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
    </form>
</body>
</html>