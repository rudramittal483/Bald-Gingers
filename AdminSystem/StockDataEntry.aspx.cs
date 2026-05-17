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
        //create a new instance of clsStock
        ClassLibrary.clsStock AStock = new ClassLibrary.clsStock();

        //capture the laptop id
        string LaptopId = txtLaptopId.Text;
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
            AStock.LaptopId = Convert.ToInt32(txtLaptopId.Text);
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

            //store the object in the session
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
        //create instance of the stock class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 LaptopId;
        //create a boolean variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        LaptopId = Convert.ToInt32(txtLaptopId.Text);
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
    }
}