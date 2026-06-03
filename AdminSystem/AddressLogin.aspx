<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddressLogin.aspx.cs" Inherits="_1Viewer" %>

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
            <div class="col-12 col-sm-8 col-md-6 col-lg-4">
                <div class="card shadow-lg border-0 rounded-3">
                    <div class="card-header bg-primary text-white text-center py-3">
                        <h4 class="mb-0"><i class="bi bi-shield-lock me-2"></i>Address Management</h4>
                        <small>Login Page</small>
                    </div>
                    <div class="card-body p-4">
                        
                        <div class="mb-3">
                            <asp:Label ID="lblUserName" runat="server" CssClass="form-label fw-bold" Text="UserName:"></asp:Label>
                            <div class="input-group">
                                <span class="input-group-text bg-light"><i class="bi bi-person-fill"></i></span>
                                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Enter username"></asp:TextBox>
                            </div>
                        </div>

                        <div class="mb-3">
                            <asp:Label ID="lblPassword" runat="server" CssClass="form-label fw-bold" Text="Password:"></asp:Label>
                            <div class="input-group">
                                <span class="input-group-text bg-light"><i class="bi bi-key-fill"></i></span>
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter password"></asp:TextBox>
                            </div>
                        </div>

                        <div class="mb-3 text-center">
                            <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-semibold small"></asp:Label>
                        </div>

                        <div class="d-grid gap-2 mt-4">
                            <asp:LinkButton ID="btnLogin" runat="server" CssClass="btn btn-primary btn-lg" OnClick="btnLogin_Click">
                                <i class="bi bi-box-arrow-in-right"></i> Login
                            </asp:LinkButton>
                            
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-outline-secondary" OnClick="btnCancel_Click" CausesValidation="false">
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