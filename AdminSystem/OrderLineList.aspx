<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                            <h4 class="mb-0"><i class="bi bi-list-columns me-2"></i>Order Line Directory</h4>
                        </div>
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:ListBox ID="lstOrderLineList" runat="server" CssClass="form-control" Rows="10"></asp:ListBox>
                            </div>

                            <div class="mb-4 d-flex gap-2">
                                <asp:LinkButton ID="btnAdd" runat="server" CssClass="btn btn-success" OnClick="btnAdd_Click">
                                    <i class="bi bi-plus-circle"></i> Add
                                </asp:LinkButton>
                                
                                <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-warning text-dark" OnClick="btnEdit_Click">
                                    <i class="bi bi-pencil-square"></i> Edit
                                </asp:LinkButton>
                                
                                <asp:LinkButton ID="btnDelete" runat="server" CssClass="btn btn-danger" OnClick="btnDelete_Click">
                                    <i class="bi bi-trash"></i> Delete
                                </asp:LinkButton>
                            </div>

                            <div class="mt-2">
                                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-bold d-block"></asp:Label>
                            </div>

                        </div>
                        <div class="card-footer bg-white text-end py-3">
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