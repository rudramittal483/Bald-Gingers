<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CraftLaptop Main Menu</title>
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
                        <div class="card-header bg-primary text-white py-3 text-center">
                            <h4 class="mb-0"><i class="bi bi-grid-fill me-2"></i>CraftLaptop Main Menu</h4>
                        </div>
                        <div class="card-body p-4">
                            <p class="text-center text-muted mb-4">Please select a management module below to continue.</p>

                            <div class="row g-3">
                                
                                <div class="col-md-6 d-grid">
                                    <asp:LinkButton ID="btnStock" runat="server" CssClass="btn btn-outline-primary btn-lg" OnClick="btnStock_Click" CausesValidation="false">
                                        <i class="bi bi-laptop me-2"></i>Stock
                                    </asp:LinkButton>
                                </div>
                                <div class="col-md-6 d-grid">
                                    <asp:LinkButton ID="btnDiscount" runat="server" CssClass="btn btn-outline-warning btn-lg" OnClick="btnDiscount_Click" CausesValidation="false">
                                        <i class="bi bi-tags me-2"></i>Discount
                                    </asp:LinkButton>
                                </div>
                                
                                <div class="col-md-6 d-grid">
                                    <asp:LinkButton ID="btnOrder" runat="server" CssClass="btn btn-outline-success btn-lg" OnClick="btnOrder_Click" CausesValidation="false">
                                        <i class="bi bi-cart me-2"></i>Order
                                    </asp:LinkButton>
                                </div>
                                <div class="col-md-6 d-grid">
                                    <asp:LinkButton ID="btnOrderLine" runat="server" CssClass="btn btn-outline-secondary btn-lg" OnClick="btnOrderLine_Click" CausesValidation="false">
                                        <i class="bi bi-list-check me-2"></i>Order Line
                                    </asp:LinkButton>
                                </div>
                                
                                <div class="col-md-6 d-grid">
                                    <asp:LinkButton ID="btnCustomer" runat="server" CssClass="btn btn-outline-info btn-lg" OnClick="btnCustomer_Click" CausesValidation="false">
                                        <i class="bi bi-people me-2"></i>Customers
                                    </asp:LinkButton>
                                </div>
                                <div class="col-md-6 d-grid">
                                    <asp:LinkButton ID="btnAddress" runat="server" CssClass="btn btn-outline-dark btn-lg" OnClick="btnAddress_Click" CausesValidation="false">
                                        <i class="bi bi-house-door me-2"></i>Address
                                    </asp:LinkButton>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>