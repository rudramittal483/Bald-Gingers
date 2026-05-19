<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddressDataEntry.aspx.cs" Inherits="AddressDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Address Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblAddressId" runat="server" style="position: absolute; left: 10px; top: 20px;" Text="Address ID"></asp:Label>
            <asp:TextBox ID="txtAddressId" runat="server" style="position: absolute; left: 150px; top: 20px;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="position: absolute; left: 358px; top: 16px;" Text="Find" OnClick="btnFind_Click" />

            <asp:Label ID="lblCustomerNo" runat="server" style="position: absolute; left: 10px; top: 60px;" Text="Customer No"></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server" style="position: absolute; left: 150px; top: 60px;"></asp:TextBox>

            <asp:Label ID="lblEmirate" runat="server" style="position: absolute; left: 10px; top: 100px;" Text="Emirate"></asp:Label>
            <asp:TextBox ID="txtEmirate" runat="server" style="position: absolute; left: 150px; top: 100px;"></asp:TextBox>

            <asp:Label ID="lblBuildingName" runat="server" style="position: absolute; left: 10px; top: 140px;" Text="Building Name"></asp:Label>
            <asp:TextBox ID="txtBuildingName" runat="server" style="position: absolute; left: 150px; top: 140px;"></asp:TextBox>

            <asp:Label ID="lblStreetName" runat="server" style="position: absolute; left: 10px; top: 180px;" Text="Street Name"></asp:Label>
            <asp:TextBox ID="txtStreetName" runat="server" style="position: absolute; left: 150px; top: 180px;"></asp:TextBox>

            <asp:Label ID="lblAddressType" runat="server" style="position: absolute; left: 10px; top: 220px;" Text="Address Type"></asp:Label>
            <asp:TextBox ID="txtAddressType" runat="server" style="position: absolute; left: 150px; top: 220px;"></asp:TextBox>

            <asp:Label ID="lblPostcode" runat="server" style="position: absolute; left: 10px; top: 260px;" Text="Postcode"></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server" style="position: absolute; left: 150px; top: 260px;"></asp:TextBox>

            <asp:CheckBox ID="chkIsDefault" runat="server" style="position: absolute; left: 10px; top: 300px;" Text="Is Default Address" />

            <asp:Label ID="lblError" runat="server" style="position: absolute; left: 10px; top: 340px;" Text="" ForeColor="Red"></asp:Label>

            <asp:Button ID="btnOK" runat="server" style="position: absolute; left: 10px; top: 380px;" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="position: absolute; left: 80px; top: 380px;" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>