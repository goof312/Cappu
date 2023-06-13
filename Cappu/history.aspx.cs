using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Cappu
{
  

    public partial class history : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            using (Order order = new Order())
            {
                SqlDataReader reader = order.ExecuteReader("SELECT order_id FROM orders WHERE order_date >= DATEADD(day, -2, CONVERT(date, GETDATE())) ORDER BY order_date DESC;");
                try
                {
                    while (reader.Read())
                    {
                        OrderItem item = new OrderItem();
                        item.OrderID = reader.GetString(0);
                        orderItems.Add(item);
                    }
                }
                catch
                {
                    Response.Write("<script>alert('Reader Problems');</script>");
                }
            }

            gridView1.DataSource = orderItems;
            gridView1.DataBind();
        }

        public class OrderItem
        {
            public string OrderID { get; set; }
        }

        protected void btnButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pos.aspx");
        }
    }
}