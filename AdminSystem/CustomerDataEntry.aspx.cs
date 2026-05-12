using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        AnCustomer.FirstName = txtFirstName.Text;
        AnCustomer.LastName = txtLastName.Text;
        AnCustomer.Email = txtEmail.Text;
        AnCustomer.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
        AnCustomer.IsActiveAccount = chkIsActive.Checked;
        Session["AnCustomer"] = AnCustomer;
        Response.Redirect("CustomerViewer.aspx");
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerNo;
        Boolean Found = false;

        if (txtCustomerNo.Text != "")
        {
            CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            Found = AnCustomer.Find(CustomerNo);
           
            if (Found == true)
            {
                txtCustomerNo.Text = AnCustomer.CustomerNo.ToString();
                txtFirstName.Text = AnCustomer.FirstName.ToString();
                txtLastName.Text = AnCustomer.LastName.ToString();
                txtDateJoined.Text = AnCustomer.DateJoined.ToString();
                txtEmail.Text = AnCustomer.Email.ToString();
                chkIsActive.Checked = AnCustomer.IsActiveAccount;
                lblError.Text = "";
            }
            else { lblError.Text = "Customer not found."; }
        }
    }
}