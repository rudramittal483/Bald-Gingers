<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="OrderDataEntry" %>
<!DOCTYPE html>
<html>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderNo" runat="server" style="position: absolute; left: 10px; top: 20px;" Text="Order Number"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server" style="position: absolute; left: 150px; top: 20px;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" style="position: absolute; left: 320px; top: 20px;" OnClick="btnFind_Click" />

            <asp:Label ID="lblCustomerNo" runat="server" style="position: absolute; left: 10px; top: 60px;" Text="Customer Number"></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server" style="position: absolute; left: 150px; top: 60px;"></asp:TextBox>

            <asp:Label ID="lblOrderDate" runat="server" style="position: absolute; left: 10px; top: 100px;" Text="Order Date"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" style="position: absolute; left: 150px; top: 100px;"></asp:TextBox>

            <asp:Label ID="lblTotalAmount" runat="server" style="position: absolute; left: 10px; top: 140px;" Text="Total Amount"></asp:Label>
            <asp:TextBox ID="txtTotalAmount" runat="server" style="position: absolute; left: 150px; top: 140px;"></asp:TextBox>

            <asp:Label ID="lblDeliveryAddress" runat="server" style="position: absolute; left: 10px; top: 180px;" Text="Delivery Address"></asp:Label>
            <asp:TextBox ID="txtDeliveryAddress" runat="server" style="position: absolute; left: 150px; top: 180px;"></asp:TextBox>

            <asp:CheckBox ID="chkIsDispatched" runat="server" style="position: absolute; left: 10px; top: 220px;" Text="Is Dispatched" />

            <asp:Label ID="lblError" runat="server" style="position: absolute; left: 10px; top: 260px;" Text="" ForeColor="Red"></asp:Label>

            <asp:Button ID="btnOK" runat="server" style="position: absolute; left: 10px; top: 300px;" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="position: absolute; left: 80px; top: 300px;" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>