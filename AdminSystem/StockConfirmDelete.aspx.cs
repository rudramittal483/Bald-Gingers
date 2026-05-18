using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 LaptopId;

    protected void Page_Load(object sender, EventArgs e)
    {
        LaptopId = Convert.ToInt32(Session["LaptopId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockCollection = new clsStockCollection();
        StockCollection.ThisStock.Find(LaptopId);
        StockCollection.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}