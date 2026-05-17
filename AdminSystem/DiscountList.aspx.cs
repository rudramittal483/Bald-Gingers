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
}
