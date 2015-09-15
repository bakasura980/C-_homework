namespace Homework13
{
    partial class UsersData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.AddNewData = new System.Windows.Forms.Button();
            this.EmptyFName = new System.Windows.Forms.Label();
            this.EmptyLName = new System.Windows.Forms.Label();
            this.Emptyemail = new System.Windows.Forms.Label();
            this.Success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.SystemColors.Control;
            this.FirstName.Location = new System.Drawing.Point(128, 74);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(145, 17);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "Input your first name :";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(129, 131);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(144, 17);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Input your last name :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(152, 193);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(121, 17);
            this.Email.TabIndex = 2;
            this.Email.Text = "Input your e-mail :";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(282, 74);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(249, 22);
            this.FirstNameTxt.TabIndex = 3;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(282, 131);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(249, 22);
            this.LastNameTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(282, 188);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(249, 22);
            this.EmailTxt.TabIndex = 5;
            // 
            // AddNewData
            // 
            this.AddNewData.Location = new System.Drawing.Point(297, 273);
            this.AddNewData.Name = "AddNewData";
            this.AddNewData.Size = new System.Drawing.Size(121, 51);
            this.AddNewData.TabIndex = 6;
            this.AddNewData.Text = "Add";
            this.AddNewData.UseVisualStyleBackColor = true;
            this.AddNewData.Click += new System.EventHandler(this.AddNewData_Click);
            // 
            // EmptyFName
            // 
            this.EmptyFName.AutoSize = true;
            this.EmptyFName.BackColor = System.Drawing.Color.Transparent;
            this.EmptyFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyFName.ForeColor = System.Drawing.Color.Red;
            this.EmptyFName.Location = new System.Drawing.Point(128, 103);
            this.EmptyFName.Name = "EmptyFName";
            this.EmptyFName.Size = new System.Drawing.Size(119, 17);
            this.EmptyFName.TabIndex = 7;
            this.EmptyFName.Text = "The field is empty";
            // 
            // EmptyLName
            // 
            this.EmptyLName.AutoSize = true;
            this.EmptyLName.BackColor = System.Drawing.Color.Transparent;
            this.EmptyLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyLName.ForeColor = System.Drawing.Color.Red;
            this.EmptyLName.Location = new System.Drawing.Point(129, 161);
            this.EmptyLName.Name = "EmptyLName";
            this.EmptyLName.Size = new System.Drawing.Size(119, 17);
            this.EmptyLName.TabIndex = 8;
            this.EmptyLName.Text = "The field is empty";
            // 
            // Emptyemail
            // 
            this.Emptyemail.AutoSize = true;
            this.Emptyemail.BackColor = System.Drawing.Color.Transparent;
            this.Emptyemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Emptyemail.ForeColor = System.Drawing.Color.Red;
            this.Emptyemail.Location = new System.Drawing.Point(152, 224);
            this.Emptyemail.Name = "Emptyemail";
            this.Emptyemail.Size = new System.Drawing.Size(119, 17);
            this.Emptyemail.TabIndex = 9;
            this.Emptyemail.Text = "The field is empty";
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.BackColor = System.Drawing.Color.Transparent;
            this.Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Success.ForeColor = System.Drawing.Color.ForestGreen;
            this.Success.Location = new System.Drawing.Point(225, 9);
            this.Success.MaximumSize = new System.Drawing.Size(300, 150);
            this.Success.Name = "Success";
            this.Success.Padding = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.Success.Size = new System.Drawing.Size(275, 55);
            this.Success.TabIndex = 10;
            this.Success.Text = "Sent successfully !";
            // 
            // UsersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework13.Properties.Resources.cars_photography_audi_s5_black_cars_2560x1600_wallpaper_www_wall321_com_46;
            this.ClientSize = new System.Drawing.Size(676, 358);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.Emptyemail);
            this.Controls.Add(this.EmptyLName);
            this.Controls.Add(this.EmptyFName);
            this.Controls.Add(this.AddNewData);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "UsersData";
            this.Text = "UsersData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Button AddNewData;
        private System.Windows.Forms.Label EmptyFName;
        private System.Windows.Forms.Label EmptyLName;
        private System.Windows.Forms.Label Emptyemail;
        private System.Windows.Forms.Label Success;
    }
}

