using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 LaptopId;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //get the number of the stock to be processed
        LaptopId = Convert.ToInt32(Session["LaptopId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (LaptopId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }
    void DisplayStock()
    {
        //create an instance of the stock class
        clsStockCollection StockCollection = new clsStockCollection();
        //find the record to update
        StockCollection.ThisStock.Find(LaptopId);
        //display the data for this record
        txtBrand.Text = StockCollection.ThisStock.Brand;
        txtModelName.Text = StockCollection.ThisStock.Model;
        txtDateAdded.Text = StockCollection.ThisStock.DateAdded.ToString();
        txtPrice.Text = StockCollection.ThisStock.Price.ToString();
        txtDiscountId.Text = StockCollection.ThisStock.DiscountId.ToString();
        txtQuantity.Text = StockCollection.ThisStock.Quantity.ToString();
        chkInStock.Checked = StockCollection.ThisStock.InStock;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        ClassLibrary.clsStock AStock = new ClassLibrary.clsStock();

        //capture the discount id
        string DiscountId = txtDiscountId.Text;
        //capture the brand
        string Brand = txtBrand.Text;
        //capture the model name
        string ModelName = txtModelName.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //capture the in stock status
        string InStock = chkInStock.Checked.ToString();
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(ModelName, Brand, Price, DateAdded, DiscountId, Quantity);
        if (Error == "")
        {

            //get the data entered by the user
            AStock.LaptopId = LaptopId;
            if (txtDiscountId.Text.Length == 0)
            {
                // Assign a default value that represents "no discount" or "null" in your system
                AStock.DiscountId = 0;
            }
            else
            {
                // It's not empty, so it's safe(r) to attempt conversion
                AStock.DiscountId = Convert.ToInt32(txtDiscountId.Text);
            }
            AStock.Brand = txtBrand.Text;
            AStock.Model = txtModelName.Text;
            AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            AStock.Price = Convert.ToDouble(txtPrice.Text);
            AStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            AStock.InStock = chkInStock.Checked;
            //create a new instance of the stock collection
            ClassLibrary.clsStockCollection StockList = new ClassLibrary.clsStockCollection();

            //if this is a new record i.e. LaptopId = -1 then add the data
            if (LaptopId == -1)
            {
                StockList.ThisStock = AStock;
                StockList.Add();
            }
            else //otherwise it must be an update
            {
                //find the record to update
                StockList.ThisStock.Find(LaptopId);
                //set the ThisStock property to the new data
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
            Session["AStock"] = AStock;
            //navigate to the view page
            Response.Redirect("StockViewer.aspx");
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
        if (txtLaptopId.Text.Length > 0)
        {
            //create instance of the stock class
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the find operation
            Boolean Found = false;

            //get the primary key entered by the user
            Int32 LaptopId = Convert.ToInt32(txtLaptopId.Text);

            //find the record
            Found = AStock.Find(LaptopId);

            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtBrand.Text = AStock.Brand;
                txtModelName.Text = AStock.Model;
                txtDateAdded.Text = AStock.DateAdded.ToString();
                txtPrice.Text = AStock.Price.ToString();
                txtDiscountId.Text = AStock.DiscountId.ToString();
                txtQuantity.Text = AStock.Quantity.ToString();
                chkInStock.Checked = AStock.InStock;
            }
            else
            {
                // Optional: Tell the user the ID wasn't found in the database
                lblError.Text = "Laptop ID not found.";
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect to the Stock List page
        Response.Redirect("StockList.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Main Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}


