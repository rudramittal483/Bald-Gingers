<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="OrderDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Management System</title>
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
                            <h4 class="mb-0"><i class="bi bi-cart-check-fill me-2"></i>Order Data Entry</h4>
                        </div>
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:Label ID="lblOrderNo" runat="server" CssClass="form-label fw-bold" Text="Order Number"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-hash"></i></span>
                                    <asp:TextBox ID="txtOrderNo" runat="server" CssClass="form-control" placeholder="Enter Order Number"></asp:TextBox>
                                    <asp:LinkButton ID="btnFind" runat="server" CssClass="btn btn-outline-primary px-4" OnClick="btnFind_Click">
                                        <i class="bi bi-search"></i> Find
                                    </asp:LinkButton>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblCustomerNo" runat="server" CssClass="form-label fw-bold" Text="Customer Number"></asp:Label>
                                <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="form-control" placeholder="Enter Customer Number"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblOrderDate" runat="server" CssClass="form-label fw-bold" Text="Order Date"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-calendar-date"></i></span>
                                    <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblTotalAmount" runat="server" CssClass="form-label fw-bold" Text="Total Amount"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-currency-dollar"></i></span>
                                    <asp:TextBox ID="txtTotalAmount" runat="server" CssClass="form-control" placeholder="0.00"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblDeliveryAddress" runat="server" CssClass="form-label fw-bold" Text="Delivery Address"></asp:Label>
                                <asp:TextBox ID="txtDeliveryAddress" runat="server" CssClass="form-control" placeholder="Enter complete delivery address"></asp:TextBox>
                            </div>

                            <div class="form-check mb-4 mt-2">
                                <asp:CheckBox ID="chkIsDispatched" runat="server" CssClass="form-check-input" Text="Is Dispatched" />
                            </div>

                            <div class="mb-2">
                                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-semibold" Text=""></asp:Label>
                            </div>

                        </div>
                        <div class="card-footer bg-white text-end py-3">
                            <asp:LinkButton ID="btnOK" runat="server" CssClass="btn btn-success me-2 px-4" OnClick="btnOK_Click">
                                <i class="bi bi-check-circle"></i> OK
                            </asp:LinkButton>
                            
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-danger px-4" OnClick="btnCancel_Click">
                                <i class="bi bi-x-circle"></i> Cancel
                            </asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>