<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiscountDataEntry.aspx.cs" Inherits="_1_DataEntry" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Discount Data Entry</title>
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
                            <h4 class="mb-0"><i class="bi bi-tags-fill me-2"></i>Discount Data Entry</h4>
                        </div>
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:Label ID="lblDiscountId" runat="server" CssClass="form-label fw-bold" Text="Discount ID"></asp:Label>
                                <div class="input-group">
                                    <span class="input-group-text bg-light"><i class="bi bi-hash"></i></span>
                                    <asp:TextBox ID="txtDiscountId" runat="server" CssClass="form-control" placeholder="Enter Discount ID"></asp:TextBox>
                                    <asp:LinkButton ID="btnFind" runat="server" CssClass="btn btn-outline-primary px-4" OnClick="btnFind_Click">
                                        <i class="bi bi-search"></i> Find
                                    </asp:LinkButton>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblDiscountCode" runat="server" CssClass="form-label fw-bold" Text="Discount Code"></asp:Label>
                                <asp:TextBox ID="txtDiscountCode" runat="server" CssClass="form-control" placeholder="e.g., SUMMER50"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblDiscountPercent" runat="server" CssClass="form-label fw-bold" Text="Discount Percent"></asp:Label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtDiscountPercent" runat="server" CssClass="form-control" placeholder="e.g., 15"></asp:TextBox>
                                    <span class="input-group-text bg-light"><i class="bi bi-percent"></i></span>
                                </div>
                            </div>

                            <div class="mb-3">
                                <asp:Label ID="lblDescription" runat="server" CssClass="form-label fw-bold" Text="Description"></asp:Label>
                                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" placeholder="Enter description details"></asp:TextBox>
                            </div>

                            <div class="row">
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblStartDate" runat="server" CssClass="form-label fw-bold" Text="Start Date"></asp:Label>
                                    <div class="input-group">
                                        <span class="input-group-text bg-light"><i class="bi bi-calendar-check"></i></span>
                                        <asp:TextBox ID="txtStartDate" runat="server" CssClass="form-control" placeholder="DD-MM-YYYY"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <asp:Label ID="lblEndDate" runat="server" CssClass="form-label fw-bold" Text="End Date"></asp:Label>
                                    <div class="input-group">
                                        <span class="input-group-text bg-light"><i class="bi bi-calendar-x"></i></span>
                                        <asp:TextBox ID="txtEndDate" runat="server" CssClass="form-control" placeholder="DD-MM-YYYY"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="mt-2 mb-2">
                                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-semibold d-block"></asp:Label>
                            </div>

                        </div>
                        <div class="card-footer bg-white text-end py-3">
                            <asp:LinkButton ID="btnOK" runat="server" CssClass="btn btn-success me-2 px-4" OnClick="btnOK_Click">
                                <i class="bi bi-check-circle"></i> OK
                            </asp:LinkButton>
                            
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-danger me-2 px-4" OnClick="btnCancel_Click" CausesValidation="false">
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