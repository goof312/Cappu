using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Diagnostics;
namespace Cappu
{
    public partial class Pos : System.Web.UI.Page
    {

        public class GridData
        {
            public string Key { get; set; }
            public int Quantity { get; set; }
            public int Total { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the hidden field contains a value
                if (string.IsNullOrEmpty(hiddenTotal.Value) || hiddenTotal.Value == "0")
                {
                    // Initialize the total value
                    hiddenTotal.Value = "0";
                }

                // Retrieve the total value from the hidden field
                int total = int.Parse(hiddenTotal.Value);

                Dictionary<string, int[]> data;

                if (Cache["MyData"] != null)
                {
                    data = (Dictionary<string, int[]>)Cache["MyData"];
                }
                else
                {
                    // Retrieve the data from the persistent storage (e.g., database)
                    data = FetchData();

                    // Cache the data for future use
                    Cache["MyData"] = data;
                }

                var dataSource = data.Select(kvp => new GridData { Key = kvp.Key, Quantity = kvp.Value[0], Total = kvp.Value[1] });

                gridView.DataSource = dataSource;
                gridView.DataBind();
            }
        }

        protected void K1_Click(object sender, EventArgs e)
        {
            AddTotal(39);
            FetchData();
                


          
        }

        private Dictionary<string, int[]> FetchData(string  key ,int count, int price)
        {
            // Implement the logic to fetch the data from the persistent storage or any other source
            // and return it as a dictionary

            // Example:
            Dictionary<string, int[]> data = new Dictionary<string, int[]>();
            

            return data;
        }

        private Dictionary<string, int[]> FetchData()
        {
            // Implement the logic to fetch the data from the persistent storage or any other source
            // and return it as a dictionary

            // Example:
            Dictionary<string, int[]> data = new Dictionary<string, int[]>();
            data.Add("k1", new int[] { 1, 32 });

            return data;
        }





        protected void K2_Click(object sender, EventArgs e)
        {
            AddTotal(39);


        }

        protected void K3_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K4_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K5_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K6_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K7_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K8_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K9_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K10_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K11_Click(object sender, EventArgs e)
        {
            AddTotal(45);
        }

        protected void K12_Click(object sender, EventArgs e)
        {
            AddTotal(55);
        }




        protected void Cancel_Click(object sender, EventArgs e)
        {
            hiddenTotal.Value = "0";
            inputDisabledEx2.Text = "Total: " + hiddenTotal.Value;
        }

















        public void AddTotal(int number)
        {
            int total = int.Parse(hiddenTotal.Value);

            // Update the total value
            total += number;

            // Store the updated total value in the hidden field
            hiddenTotal.Value = total.ToString();

            // Update the displayed total value
            inputDisabledEx2.Text = "Total: " + total.ToString();
        }

       
    }

 
         

}