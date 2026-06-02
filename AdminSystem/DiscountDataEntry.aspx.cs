using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 DiscountId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        DiscountId = Convert.ToInt32(Session["DiscountId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (DiscountId != -1)
            {
                //display the current data for the record
                DisplayDiscount();
            }
        }
    }

    void DisplayDiscount()
    {
        //create an instance of the discount class
        clsDiscountCollection DiscountCollection = new clsDiscountCollection();
        //find the record to update
        DiscountCollection.ThisDiscount.Find(DiscountId);
        //display the data for this record
        txtDiscountCode.Text = DiscountCollection.ThisDiscount.DiscountCode;
        txtDescription.Text = DiscountCollection.ThisDiscount.DiscountDescription;
        txtDiscountPercent.Text = DiscountCollection.ThisDiscount.DiscountPercent.ToString();
        txtStartDate.Text = DiscountCollection.ThisDiscount.DiscountStartDate.ToString();
        txtEndDate.Text = DiscountCollection.ThisDiscount.DiscountEndDate.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsDiscount
        ClassLibrary.clsDiscount ADiscount = new ClassLibrary.clsDiscount();

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
            ADiscount.DiscountId = DiscountId;
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
            //create a new instance of the discount collection
            ClassLibrary.clsDiscountCollection DiscountList = new ClassLibrary.clsDiscountCollection();

            //if this is a new record i.e. DiscountId = -1 then add the data
            if (DiscountId == -1)
            {
                DiscountList.ThisDiscount = ADiscount;
                DiscountList.Add();
            }
            else //otherwise it must be an update
            {
                //find the record to update
                DiscountList.ThisDiscount.Find(DiscountId);
                //set the ThisDiscount property to the new data
                DiscountList.ThisDiscount = ADiscount;
                //update the record
                DiscountList.Update();
            }
            Session["ADiscount"] = ADiscount;
            //navigate to the view page
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
        // Only attempt to find if the text box is NOT empty
        if (txtDiscountId.Text.Length > 0)
        {
            //create instance of the discount class
            clsDiscount ADiscount = new clsDiscount();
            //create a boolean variable to store the result of the find operation
            Boolean Found = false;

            //get the primary key entered by the user
            Int32 DiscountId = Convert.ToInt32(txtDiscountId.Text);

            //find the record
            Found = ADiscount.Find(DiscountId);

            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtDiscountCode.Text = ADiscount.DiscountCode;
                txtDescription.Text = ADiscount.DiscountDescription;
                txtDiscountPercent.Text = ADiscount.DiscountPercent.ToString();
                txtStartDate.Text = ADiscount.DiscountStartDate.ToString();
                txtEndDate.Text = ADiscount.DiscountEndDate.ToString();
            }
            else
            {
                // Optional: Tell the user the ID wasn't found in the database
                lblError.Text = "Discount ID not found.";
            }
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect to the Discount List page
        Response.Redirect("DiscountList.aspx");
    }
}