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

    }

    void DisplayDiscounts()
    {
        //create an instance of the stock collection
        clsDiscountCollection AllDiscounts = new clsDiscountCollection();
        //set the data source to the list of discounts in the collection
        lstDiscountList.DataSource = AllDiscounts.DiscountList;
        //set the name of the primary key
        lstDiscountList.DataValueField = "DiscountId";
        //set the data field to display
        lstDiscountList.DataTextField = "DiscountCode";
        //bind the data to the list
        lstDiscountList.DataBind();
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
        //set the data source to the filtered list of discounts
        lstDiscountList.DataSource = AllDiscounts.DiscountList;
        //set the name of the primary key
        lstDiscountList.DataValueField = "DiscountId";
        //set the data field to display
        lstDiscountList.DataTextField = "DiscountCode";
        //bind the data to the list
        lstDiscountList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the discount collection
        clsDiscountCollection AllDiscounts = new clsDiscountCollection();
        //display all records in the list
        AllDiscounts.ReportByDiscountCode("");
        //clear any existing filter to tidy up the interface
        txtFilterCode.Text = "";
        //set the data source to the unfiltered list of discounts
        lstDiscountList.DataSource = AllDiscounts.DiscountList;
        //set the name of the primary key
        lstDiscountList.DataValueField = "DiscountId";
        //set the data field to display
        lstDiscountList.DataTextField = "DiscountCode";
        //bind the data to the list
        lstDiscountList.DataBind();
    }
}
