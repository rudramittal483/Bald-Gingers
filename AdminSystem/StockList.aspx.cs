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
            DisplayStocks();
        }

        // Check if a user is currently logged in
        if (Session["AnUser"] != null)
        {
            //create an instance of the stock user
            clsStockUser AnUser = new clsStockUser();
            //retrieve the logged-in user from the session
            AnUser = (clsStockUser)Session["AnUser"];

            // Update the Bootstrap badge label with the username securely
            lblUser.Text = AnUser.UserName;
        }
        else
        {
            // Fallback if accessed without logging in
            lblUser.Text = "Guest";
        }
    }

    void DisplayStocks()
    {
        clsStockCollection AllStocks = new clsStockCollection();
        lstStockList.Items.Clear();

        foreach (clsStock AStock in AllStocks.StockList)
        {
            
            string displayText = "Brand: " + AStock.Brand + " | Model: " + AStock.Model + " | Qty: " + AStock.Quantity + " | In Stock: " + AStock.InStock;
            ListItem newItem = new ListItem(displayText, AStock.LaptopId.ToString());
            lstStockList.Items.Add(newItem);
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate this is a new record
        Session["LaptopId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edit
        Int32 LaptopId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            LaptopId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["LaptopId"] = LaptopId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 LaptopId;

        if (lstStockList.SelectedIndex != -1)
        {
            LaptopId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["LaptopId"] = LaptopId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection AllStocks = new clsStockCollection();
        AllStocks.ReportByBrand(txtFilterBrand.Text);
        lstStockList.Items.Clear();

        foreach (clsStock AStock in AllStocks.StockList)
        {
            
            string displayText = "Brand: " + AStock.Brand + " | Model: " + AStock.Model + " | Qty: " + AStock.Quantity + " | In Stock: " + AStock.InStock;
            ListItem newItem = new ListItem(displayText, AStock.LaptopId.ToString());
            lstStockList.Items.Add(newItem);
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection AllStocks = new clsStockCollection();
        AllStocks.ReportByBrand("");
        txtFilterBrand.Text = "";
        lstStockList.Items.Clear();

        foreach (clsStock AStock in AllStocks.StockList)
        {
            
            string displayText = "Brand: " + AStock.Brand + " | Model: " + AStock.Model + " | Qty: " + AStock.Quantity + " | In Stock: " + AStock.InStock;
            ListItem newItem = new ListItem(displayText, AStock.LaptopId.ToString());
            lstStockList.Items.Add(newItem);
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}