namespace Homework1
{
    partial class Employee
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
            this.emName = new System.Windows.Forms.Label();
            this.emEmail = new System.Windows.Forms.Label();
            this.emPhone = new System.Windows.Forms.Label();
            this.emAddress = new System.Windows.Forms.Label();
            this.tetName = new System.Windows.Forms.TextBox();
            this.tetEmail = new System.Windows.Forms.TextBox();
            this.tetPhone = new System.Windows.Forms.TextBox();
            this.tetAddress = new System.Windows.Forms.TextBox();
            this.emSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emName
            // 
            this.emName.AutoSize = true;
            this.emName.Location = new System.Drawing.Point(24, 31);
            this.emName.Name = "emName";
            this.emName.Size = new System.Drawing.Size(50, 19);
            this.emName.TabIndex = 0;
            this.emName.Text = "Name";
            // 
            // emEmail
            // 
            this.emEmail.AutoSize = true;
            this.emEmail.Location = new System.Drawing.Point(24, 77);
            this.emEmail.Name = "emEmail";
            this.emEmail.Size = new System.Drawing.Size(48, 19);
            this.emEmail.TabIndex = 1;
            this.emEmail.Text = "Email";
            // 
            // emPhone
            // 
            this.emPhone.AutoSize = true;
            this.emPhone.Location = new System.Drawing.Point(24, 116);
            this.emPhone.Name = "emPhone";
            this.emPhone.Size = new System.Drawing.Size(53, 19);
            this.emPhone.TabIndex = 2;
            this.emPhone.Text = "Phone";
            // 
            // emAddress
            // 
            this.emAddress.AutoSize = true;
            this.emAddress.Location = new System.Drawing.Point(24, 155);
            this.emAddress.Name = "emAddress";
            this.emAddress.Size = new System.Drawing.Size(57, 19);
            this.emAddress.TabIndex = 3;
            this.emAddress.Text = "Adress";
            // 
            // tetName
            // 
            this.tetName.Location = new System.Drawing.Point(95, 28);
            this.tetName.Name = "tetName";
            this.tetName.Size = new System.Drawing.Size(100, 27);
            this.tetName.TabIndex = 4;
            this.tetName.TextChanged += new System.EventHandler(this.tetName_TextChanged);
            // 
            // tetEmail
            // 
            this.tetEmail.Location = new System.Drawing.Point(95, 77);
            this.tetEmail.Name = "tetEmail";
            this.tetEmail.Size = new System.Drawing.Size(100, 27);
            this.tetEmail.TabIndex = 5;
            // 
            // tetPhone
            // 
            this.tetPhone.Location = new System.Drawing.Point(95, 116);
            this.tetPhone.Name = "tetPhone";
            this.tetPhone.Size = new System.Drawing.Size(100, 27);
            this.tetPhone.TabIndex = 6;
            // 
            // tetAddress
            // 
            this.tetAddress.Location = new System.Drawing.Point(95, 152);
            this.tetAddress.Name = "tetAddress";
            this.tetAddress.Size = new System.Drawing.Size(100, 27);
            this.tetAddress.TabIndex = 7;
            // 
            // emSubmit
            // 
            this.emSubmit.Location = new System.Drawing.Point(210, 255);
            this.emSubmit.Name = "emSubmit";
            this.emSubmit.Size = new System.Drawing.Size(100, 30);
            this.emSubmit.TabIndex = 8;
            this.emSubmit.Text = "Register";
            this.emSubmit.UseVisualStyleBackColor = true;
            this.emSubmit.Click += new System.EventHandler(this.emSubmit_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.emSubmit);
            this.Controls.Add(this.tetAddress);
            this.Controls.Add(this.tetPhone);
            this.Controls.Add(this.tetEmail);
            this.Controls.Add(this.tetName);
            this.Controls.Add(this.emAddress);
            this.Controls.Add(this.emPhone);
            this.Controls.Add(this.emEmail);
            this.Controls.Add(this.emName);
            this.Name = "Employee";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emName;
        private System.Windows.Forms.Label emEmail;
        private System.Windows.Forms.Label emPhone;
        private System.Windows.Forms.Label emAddress;
        private System.Windows.Forms.TextBox tetName;
        private System.Windows.Forms.TextBox tetEmail;
        private System.Windows.Forms.TextBox tetPhone;
        private System.Windows.Forms.TextBox tetAddress;
        private System.Windows.Forms.Button emSubmit;
    }
}

