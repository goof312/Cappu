using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
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

                Dictionary<string, int[]> data = new Dictionary<string, int[]>();
                

                // Convert dictionary to JSON string
                string jsonData = JsonConvert.SerializeObject(data);

                // Store the JSON data in the hidden field
                hiddenData.Value = jsonData;

                var dataSource = data.Select(kvp => new GridData { Key = kvp.Key, Quantity = kvp.Value[0], Total = kvp.Value[1] });

                gridView.DataSource = dataSource;
                gridView.DataBind();
            }
        }

        protected void K1_Click(object sender, EventArgs e)
        {
            AddTotal(39);

            Dictionary<string, int[]> data = JsonConvert.DeserializeObject<Dictionary<string, int[]>>(hiddenData.Value);


            if (data.ContainsKey("k1"))
            {
                data["k1"][0] = data["k1"][0] + 1;
                data["k1"][1] = data["k1"][1] + 39;
            }

            else
            {
                data["k1"] = new int[] { 1, 39 }; // Add a new entry
            }
            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            var dataSource = data.Select(kvp => new GridData { Key = kvp.Key, Quantity = kvp.Value[0], Total = kvp.Value[1] });
            gridView.DataSource = dataSource;
            gridView.DataBind();
        }

       




        protected void K2_Click(object sender, EventArgs e)
        {
            AddTotal(49);
            Dictionary<string, int[]> data = JsonConvert.DeserializeObject<Dictionary<string, int[]>>(hiddenData.Value);
            if (data.ContainsKey("k2"))
            {
                data["k2"][0] = data["k2"][0] + 1;
                data["k2"][1] = data["k2"][1] + 49;
            }

            else
            {
                data["k2"] = new int[] { 1, 49 }; // Add a new entry
            }


            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            var dataSource = data.Select(kvp => new GridData { Key = kvp.Key, Quantity = kvp.Value[0], Total = kvp.Value[1] });
            gridView.DataSource = dataSource;
            gridView.DataBind();

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

            Dictionary<string, int[]> data = new Dictionary<string, int[]>();
            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;


            var dataSource = data.Select(kvp => new GridData { Key = kvp.Key, Quantity = kvp.Value[0], Total = kvp.Value[1] });
            gridView.DataSource = dataSource;
            gridView.DataBind();
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