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
        //get the data entered by the user
        AStock.LaptopId = Convert.ToInt32(txtLaptopId.Text);
        AStock.Brand = txtBrand.Text;
        AStock.Model = txtModelName.Text;
        AStock.DateAdded = Convert.ToDateTime(txtDataAdded.Text);
        AStock.Price = Convert.ToDouble(txtPrice.Text);
        AStock.InStock = chkInStock.Checked;

        //store the object in the session
        Session["AStock"] = AStock;

        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }
}