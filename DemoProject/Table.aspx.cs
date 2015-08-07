using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoProject
{
    public partial class Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i <= 12; i++)
                {
                    comboBox1.Items.Add(i.ToString());
                }

                comboBox1.Text = "1";
            }
        }

        protected void Validate_Cick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 12; i++)
                listBox1.Items.Add(comboBox1.Text + "x" + i + "=" + Convert.ToInt16(comboBox1.Text) * i);

        }
    }
}