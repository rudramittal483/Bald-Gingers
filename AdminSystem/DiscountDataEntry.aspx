<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiscountDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div style="height: 23px">
            This is This is the Discount Data Entry Page<asp:TextBox ID="txtDiscountId" runat="server" style="z-index: 1; top: 41px; position: absolute; left: 268px" height="25px" width="168px"></asp:TextBox>
            <br />
            <br />
        </div>
        <p style="height: 320px; margin-top: 0px">
            <asp:Label ID="lblDiscountId" runat="server" style="z-index: 1; left: 9px; top: 45px; position: absolute" Text="Discount ID" width="103px"></asp:Label>
            <asp:Label ID="lblDiscountCode" runat="server" style="z-index: 1; left: 9px; top: 96px; position: absolute; width: 123px;" Text="Discount Code"></asp:Label>
            <asp:Label ID="lblDiscountPercent" runat="server" style="z-index: 1; left: 9px; top: 154px; position: absolute; bottom: 381px;" Text="Discount Percent"></asp:Label>
            <asp:TextBox ID="txtDiscountCode" runat="server" height="25px" style="z-index: 1; left: 268px; top: 92px; position: absolute" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtEndDate" runat="server" height="25px" style="z-index: 1; left: 268px; top: 321px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblEndDate" runat="server" height="22px" style="z-index: 1; left: 9px; top: 326px; position: absolute" Text="End Date" width="103px"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 528px; top: 39px; position: absolute; width: 64px; bottom: 713px" Text="Find" />
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 9px; top: 214px; position: absolute" Text="Description" width="103px"></asp:Label>
            <asp:TextBox ID="txtDiscountPercent" runat="server" height="25px" style="z-index: 1; left: 268px; top: 154px; position: absolute" width="168px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 268px; top: 210px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 9px; top: 268px; position: absolute" Text="Start Date" width="103px"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 268px; top: 264px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 268px; top: 392px; position: absolute" width="103px"></asp:Label>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 42px; top: 428px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 110px; top: 429px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
