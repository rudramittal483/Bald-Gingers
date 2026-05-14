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

    }

    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection AllStocks = new clsStockCollection();
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = AllStocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "LaptopId";
        //set the data field to display
        lstStockList.DataTextField = "Model";
        //bind the data to the list
        lstStockList.DataBind();
    }
}