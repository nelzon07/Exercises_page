using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoProject
{
    public partial class Odd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate_Cick(object sender, EventArgs e)
        {

            int num1;
            if (int.TryParse(textBox1.Text, out num1))
            {

                if (textBox1.Text.Length <= 3)
                {
                    listBox1.Items.Clear();
                    for (int i = 1; i <= Convert.ToInt32(num1); i++)
                    {
                        if (i%2 != 0)
                            listBox1.Items.Add(i.ToString());
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg1()", true);
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg1()", true);
            }
        }
    }
}