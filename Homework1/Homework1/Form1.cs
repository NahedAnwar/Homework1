using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        private void emSubmit_Click(object sender, EventArgs e)
        {
            string name = tetName.Text;
            string email = tetEmail.Text;
            string Address = tetAddress.Text;
            string phone = tetPhone.Text;
            string message = "Registeration Details: \n";
            message += "Name:" + name + "\n";
            message += "Email" + email + "\n";
            message += "Phone" + phone + "\n";
            message += "Address" + Address + "\n";
            MessageBox.Show(message, "Registertion Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
    }

