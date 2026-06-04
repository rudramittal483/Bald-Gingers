<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddressDataEntry.aspx.cs" Inherits="AddressDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Address Data Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-8 col-lg-6">
                    <div class="card shadow-sm border-0 rounded-3">
                        <div class="card-header bg-primary text-white py-3">
                            <h4 class="mb-0">Address Data Entry</h4>
                        </div>
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:Label ID="lblAddressId" runat="server" CssClass="form-label" Text="Address ID"></asp:Label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtAddressId" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:LinkButton ID="btnFind" runat="server" CssClass="btn btn-outline-primary" OnClick="btnFind_Click">
                                        <i class="bi bi-search"></i> Find
                                    </asp:LinkButton>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblCustomerNo" runat="server" CssClass="form-label" Text="Customer No"></asp:Label>
                                <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="form-control bg-light" ReadOnly="true"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblEmirate" runat="server" CssClass="form-label" Text="Emirate"></asp:Label>
                                <asp:TextBox ID="txtEmirate" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblBuildingName" runat="server" CssClass="form-label" Text="Building Name"></asp:Label>
                                <asp:TextBox ID="txtBuildingName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblStreetName" runat="server" CssClass="form-label" Text="Street Name"></asp:Label>
                                <asp:TextBox ID="txtStreetName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblAddressType" runat="server" CssClass="form-label" Text="Address Type"></asp:Label>
                                <asp:TextBox ID="txtAddressType" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblPostcode" runat="server" CssClass="form-label" Text="Postcode"></asp:Label>
                                <asp:TextBox ID="txtPostcode" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="form-check mb-3">
                                <asp:CheckBox ID="chkIsDefault" runat="server" CssClass="form-check-input" Text="Is Default Address" />
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-bold" Text=""></asp:Label>
                            </div>

                        </div>
                        <div class="card-footer bg-white text-end py-3">
                            <asp:LinkButton ID="btnOK" runat="server" CssClass="btn btn-success me-2 px-4" OnClick="btnOK_Click">
                                <i class="bi bi-check-circle"></i> OK
                            </asp:LinkButton>
                            
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-danger me-2 px-4" OnClick="btnCancel_Click">
                                <i class="bi bi-x-circle"></i> Cancel
                            </asp:LinkButton>

                            <asp:LinkButton ID="btnReturn" runat="server" CssClass="btn btn-secondary px-4" OnClick="btnReturn_Click" CausesValidation="false">
                                <i class="bi bi-arrow-return-left"></i> Main Menu
                            </asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>