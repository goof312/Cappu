using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using OfficeOpenXml;

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
                GridView1.DataSource = (order.ExecuteReader("SELECT  o.order_id, o.order_date, CAST(SUM(t.total) AS DECIMAL(10, 2)) as totalAmount FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id  GROUP BY o.order_id, o.order_date ORDER BY order_date DESC"));
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

                order.ExecuteNonQuery(string.Format("DELETE orders where order_id = '{0}'", orderID));
                // Your deletion logic here, e.g., order.DeleteOrder(orderID);

                // Rebind the GridView to reflect the updated data
                GridView1.DataSource = order.ExecuteReader("SELECT  o.order_id, o.order_date, CAST(SUM(t.total) AS DECIMAL(10, 2)) as totalAmount  FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id  GROUP BY o.order_id, o.order_date ORDER BY order_date DESC");

                GridView1.DataBind();



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (Order order = new Order())
            {
                // Retrieve the data from the database
                SqlDataReader reader = order.ExecuteReader("SELECT  o.order_id, o.order_date, CAST(SUM(t.total) AS DECIMAL(10, 2)) as totalAmount FROM orders as o INNER JOIN transactions as t ON o.order_id = t.order_id  GROUP BY o.order_id, o.order_date ORDER BY order_date DESC");
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                // Export the data to Excel
                ExportToExcel(reader, "InventoryInfo");
            }
        }
        private void ExportToExcel(SqlDataReader reader, string fileName)
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Write column headers
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                }

                // Write data rows
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col].ToString();
                    }
                }

                // Prepare the response for downloading
                Response.Clear();
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", $"attachment; filename={fileName}.xlsx");
                Response.BinaryWrite(excelPackage.GetAsByteArray());
                Response.End();
            }
        }
    }

      
}
