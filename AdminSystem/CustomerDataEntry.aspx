<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
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
                            <h4 class="mb-0"><i class="bi bi-person-vcard me-2"></i>Customer Data Entry</h4>
                        </div>
                        
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:Label ID="lblCustomerNo" runat="server" CssClass="form-label fw-bold" Text="Customer No"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-hash"></i></span>
                                    <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="form-control" placeholder="Enter Customer Number"></asp:TextBox>
                                    <asp:LinkButton ID="btnFind" runat="server" CssClass="btn btn-outline-primary px-4" OnClick="btnFind_Click">
                                        <i class="bi bi-search"></i> Find
                                    </asp:LinkButton>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblFirstName" runat="server" CssClass="form-label fw-bold" Text="First Name"></asp:Label>
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" placeholder="Enter First Name"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblLastName" runat="server" CssClass="form-label fw-bold" Text="Last Name"></asp:Label>
                                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Enter Last Name"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblEmail" runat="server" CssClass="form-label fw-bold" Text="Email"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-envelope-at"></i></span>
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter Email Address"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblDateJoined" runat="server" CssClass="form-label fw-bold" Text="Date Joined"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-calendar-date"></i></span>
                                    <asp:TextBox ID="txtDateJoined" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-4 mt-2 d-flex align-items-center gap-2">
                                <asp:CheckBox ID="chkIsActiveAccount" runat="server" Text=" Active Account" />
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-semibold" Text=""></asp:Label>
                            </div>
                         
                           <hr />
                            <div class="d-flex justify-content-between align-items-center mb-3">
                                <h5 class="text-primary mb-0">Customer Address Details</h5>
                                <asp:LinkButton ID="btnPrepareNewAddress" runat="server" CssClass="btn btn-sm btn-outline-success fw-bold" OnClick="btnPrepareNewAddress_Click">
                                    <i class="bi bi-plus-circle"></i> Add Extra Address
                                </asp:LinkButton>
                            </div>

                            <div class="mb-4 bg-white border p-3 rounded-3 shadow-sm" id="divAddressDropdown" runat="server">
                                <asp:Label ID="lblSavedAddresses" runat="server" CssClass="form-label fw-bold text-muted" Text="Saved Addresses"></asp:Label>
                                <asp:DropDownList ID="ddlAddresses" runat="server" CssClass="form-select border-primary" AutoPostBack="true" OnSelectedIndexChanged="ddlAddresses_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblEmirate" runat="server" CssClass="form-label fw-bold" Text="Emirate"></asp:Label>
                                <asp:TextBox ID="txtEmirate" runat="server" CssClass="form-control" placeholder="Enter Emirate"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblBuildingName" runat="server" CssClass="form-label fw-bold" Text="Building Name"></asp:Label>
                                <asp:TextBox ID="txtBuildingName" runat="server" CssClass="form-control" placeholder="Enter Building Name"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblStreetName" runat="server" CssClass="form-label fw-bold" Text="Street Name"></asp:Label>
                                <asp:TextBox ID="txtStreetName" runat="server" CssClass="form-control" placeholder="Enter Street Name"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblAddressType" runat="server" CssClass="form-label fw-bold" Text="Address Type"></asp:Label>
                                <asp:TextBox ID="txtAddressType" runat="server" CssClass="form-control" placeholder="Home or Work"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblPostcode" runat="server" CssClass="form-label fw-bold" Text="Postcode"></asp:Label>
                                <asp:TextBox ID="txtPostcode" runat="server" CssClass="form-control" placeholder="Enter Postcode"></asp:TextBox>
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