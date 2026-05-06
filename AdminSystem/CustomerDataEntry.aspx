<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:Label ID="lblCustomerNo" runat="server" style="position: absolute; left: 10px; top: 20px;" Text="Customer No"></asp:Label>
                <asp:TextBox ID="txtCustomerNo" runat="server" style="position: absolute; left: 150px; top: 20px;"></asp:TextBox>

                <asp:Label ID="lblFirstName" runat="server" style="position: absolute; left: 10px; top: 60px;" Text="First Name"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" style="position: absolute; left: 150px; top: 60px;"></asp:TextBox>

                <asp:Label ID="lblLastName" runat="server" style="position: absolute; left: 10px; top: 100px;" Text="Last Name"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" style="position: absolute; left: 150px; top: 100px;"></asp:TextBox>

                <asp:Label ID="lblEmail" runat="server" style="position: absolute; left: 10px; top: 140px;" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" style="position: absolute; left: 150px; top: 140px;"></asp:TextBox>

                <asp:Label ID="lblDateJoined" runat="server" style="position: absolute; left: 10px; top: 180px;" Text="Date Joined"></asp:Label>
                <asp:TextBox ID="txtDateJoined" runat="server" style="position: absolute; left: 150px; top: 180px;"></asp:TextBox>

                <asp:CheckBox ID="chkIsActive" runat="server" style="position: absolute; left: 10px; top: 220px;" Text="Active" />

                <asp:Label ID="lblError" runat="server" style="position: absolute; left: 10px; top: 260px;" Text="" ForeColor="Red"></asp:Label>

                <asp:Button ID="btnOK" runat="server" style="position: absolute; left: 10px; top: 300px;" Text="OK" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" style="position: absolute; left: 80px; top: 300px;" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
