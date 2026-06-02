<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>
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
                            <h4 class="mb-0"><i class="bi bi-laptop me-2"></i>Stock Data Entry</h4>
                        </div>
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:Label ID="lblLaptopId" runat="server" CssClass="form-label fw-bold" Text="Laptop ID"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-upc-scan"></i></span>
                                    <asp:TextBox ID="txtLaptopId" runat="server" CssClass="form-control" placeholder="Enter Laptop ID"></asp:TextBox>
                                    <asp:LinkButton ID="btnFind" runat="server" CssClass="btn btn-outline-primary px-4" OnClick="btnFind_Click">
                                        <i class="bi bi-search"></i> Find
                                    </asp:LinkButton>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblDiscountId" runat="server" CssClass="form-label fw-bold" Text="Discount ID"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-tags"></i></span>
                                    <asp:TextBox ID="txtDiscountId" runat="server" CssClass="form-control" placeholder="Enter Discount ID"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblBrand" runat="server" CssClass="form-label fw-bold" Text="Brand"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-building"></i></span>
                                    <asp:TextBox ID="txtBrand" runat="server" CssClass="form-control" placeholder="Enter Brand"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblModelName" runat="server" CssClass="form-label fw-bold" Text="Model Name"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-pc-display"></i></span>
                                    <asp:TextBox ID="txtModelName" runat="server" CssClass="form-control" placeholder="Enter Model Name"></asp:TextBox>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblDateAdded" runat="server" CssClass="form-label fw-bold" Text="Date Added"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-calendar-plus"></i></span>
                                    <asp:TextBox ID="txtDateAdded" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblQuantity" runat="server" CssClass="form-label fw-bold" Text="Quantity"></asp:Label>
                                    <div class="input-group">
                                        <span class="input-group-text bg-light"><i class="bi bi-123"></i></span>
                                        <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control" placeholder="Enter Quantity"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblPrice" runat="server" CssClass="form-label fw-bold" Text="Price"></asp:Label>
                                    <div class="input-group">
                                        <span class="input-group-text bg-light"><i class="bi bi-currency-dollar"></i></span>
                                        <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" placeholder="0.00"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="form-check mb-4 mt-2">
                                <asp:CheckBox ID="chkInStock" runat="server" CssClass="form-check-input" Text="In Stock" />
                            </div>

                            <div class="mb-2">
                                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-semibold d-block"></asp:Label>
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