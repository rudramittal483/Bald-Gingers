<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiscountList.aspx.cs" Inherits="_1_List" %>

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
                <div class="col-md-10 col-lg-8">
                    
                    <div class="card shadow-sm border-0 rounded-3">
                        <div class="card-header bg-primary text-white py-3">
                            <h4 class="mb-0"><i class="bi bi-percent me-2"></i>Discount Directory</h4>
                        </div>
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:ListBox ID="lstDiscountList" runat="server" CssClass="form-control" Rows="10"></asp:ListBox>
                            </div>

                            <div class="mb-4 d-flex gap-2">
                                <asp:LinkButton ID="btnAdd" runat="server" OnClick="btnAdd_Click" CssClass="btn btn-success">
                                    <i class="bi bi-plus-circle"></i> Add
                                </asp:LinkButton>
                                
                                <asp:LinkButton ID="btnEdit" runat="server" OnClick="btnEdit_Click" CssClass="btn btn-warning text-dark">
                                    <i class="bi bi-pencil-square"></i> Edit
                                </asp:LinkButton>
                                
                                <asp:LinkButton ID="btnDelete" runat="server" OnClick="btnDelete_Click" CssClass="btn btn-danger">
                                    <i class="bi bi-trash"></i> Delete
                                </asp:LinkButton>
                            </div>

                            <hr />

                            <div class="bg-light border rounded-3 p-3 mb-3">
                                <h6 class="text-muted mb-3"><i class="bi bi-funnel-fill me-1"></i> Filter Options</h6>
                                <div class="row g-2 align-items-center">
                                    <div class="col-auto">
                                        <asp:Label ID="lblFilterCode" runat="server" CssClass="col-form-label fw-bold" Text="Enter a Discount Code:"></asp:Label>
                                    </div>
                                    <div class="col-md-4">
                                        <asp:TextBox ID="txtFilterCode" runat="server" CssClass="form-control" placeholder="e.g., SAVE10"></asp:TextBox>
                                    </div>
                                    <div class="col-auto d-flex gap-2">
                                        <asp:LinkButton ID="btnApply" runat="server" OnClick="btnApply_Click" CssClass="btn btn-primary">
                                            <i class="bi bi-search"></i> Apply Filter
                                        </asp:LinkButton>
                                        
                                        <asp:LinkButton ID="btnClear" runat="server" OnClick="btnClear_Click" CssClass="btn btn-outline-secondary">
                                            <i class="bi bi-eraser-fill"></i> Clear Filter
                                        </asp:LinkButton>
                                    </div>
                                </div>
                            </div>

                            <div class="mt-3">
                                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-bold"></asp:Label>
                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>