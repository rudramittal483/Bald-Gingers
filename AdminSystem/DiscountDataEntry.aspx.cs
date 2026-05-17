using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsDiscount
        ClassLibrary.clsDiscount ADiscount = new ClassLibrary.clsDiscount();
        //capture the discount id
        string DiscountId = txtDiscountId.Text;
        //capture the discount code
        string DiscountCode = txtDiscountCode.Text;
        //capture the description
        string DiscountDescription = txtDescription.Text;
        //capture the percentage
        string DiscountPercent = txtDiscountPercent.Text;
        //capture the start date
        string DiscountStartDate = txtStartDate.Text;
        //capture the end date
        string DiscountEndDate = txtEndDate.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ADiscount.Valid(DiscountCode, DiscountDescription, DiscountPercent, DiscountStartDate, DiscountEndDate);
        if (Error == "")
        {
            //capture the discount id
            ADiscount.DiscountId = Convert.ToInt32(txtDiscountId.Text);
            //capture the discount code
            ADiscount.DiscountCode = txtDiscountCode.Text;
            //capture the description
            ADiscount.DiscountDescription = txtDescription.Text;
            //capture the percentage
            ADiscount.DiscountPercent = Convert.ToDouble(txtDiscountPercent.Text);
            //capture the start date
            ADiscount.DiscountStartDate = Convert.ToDateTime(txtStartDate.Text);
            //capture the end date
            ADiscount.DiscountEndDate = Convert.ToDateTime(txtEndDate.Text);

            //store the discount in the session object
            Session["ADiscount"] = ADiscount;
            //redirect to the viewer page
            Response.Redirect("DiscountViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create instance of the stock class
        clsDiscount ADiscount = new clsDiscount();
        //create a variable to store the primary key
        Int32 DiscountId;
        //create a boolean variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        DiscountId = Convert.ToInt32(txtDiscountId.Text);
        //find the record
        Found = ADiscount.Find(DiscountId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDiscountCode.Text = ADiscount.DiscountCode.ToString();
            txtDescription.Text = ADiscount.DiscountDescription.ToString();
            txtDiscountPercent.Text = ADiscount.DiscountPercent.ToString();
            txtStartDate.Text = ADiscount.DiscountStartDate.ToString();
            txtEndDate.Text = ADiscount.DiscountEndDate.ToString();
            txtDiscountId.Text = ADiscount.DiscountId.ToString();
        }
    }
}