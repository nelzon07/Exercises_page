using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class Anagram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Validate_Cick(object sender, EventArgs e)
        {
            Regex r = new Regex("^[A-Za-z ]+$");

            if (string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox2.Text))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg1()", true);                
            else
            {
                if (r.IsMatch(TextBox1.Text) == true && r.IsMatch(TextBox2.Text) == true)
                {

                    if (is_anagram(this.TextBox1.Text, TextBox2.Text))
                          Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg2()", true);                                         
                    else
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg3()", true);                                                                 
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg4()", true);                        
                }
            }
        }

        private Boolean is_anagram(string word1, string word2)
        {
            int i;
            ArrayList array_word1 = new ArrayList(Convert.ToInt32(word1.Length));
            ArrayList array_word2 = new ArrayList(Convert.ToInt32(word2.Length));
            word1 = word1.ToLower();
            word2 = word2.ToLower();


            if (word1.Length != word2.Length)
                return false;

            for (i = 0; i < word1.Length; i++)
                array_word1.Add(word1[i].ToString());

            for (i = 0; i < word2.Length; i++)
                array_word2.Add(word2[i].ToString());

            foreach (string val in array_word1)
            {
                if (array_word2.Contains(val))
                    array_word2.Remove(val);
            }

            if (array_word2.Count == 0)
                return true;
            else
                return false;

        }
    }
}