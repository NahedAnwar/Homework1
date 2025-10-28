namespace myprpject
{
    partial class Form1
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
            this.Ename = new System.Windows.Forms.Label();
            this.Eemail = new System.Windows.Forms.Label();
            this.Epassword = new System.Windows.Forms.Label();
            this.Eresult = new System.Windows.Forms.Label();
            this.tename = new System.Windows.Forms.TextBox();
            this.teemail = new System.Windows.Forms.TextBox();
            this.tepassword = new System.Windows.Forms.TextBox();
            this.rmale = new System.Windows.Forms.RadioButton();
            this.rfemale = new System.Windows.Forms.RadioButton();
            this.tegender = new System.Windows.Forms.GroupBox();
            this.cocountry = new System.Windows.Forms.ComboBox();
            this.ecountry = new System.Windows.Forms.Label();
            this.esubmit = new System.Windows.Forms.Button();
            this.ereset = new System.Windows.Forms.Button();
            this.tegender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ename
            // 
            this.Ename.AutoSize = true;
            this.Ename.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ename.Location = new System.Drawing.Point(-2, 20);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(50, 19);
            this.Ename.TabIndex = 0;
            this.Ename.Text = "Name";
            this.Ename.Click += new System.EventHandler(this.label1_Click);
            // 
            // Eemail
            // 
            this.Eemail.AutoSize = true;
            this.Eemail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Eemail.Location = new System.Drawing.Point(-2, 52);
            this.Eemail.Name = "Eemail";
            this.Eemail.Size = new System.Drawing.Size(48, 19);
            this.Eemail.TabIndex = 1;
            this.Eemail.Text = "Email";
            // 
            // Epassword
            // 
            this.Epassword.AutoSize = true;
            this.Epassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Epassword.Location = new System.Drawing.Point(-2, 90);
            this.Epassword.Name = "Epassword";
            this.Epassword.Size = new System.Drawing.Size(76, 19);
            this.Epassword.TabIndex = 2;
            this.Epassword.Text = "Password";
            // 
            // Eresult
            // 
            this.Eresult.AutoSize = true;
            this.Eresult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Eresult.Location = new System.Drawing.Point(395, 74);
            this.Eresult.Name = "Eresult";
            this.Eresult.Size = new System.Drawing.Size(139, 19);
            this.Eresult.TabIndex = 5;
            this.Eresult.Text = "empty,show result";
            this.Eresult.Click += new System.EventHandler(this.Eresult_Click);
            // 
            // tename
            // 
            this.tename.Location = new System.Drawing.Point(92, 20);
            this.tename.Name = "tename";
            this.tename.Size = new System.Drawing.Size(200, 27);
            this.tename.TabIndex = 6;
            // 
            // teemail
            // 
            this.teemail.Location = new System.Drawing.Point(92, 53);
            this.teemail.Name = "teemail";
            this.teemail.Size = new System.Drawing.Size(200, 27);
            this.teemail.TabIndex = 7;
            // 
            // tepassword
            // 
            this.tepassword.Location = new System.Drawing.Point(92, 87);
            this.tepassword.Name = "tepassword";
            this.tepassword.Size = new System.Drawing.Size(200, 27);
            this.tepassword.TabIndex = 8;
            // 
            // rmale
            // 
            this.rmale.AutoSize = true;
            this.rmale.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rmale.Location = new System.Drawing.Point(6, 26);
            this.rmale.Name = "rmale";
            this.rmale.Size = new System.Drawing.Size(68, 23);
            this.rmale.TabIndex = 9;
            this.rmale.TabStop = true;
            this.rmale.Text = "male";
            this.rmale.UseVisualStyleBackColor = false;
            // 
            // rfemale
            // 
            this.rfemale.AutoSize = true;
            this.rfemale.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rfemale.Location = new System.Drawing.Point(6, 55);
            this.rfemale.Name = "rfemale";
            this.rfemale.Size = new System.Drawing.Size(81, 23);
            this.rfemale.TabIndex = 10;
            this.rfemale.TabStop = true;
            this.rfemale.Text = "female";
            this.rfemale.UseVisualStyleBackColor = false;
            // 
            // tegender
            // 
            this.tegender.BackColor = System.Drawing.SystemColors.Control;
            this.tegender.Controls.Add(this.rmale);
            this.tegender.Controls.Add(this.rfemale);
            this.tegender.Location = new System.Drawing.Point(2, 120);
            this.tegender.Name = "tegender";
            this.tegender.Size = new System.Drawing.Size(118, 86);
            this.tegender.TabIndex = 11;
            this.tegender.TabStop = false;
            this.tegender.Text = "Gender";
            this.tegender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cocountry
            // 
            this.cocountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cocountry.FormattingEnabled = true;
            this.cocountry.Location = new System.Drawing.Point(121, 230);
            this.cocountry.Name = "cocountry";
            this.cocountry.Size = new System.Drawing.Size(121, 27);
            this.cocountry.TabIndex = 12;
            // 
            // ecountry
            // 
            this.ecountry.AutoSize = true;
            this.ecountry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ecountry.Location = new System.Drawing.Point(23, 238);
            this.ecountry.Name = "ecountry";
            this.ecountry.Size = new System.Drawing.Size(65, 19);
            this.ecountry.TabIndex = 13;
            this.ecountry.Text = "Country";
            // 
            // esubmit
            // 
            this.esubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.esubmit.Location = new System.Drawing.Point(203, 356);
            this.esubmit.Name = "esubmit";
            this.esubmit.Size = new System.Drawing.Size(75, 34);
            this.esubmit.TabIndex = 14;
            this.esubmit.Text = "Resgister";
            this.esubmit.UseVisualStyleBackColor = false;
            this.esubmit.Click += new System.EventHandler(this.esubmit_Click);
            // 
            // ereset
            // 
            this.ereset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ereset.Location = new System.Drawing.Point(370, 356);
            this.ereset.Name = "ereset";
            this.ereset.Size = new System.Drawing.Size(196, 88);
            this.ereset.TabIndex = 15;
            this.ereset.Text = "Reset";
            this.ereset.UseVisualStyleBackColor = false;
            this.ereset.Click += new System.EventHandler(this.ereset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.ereset);
            this.Controls.Add(this.esubmit);
            this.Controls.Add(this.ecountry);
            this.Controls.Add(this.cocountry);
            this.Controls.Add(this.tegender);
            this.Controls.Add(this.tepassword);
            this.Controls.Add(this.teemail);
            this.Controls.Add(this.tename);
            this.Controls.Add(this.Eresult);
            this.Controls.Add(this.Epassword);
            this.Controls.Add(this.Eemail);
            this.Controls.Add(this.Ename);
            this.Name = "Form1";
            this.Text = "EmployeeRegisteration";
            this.tegender.ResumeLayout(false);
            this.tegender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ename;
        private System.Windows.Forms.Label Eemail;
        private System.Windows.Forms.Label Epassword;
        private System.Windows.Forms.Label Eresult;
        private System.Windows.Forms.TextBox tename;
        private System.Windows.Forms.TextBox teemail;
        private System.Windows.Forms.TextBox tepassword;
        private System.Windows.Forms.RadioButton rmale;
        private System.Windows.Forms.RadioButton rfemale;
        private System.Windows.Forms.GroupBox tegender;
        private System.Windows.Forms.ComboBox cocountry;
        private System.Windows.Forms.Label ecountry;
        private System.Windows.Forms.Button esubmit;
        private System.Windows.Forms.Button ereset;
    }
}

