using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Cappu
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Dictionary<string, string[]> log_info = new Dictionary<string, string[]>();

            using (Order order = new Order())
            {
                SqlDataReader reader = order.ExecuteReader("Select * from UserlogIn");
                

                try
                {
                    while (reader.Read())
                    {
                        string username = reader.GetString(0).ToUpper(); // get the email

                        string password = reader.GetString(1);
                        string position = reader.GetString(2);

                        string[] infoArray = new string[2];
                        infoArray[0] = password;
                        infoArray[1] = position.ToUpper();

                        log_info.Add(username, infoArray);
                    }
                }
                catch
                {
                    Response.Write("<scritp>alert('Reader Problems');</script>");
                }
            }

          



            Decryptiopn des = new Decryptiopn();
            string userName = txtUsername.Text.ToUpper();
            string userPassword = txtPassword.Text;


            System.Diagnostics.Debug.WriteLine(userPassword);


            if (log_info.ContainsKey(userName))
            {
                if (userPassword == des.DecyptionDES(log_info[userName][0]))
                {
                    if (log_info[userName][1] == "ADMIN")
                    {
                        Response.Redirect("~/Inventory.aspx");
                    }
                    else if (log_info[userName][1] == "POS_USER")
                    {
                        Response.Redirect("~/Pos.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Wrong password');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Username and Password is incorrect');</script>");
            }
        }
    }
}