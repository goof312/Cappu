using System;
using System.Web;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Cappu
{
    public partial class Pos : System.Web.UI.Page
    {
        public class GridData
        {
            public string Key { get; set; }
            public double Quantity { get; set; }
            public double Total { get; set; }
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
                double total = double.Parse(hiddenTotal.Value);

                Dictionary<string, double[]> data = new Dictionary<string, double[]>();

                // Convert dictionary to JSON string
                string jsonData = JsonConvert.SerializeObject(data);

                // Store the JSON data in the hidden field
                hiddenData.Value = jsonData;

                addTOgridview(data);
            }
        }

        protected void K1_Click(object sender, EventArgs e)
        {
            AddTotal(39);

            Dictionary<string, double[]> data = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(hiddenData.Value);

            if (data.ContainsKey("k1"))
            {
                data["k1"][0] = data["k1"][0] + 1;
                data["k1"][1] = data["k1"][1] + 39;
            }
            else
            {
                data["k1"] = new double[] { 1, 39 }; // Add a new entry
            }

            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            addTOgridview(data);
        }

        protected void K2_Click(object sender, EventArgs e)
        {
            AddTotal(49);
            Dictionary<string, double[]> data = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(hiddenData.Value);
            if (data.ContainsKey("k2"))
            {
                data["k2"][0] = data["k2"][0] + 1;
                data["k2"][1] = data["k2"][1] + 49;
            }
            else
            {
                data["k2"] = new double[] { 1, 49 }; // Add a new entry
            }

            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            addTOgridview(data);
        }

        protected void K3_Click(object sender, EventArgs e)
        {
            AddTotal(59);
        }

        protected void K4_Click(object sender, EventArgs e)
        {
            AddTotal(59);
            Dictionary<string, double[]> data = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(hiddenData.Value);
            if (data.ContainsKey("k4"))
            {
                data["k4"][0] = data["k4"][0] + 1;
                data["k4"][1] = data["k4"][1] + 59;
            }
            else
            {
                data["k4"] = new double[] { 1, 59 }; // Add a new entry
            }

            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            addTOgridview(data);
        }

        protected void K5_Click(object sender, EventArgs e)
        {
            AddTotal(59);
            Dictionary<string, double[]> data = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(hiddenData.Value);
            if (data.ContainsKey("k5"))
            {
                data["k5"][0] = data["k5"][0] + 1;
                data["k5"][1] = data["k5"][1] + 59;
            }
            else
            {
                data["k5"] = new double[] { 1, 59 }; // Add a new entry
            }

            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            addTOgridview(data);
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

        protected void K11_Click(object sender, EventArgs e) // S1
        {
            AddTotal(45);
            Dictionary<string, double[]> data = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(hiddenData.Value);
            if (data.ContainsKey("S1"))
            {
                data["S1"][0] = data["S1"][0] + 1;
                data["S1"][1] = data["S1"][1] + 45;
            }
            else
            {
                data["S1"] = new double[] { 1, 45 }; // Add a new entry
            }

            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            addTOgridview(data);
        }

        protected void K12_Click(object sender, EventArgs e) // S2
        {
            AddTotal(55);
            Dictionary<string, double[]> data = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(hiddenData.Value);
            if (data.ContainsKey("S2"))
            {
                data["S2"][0] = data["S2"][0] + 1;
                data["S2"][1] = data["S2"][1] + 49;
            }
            else
            {
                data["S2"] = new double[] { 1, 49 }; // Add a new entry
            }

            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;
            addTOgridview(data);
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            cancel();
        }

        public void cancel()
        {
            hiddenTotal.Value = "0";
            inputDisabledEx2.Text = "TOTAL: " + hiddenTotal.Value;

            Dictionary<string, double[]> data = new Dictionary<string, double[]>();
            string jsonData = JsonConvert.SerializeObject(data);
            hiddenData.Value = jsonData;

            var dataSource = data.Select(kvp => new GridData { Key = kvp.Key, Quantity = kvp.Value[0], Total = kvp.Value[1] });
            gridView.DataSource = dataSource;
            gridView.DataBind();
        }

        public void AddTotal(double number)
        {
            double total = double.Parse(hiddenTotal.Value);

            // Update the total value
            total += number;

            // Store the updated total value in the hidden field
            hiddenTotal.Value = total.ToString();

            // Update the displayed total value
            inputDisabledEx2.Text = "TOTAL: " + total.ToString("N2");
        }

        public void addTOgridview(Dictionary<string, double[]> data = null)
        {
            if (data != null)
            {
                var dataSource = data.Select(kvp => new GridData { Key = kvp.Key, Quantity = (int)kvp.Value[0], Total = (int)kvp.Value[1] });
                gridView.DataSource = dataSource;
                gridView.DataBind();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Dictionary<string, double[]> data = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(hiddenData.Value);
            randomGenerator rand = new randomGenerator();

            if (data.Count == 0)
            {
                Response.Write("<script>alert('No values to submit');</script>");
            }
            else
            {
                string randum = rand.GenerateRandomOrderId();

                using (Order order = new Order())
                {
                    string query = string.Format("INSERT INTO orders values('{0}','{1}')", randum, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    order.ExecuteNonQuery(query);
                }

                foreach (KeyValuePair<string, double[]> pair in data)
                {
                    string proName = pair.Key;
                    double[] value = pair.Value;
                    int quantity = (int)value[0];
                    int total = (int)value[1];

                    using (Order order = new Order())
                    {
                        string querytrans = string.Format("INSERT INTO transactions VALUES('{0}','{1}',{2},{3})", randum, proName, quantity, total);
                        order.ExecuteNonQuery(querytrans);
                    }
                }
            }

            cancel();
        }

        protected void History_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/history.aspx");
        }
    }
}
