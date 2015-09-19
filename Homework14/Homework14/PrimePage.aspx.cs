using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Homework14
{
    public partial class PrimePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InfoInTxt_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (username.Text != string.Empty)
            {
                i++;
                UserRfield.Visible = false;
            }
            else
            {
                UserRfield.Visible = true;
            }
            if (password.Text != string.Empty)
            {
                PassRfield.Visible = false;
                i++;
            }
            else
            {
                PassRfield.Visible = true;
            }
            if (rpassword.Text != string.Empty)
            {
                if (password.Text == rpassword.Text)
                {
                    RpassRfield.Visible = false;
                    i++;
                }
                else
                {
                    RpassRfield.Text = "This repeat is false";
                    RpassRfield.Visible = true;
                }
            }
            else
            {
                RpassRfield.Visible = true;
            }
            if (age.Text != string.Empty)
            {
                int result;
                try
                {
                    if (!int.TryParse(age.Text, out result))
                    {
                        AgeRfield.Visible = true;
                        throw new AgeIsNotNumberException("This is not a number");
                    }
                    else
                    {
                        i++;
                        AgeRfield.Visible = false;
                    }
                }
                catch (AgeIsNotNumberException ex)
                {
                    AgeRfield.Text = ex.Message;
                }
            }
            else
            {
                AgeRfield.Visible = true;
            }
            if (email.Text != string.Empty)
            {
                if (email.Text.Contains("@"))
                {
                    MailRfield.Visible = false;
                    i++;
                }
                else
                {
                    MailRfield.Text = "This is an invalid email";
                    MailRfield.Visible = true;
                }
            }
            else
            {
                MailRfield.Visible = true;
            }
            if (i == 5)
            {
                using (StreamWriter write = new StreamWriter(Server.MapPath("DataInfo.txt"),true))
                {
                    write.WriteLine("Username: " + username.Text);
                    write.WriteLine("Password: " + password.Text);
                    write.WriteLine("Rpassword: " + rpassword.Text);
                    write.WriteLine("Age: " + age.Text);
                    write.WriteLine("Email: " + email.Text);
                    write.WriteLine();
                }
                username.Text = null;
                password.Text = null;
                rpassword.Text = null;
                age.Text = null;
                email.Text = null;
                Success.Visible = true;
            }
        }
    }
}