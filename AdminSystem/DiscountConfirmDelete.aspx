<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiscountConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
        <div class="container d-flex justify-content-center align-items-center vh-100">
            <div class="col-12 col-sm-8 col-md-6 col-lg-5">
                <div class="card shadow border-danger rounded-3">
                    <div class="card-header bg-danger text-white text-center py-3">
                        <h5 class="mb-0"><i class="bi bi-exclamation-triangle-fill me-2"></i>Confirm Deletion</h5>
                    </div>
                    <div class="card-body p-4 text-center">
                        
                        <asp:Label ID="lblDelete" runat="server" CssClass="fs-5 fw-semibold mb-4 d-block" Text="Are you sure you want to delete this record?"></asp:Label>

                        <div class="d-flex justify-content-center gap-3 mt-4">
                            <asp:LinkButton ID="btnYes" runat="server" CssClass="btn btn-danger px-4" OnClick="btnYes_Click">
                                <i class="bi bi-trash"></i> Yes
                            </asp:LinkButton>
                            
                            <asp:LinkButton ID="btnNo" runat="server" CssClass="btn btn-secondary px-4" OnClick="btnNo_Click">
                                <i class="bi bi-x-circle"></i> No
                            </asp:LinkButton>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>