<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 342px;
        }
    </style>
</head>
<body style="height: 336px">
    <form id="form1" runat="server">
        <div style="height: 23px">
            This is the Stock Data Entry Page<asp:TextBox ID="txtLaptopId" runat="server" style="z-index: 1; top: 41px; position: absolute; left: 268px" height="25px" width="168px"></asp:TextBox>
            <br />
            <br />
        </div>
        <p>
            <asp:Label ID="lblLaptopId" runat="server" style="z-index: 1; left: 9px; top: 45px; position: absolute" Text="Laptop ID" width="103px"></asp:Label>
            <asp:Label ID="lblDiscountId" runat="server" style="z-index: 1; left: 9px; top: 96px; position: absolute; right: 730px;" Text="Discount ID" width="103px" height="22px"></asp:Label>
            <asp:Label ID="lblBrand" runat="server" style="z-index: 1; left: 9px; top: 154px; position: absolute; bottom: 138px;" Text="Brand" height="22px" width="103px"></asp:Label>
            <asp:TextBox ID="txtDiscountId" runat="server" height="25px" style="z-index: 1; left: 268px; top: 92px; position: absolute" width="168px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 528px; top: 39px; position: absolute; width: 64px; bottom: 713px" Text="Find" />
        </p>
        <asp:TextBox ID="txtModelName" runat="server" style="z-index: 1; left: 268px; top: 210px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 9px; top: 268px; position: absolute; right: 730px;" Text="Date Added" width="103px" height="22px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 268px; top: 264px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <p style="height: 55px">
            <asp:Label ID="lblModelName" runat="server" style="z-index: 1; left: 9px; top: 214px; position: absolute" Text="ModelName" width="103px" height="22px"></asp:Label>
            <asp:TextBox ID="txtBrand" runat="server" height="25px" style="z-index: 1; left: 268px; top: 155px; position: absolute" width="168px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 268px; top: 437px; position: absolute" Text="In Stock" height="25px" width="168px" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 28px; top: 524px; position: absolute" Text="OK" OnClick="btnOK_Click" height="29px" />
            <asp:Label ID="lblQuantity" runat="server" height="22px" style="z-index: 1; left: 9px; top: 328px; position: absolute" Text="Quantity" width="103px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" height="25px" style="z-index: 1; left: 268px; top: 324px; position: absolute" width="168px"></asp:TextBox>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 112px; top: 524px; position: absolute" Text="Cancel" height="29px" />
        <p>
            <asp:Label ID="lblPrice" runat="server" height="22px" style="z-index: 1; left: 9px; top: 384px; position: absolute" Text="Price" width="103px"></asp:Label>
        </p>
        <asp:TextBox ID="txtPrice" runat="server" height="25px" style="z-index: 1; left: 268px; top: 380px; position: absolute" width="168px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 268px; top: 481px; position: absolute" width="103px"></asp:Label>
            </p>
    </form>
</body>
</html>
