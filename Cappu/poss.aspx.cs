using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cappu
{
    public partial class poss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (Order order = new Order())
            {
                ProductsRepeater.DataSource = (order.ExecuteReader("SELECT product_id, product_name, price FROM products"));
                ProductsRepeater.DataBind();
            }
            if (!IsPostBack)
            {
                // Initialize the clickCounts array with 0 for each button
                int buttonCount = GetButtonCount(); // Replace with your logic to get the total button count
                int [] clickCounts = new int[buttonCount];
                ResultsRepeater.DataSource = clickCounts;
                ResultsRepeater.DataBind();
            }
        }

        protected void ProductsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Button button = (Button)e.Item.FindControl("Button1");
                button.Attributes.Add("onclick", "countButtonClick(" + e.Item.ItemIndex + "); return false;");
            }
        }
        protected int GetButtonCount()
        {
            // Replace this with your logic to get the button count from your data source
            // For demonstration purposes, we are returning a static value of 3
            return 9;
        }


    }
}