using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cappu
{
    public partial class CompareSales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }


        protected void information_show(object sender, EventArgs e)
        {

            
            DateTime date1 = DateTime.Parse(TextBox1.Text);
            DateTime date2 = DateTime.Parse(TextBox2.Text);

            Label1.Text = string.Format("Total of Date: {0}", TextBox1.Text);
            Label2.Text = string.Format("Total of Date: {0}", TextBox2.Text);
            string query = queryMe(date1.ToString("MM-dd-yy"));
            show_data(query, GridView1);
            query = queryMe(date2.ToString("MM-dd-yy"));
            show_data(query, GridView2);

            query = string.Format("SELECT SUM(total) as TotalSum FROM orders INNER JOIN transactions ON orders.order_id = transactions.order_id WHERE order_date = '{0}'", date1.ToString("MM-dd-yy"));
            total(query, TextBox3);
            query= string.Format("SELECT SUM(total) as TotalSum FROM orders INNER JOIN transactions ON orders.order_id = transactions.order_id WHERE order_date = '{0}'", date2.ToString("MM-dd-yy"));
            total(query, TextBox4);


        }
        protected string queryMe(string change)
        {
            return string.Format("SELECT t.order_id, o.order_date, t.product_name, t.quantity, t.total " +
                       "FROM orders AS o " +
                       "INNER JOIN transactions AS t ON o.order_id = t.order_id " +
                       "WHERE order_date = '{0}' " +
                       "ORDER BY o.order_date DESC", change);
        }
        protected void show_data(string query, GridView gridview)
        {
            using (Order order = new Order())
            {


                gridview.DataSource = (order.ExecuteReader(query));
                gridview.DataBind();


            }
        }

        protected void total(string query, TextBox textbox)
        {
            using (Order order = new Order())
            {
                SqlDataReader reader = order.ExecuteReader(query);
                try
                {
                    if (reader.Read())
                    {
                        decimal totalSum = Convert.ToDecimal(reader["TotalSum"]);
                        textbox.Text = totalSum.ToString();
                    }
                }
                catch
                {
                    textbox.Text = "No Sales Yet";
                }

            }
            
        }
    }
}