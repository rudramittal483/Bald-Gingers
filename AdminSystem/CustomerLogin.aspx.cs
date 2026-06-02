using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsCustomerUser AnUser = new clsCustomerUser();

        //capture the user name and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the outcome of the find operation
        Boolean Found = false;
        //get the user name and password to find the user
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        // add a session variable to store the user name of the logged in user
        Session["AnUser"] = AnUser;
        //if username and/or password is empty
        if (txtUserName.Text == "")
        {
            lblError.Text = "Please enter a username.";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Please enter a password.";
        }
        else if (Found == true)
        {
            Response.Redirect("CustomerList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect to the Team Main Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}