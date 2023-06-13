using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cappu
{
    public partial class Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
               
                using (Order order = new Order())
                {
                    information_show();
                }
            }
            SetDeleteButtonVisibility();

        }

        protected void information_show()
        {
            using (Order order = new Order())
            {
                GridView1.DataSource = (order.ExecuteReader("SELECT  o.order_id, o.order_date,SUM(t.total) as totalAmount FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id  GROUP BY o.order_id, o.order_date ORDER BY order_date DESC"));
                GridView1.DataBind();
       

            }
        }

 
        private void SetDeleteButtonVisibility()
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                Button btnDelete = (Button)row.FindControl("btnDelete");
                btnDelete.Visible = true; // Set visibility as needed
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            // Retrieve the order ID from the CommandArgument of the clicked button
            Button btnDelete = (Button)sender;
            string orderID = btnDelete.CommandArgument;

            using (Order order = new Order())
            {

                order.ExecuteNonQuery("DELETE orders where order_id = " + orderID);
                // Your deletion logic here, e.g., order.DeleteOrder(orderID);

                // Rebind the GridView to reflect the updated data
                GridView1.DataSource = order.ExecuteReader("SELECT  o.order_id, o.order_date,SUM(t.total) as totalAmount FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id  GROUP BY o.order_id, o.order_date ORDER BY order_date DESC");
                GridView1.DataBind();



            }

        }
    }
}