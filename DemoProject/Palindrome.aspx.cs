using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoProject
{
    public partial class Palindrome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate_Cick(object sender, EventArgs e)
        {
            Regex r = new Regex("^[A-Za-z ]+$");

            //Check not empty text
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg1()", true);    
            else
            {
                if (r.IsMatch(textBox1.Text) == true)
                {
                    if (is_palindrome(textBox1.Text))
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg2()", true);                           
                    else
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg3()", true);                           
                }
                else
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "msg4()", true);                                               
            }
        }

        public string quit_space(string word)
        {
            return word.Replace(" ", "");
        }


        public bool is_palindrome(string word)
        {
            //Delete the spaces in text
            word = quit_space(word);
            textBox1.Text = word;

            ArrayList array_word = new ArrayList(Convert.ToInt32(word.Length));
            ArrayList reverted_word = new ArrayList(Convert.ToInt32(word.Length));
            int i;

            for (i = 0; i < word.Length; i++)
                array_word.Add(word[i].ToString());

            //With Array.Reverse(array_word), i can reverse the text. But i use a for cicle for revert this text.

            for (i = word.Length - 1; i >= 0; i--)
                reverted_word.Add(word[i].ToString());

            for (i = 0; i < word.Length; i++)
            {
                if (!array_word[i].Equals(reverted_word[i]))
                    return false;
            }

            return true;
        }

    }
}