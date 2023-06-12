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
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            information_show();
            compute_sum();
            if (!IsPostBack)
            {
                TextBox2.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }


        }

        protected void information_show()
        {
            using (Order order = new Order())
            {
                GridView2.DataSource = (order.ExecuteReader("SELECT  t.order_id, o.order_date,t.product_name, t.quantity, t.total FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id WHERE order_date >= CONVERT(date, GETDATE()) ORDER BY order_date DESC"));
                GridView2.DataBind();
            }
        }
        protected void search(object sender, EventArgs e)
        {
            using(Order order = new Order())
            {
                string query = string.Format("SELECT t.order_id, o.order_date, t.product_name, t.quantity, t.total " +
                       "FROM orders AS o " +
                       "INNER JOIN transactions AS t ON o.order_id = t.order_id " +
                       "WHERE order_date = '{0}' " +
                       "ORDER BY o.order_date DESC", TextBox2.Text);
                GridView2.DataSource = (order.ExecuteReader(query));
                GridView2.DataBind();

           
                SqlDataReader reader = order.ExecuteReader(string.Format("SELECT SUM(total) as TotalSum FROM orders INNER JOIN transactions ON orders.order_id = transactions.order_id WHERE order_date = '{0}'", TextBox2.Text));
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