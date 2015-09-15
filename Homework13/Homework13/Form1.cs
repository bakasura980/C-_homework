using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework13
{
    public partial class UsersData : Form
    {
 
        public UsersData()
        {
            InitializeComponent();
            EmptyFName.Visible = false;
            EmptyLName.Visible = false;
            Emptyemail.Visible = false;
            Success.Visible = false;

        }

        private void AddNewData_Click(object sender, EventArgs e)
        {
            Success.Visible = false;
                if (FirstNameTxt.Text == string.Empty)
                {
                    EmptyFName.Visible = true;
                }
                else
                {
                    EmptyFName.Visible = false;
                }
                if (LastNameTxt.Text == string.Empty)
                {
                    EmptyLName.Visible = true;
                }
                else
                {
                    EmptyLName.Visible = false;
                }
                if (EmailTxt.Text == string.Empty)
                {
                    Emptyemail.Visible = true;
                }
                else
                {
                    Emptyemail.Visible = false;
                }
                if (FirstNameTxt.Text != string.Empty && LastNameTxt.Text != string.Empty
                    && EmailTxt.Text != string.Empty)
                {
                    using (StreamWriter writeinfile = new StreamWriter("Formuserdata.txt", true))
                    {
                        writeinfile.WriteLine("First name : " + FirstNameTxt.Text);
                        writeinfile.WriteLine("Last name : " + LastNameTxt.Text);
                        writeinfile.WriteLine("Email : " + EmailTxt.Text);
                        writeinfile.WriteLine();
                    }
                    Success.Visible = true;
                    FirstNameTxt.Text = null;
                    LastNameTxt.Text = null;
                    EmailTxt.Text = null;
                }
        }
    }
}   

