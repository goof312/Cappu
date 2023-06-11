using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cappu
{
    public partial class Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            information_show();
        }

        protected void information_show()
        {
            using (Order order = new Order())
            {
                GridView1.DataSource = (order.ExecuteReader("SELECT  o.order_id, o.order_date,SUM(t.total) as totalAmount FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id  GROUP BY o.order_id, o.order_date ORDER BY order_date DESC"));
                GridView1.DataBind();
       

            }
        }

       
    }
}