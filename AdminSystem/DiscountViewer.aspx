<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiscountViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Discount Code Added</title>
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
                            <h4 class="mb-0"><i class="bi bi-eye-fill me-2"></i>Discount Code Added!</h4>
                        </div>
                        <div class="card-body p-4">
                            
                            <div class="mb-3">
                                <asp:Label ID="lblViewerData" runat="server" CssClass="text-dark fs-5"></asp:Label>
                            </div>

                        </div>
                        <div class="card-footer bg-white text-end py-3">
                            
                            <asp:LinkButton ID="btnBack" runat="server" CssClass="btn btn-outline-primary me-2 px-4" OnClick="btnBack_Click" CausesValidation="false">
                                <i class="bi bi-arrow-left-circle"></i> Back
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