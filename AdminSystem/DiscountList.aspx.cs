using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayDiscounts();
        }

        // Check if a user is currently logged in
        if (Session["AnUser"] != null)
        {
            //create an instance of the discount user
            clsDiscountUser AnUser = new clsDiscountUser();
            //retrieve the logged-in user from the session
            AnUser = (clsDiscountUser)Session["AnUser"];

            // Update the Bootstrap badge label securely (Removed Response.Write)
            lblUser.Text = AnUser.UserName;
        }
        else
        {
            // Fallback if accessed without logging in
            lblUser.Text = "Guest";
        }
    }

    void DisplayDiscounts()
    {
        //create an instance of the discount collection
        clsDiscountCollection AllDiscounts = new clsDiscountCollection();

        // Clear the list box before adding new items
        lstDiscountList.Items.Clear();

        // Loop through every discount item in the database
        foreach (clsDiscount ADiscount in AllDiscounts.DiscountList)
        {
            // Format the text using standard concatenation for C# 5 compatibility
            string displayText = "Code: " + ADiscount.DiscountCode + " | Discount: " + ADiscount.DiscountPercent + "%";

            // Create a new list item with the formatted text and the hidden primary key
            ListItem newItem = new ListItem(displayText, ADiscount.DiscountId.ToString());

            // Add it to the list box
            lstDiscountList.Items.Add(newItem);
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate this is a new record
        Session["DiscountId"] = -1;
        //redirect to the data entry page
        Response.Redirect("DiscountDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edit
        Int32 DiscountId;
        //if a record has been selected from the list
        if (lstDiscountList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            DiscountId = Convert.ToInt32(lstDiscountList.SelectedValue);
            //store the data in the session object
            Session["DiscountId"] = DiscountId;
            //redirect to the edit page
            Response.Redirect("DiscountDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 DiscountId;

        if (lstDiscountList.SelectedIndex != -1)
        {
            DiscountId = Convert.ToInt32(lstDiscountList.SelectedValue);
            Session["DiscountId"] = DiscountId;
            Response.Redirect("DiscountConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the discount collection
        clsDiscountCollection AllDiscounts = new clsDiscountCollection();
        //apply the filter to the data
        AllDiscounts.ReportByDiscountCode(txtFilterCode.Text);

        // Clear the list box before adding filtered items
        lstDiscountList.Items.Clear();

        // Loop through the FILTERED list and format the output
        foreach (clsDiscount ADiscount in AllDiscounts.DiscountList)
        {
            // Format the text using standard concatenation for C# 5 compatibility
            string displayText = "Code: " + ADiscount.DiscountCode + " | Discount: " + ADiscount.DiscountPercent + "%";
            ListItem newItem = new ListItem(displayText, ADiscount.DiscountId.ToString());
            lstDiscountList.Items.Add(newItem);
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the discount collection
        clsDiscountCollection AllDiscounts = new clsDiscountCollection();
        //display all records in the list
        AllDiscounts.ReportByDiscountCode("");
        //clear any existing filter to tidy up the interface
        txtFilterCode.Text = "";

        // Clear the list box before adding unfiltered items
        lstDiscountList.Items.Clear();

        // Loop through the UNFILTERED list and format the output
        foreach (clsDiscount ADiscount in AllDiscounts.DiscountList)
        {
            // Format the text using standard concatenation for C# 5 compatibility
            string displayText = "Code: " + ADiscount.DiscountCode + " | Discount: " + ADiscount.DiscountPercent + "%";
            ListItem newItem = new ListItem(displayText, ADiscount.DiscountId.ToString());
            lstDiscountList.Items.Add(newItem);
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}