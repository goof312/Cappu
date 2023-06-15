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

        public string query;
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            query = "SELECT CAST(SUM(total) AS DECIMAL(10, 2)) as TotalSum FROM orders INNER JOIN transactions ON orders.order_id = transactions.order_id WHERE order_date >= CONVERT(date, GETDATE())";
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            information_show();
            compute_sum(query);
            if (!IsPostBack)
            {
                TextBox2.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }


        }

        protected void information_show()
        {
            using (Order order = new Order())
            {
         
                GridView2.DataSource = (order.ExecuteReader("SELECT  t.order_id, o.order_date,t.product_name, t.quantity, CAST(t.total AS DECIMAL(10, 2)) as total FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id WHERE order_date >= CONVERT(date, GETDATE()) ORDER BY order_date DESC"));
                GridView2.DataBind();
            }
        }
        protected void search(object sender, EventArgs e)
        {

            date = DateTime.Parse(TextBox2.Text).ToString("MM-dd-yy") + " 23:59:59";
            using (Order order = new Order())
            {

               
                query = string.Format("SELECT t.order_id, o.order_date, t.product_name, t.quantity, CAST(t.total AS DECIMAL(10, 2)) as total " +
                       "FROM orders AS o " +
                       "INNER JOIN transactions AS t ON o.order_id = t.order_id " +
                       "WHERE order_date >= '{0}' and order_date <= '{1}'" +
                       "ORDER BY o.order_date DESC", TextBox2.Text, date);
                GridView2.DataSource = (order.ExecuteReader(query));
                GridView2.DataBind();

            }
            query = string.Format("SELECT  CAST(SUM(total) AS DECIMAL(10, 2)) as TotalSum  FROM orders INNER JOIN transactions ON orders.order_id = transactions.order_id WHERE order_date >= '{0}' and order_date <= '{1}'", TextBox2.Text,date);
            compute_sum(query);

        }

        protected void compute_sum(string query)
        {
            using (Order order = new Order())
            {
                SqlDataReader reader = order.ExecuteReader(query);
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

        

        protected void filter(object sender, EventArgs e)
        {
            int value = int.Parse(filterSearch.SelectedValue) * -1;
            string date = (DateTime.Now.AddDays(value)).ToString("MM-dd-yy");
            string today = (DateTime.Now).ToString("MM-dd-yy");

            using (Order order = new Order())
            {
                GridView2.DataSource = order.ExecuteReader(string.Format("SELECT t.order_id, o.order_date,t.product_name, t.quantity, CAST(t.total AS DECIMAL(10, 2)) as total FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id WHERE o.order_date >= '{0}' AND o.order_date <= '{1}' ORDER BY o.order_date DESC", date, today ));
                GridView2.DataBind();
            }
            query = string.Format("SELECT CAST(SUM(total) AS DECIMAL(10, 2)) as TotalSum FROM orders INNER JOIN transactions ON orders.order_id = transactions.order_id WHERE  order_date >= '{0}' AND order_date <= '{1}'", date, today);
            compute_sum(query);
        }
    }
}