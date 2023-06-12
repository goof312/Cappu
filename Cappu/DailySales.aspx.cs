using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Cappu
{
    public partial class DailySales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            information_show();
            compute_sum();
        }

        protected void information_show()
        {
            using (Order order = new Order())
            {
                GridView2.DataSource = (order.ExecuteReader("SELECT  t.order_id, o.order_date,t.product_name, t.quantity, t.total FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id WHERE order_date >= CONVERT(date, GETDATE()) ORDER BY order_date DESC"));
                GridView2.DataBind();
            }
        }

        protected void compute_sum()
        {
            using (Order order = new Order())
            {
                SqlDataReader reader = order.ExecuteReader("SELECT SUM(total) as TotalSum FROM orders INNER JOIN transactions ON orders.order_id = transactions.order_id WHERE order_date >= CONVERT(date, GETDATE())");
                try
                {
                    if (reader.Read())
                    {
                        decimal totalSum = Convert.ToDecimal(reader["TotalSum"]);
                        TextBox1.Text = totalSum.ToString();
                    }
                }
                catch
                {
                    TextBox1.Text = "No Sales Yet";
                }
               
            }
        }
    }
}