using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myprpject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cocountry.Items.Add("Yemen");
            cocountry.Items.Add("Syria");
            cocountry.Items.Add("Oman");
        }

        private void esubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tename.Text))
            {
                MessageBox.Show("Name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tename.Focus();
                return;
            }

      
             
            if (!Eemail.Text.Contains("@"))
            {
                MessageBox.Show("Please include '@' in the email address!", "Validation Warning");
            }



            
            if (tepassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long!", "Validation Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
               tepassword.Focus();
                return;
            }

            
            if (!rmale.Checked && !rfemale.Checked)
            {
               MessageBox.Show("Please select a gender!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            if (cocountry.SelectedItem == null)
            {
                MessageBox.Show("Please select a country!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cocountry.Focus();
                return;
            }

        
            string name = tename.Text;
            string email = teemail.Text;
            string password = tepassword.Text;
            string gender = rmale.Checked ? "Male" : "Female";
            string country = cocountry.SelectedItem.ToString();

            Eresult.Text = $"Name:{name}\nEmail:{email}\nPassword:{password}\nGender:{gender}\nCountry:{country}";
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void ereset_Click(object sender, EventArgs e)
        {
            
            
            tename.Text = "";
            teemail.Text = "";
            tepassword.Text = "";

           
            rmale.Checked = false;
            rfemale.Checked = false;
            cocountry.SelectedIndex = -1; 

            
            Eresult.Text = "";
            
            tename.Focus();
        }

        private void Eresult_Click(object sender, EventArgs e)
        {

        }
    }
}

