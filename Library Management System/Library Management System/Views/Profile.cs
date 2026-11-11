using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.Controllers;
using Library_Management_System.Models;

namespace Library_Management_System.Views
{
    public partial class Profile : Form
    {
        Login user;
        public Profile(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Admin m = new Admin();
            m =AdminController.getAdmin(user.Id);
            useridtextbox.Text = m.Id;
            nametextbox.Text = m.Name;
            emailtextbox.Text = m.Email;
            phonenotextbox.Text = m.Phone;
            addresstextbox.Text = m.Address;

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminhome a = new Adminhome(user);
            a.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if ((emailtextbox.Text != "") && (phonenotextbox.Text != "") && (addresstextbox.Text != ""))
            {

                AdminController.UpdateAdmin(useridtextbox.Text, emailtextbox.Text,phonenotextbox.Text,addresstextbox.Text);
                MessageBox.Show("Email,Phone number and Address updated", "update", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Please fill Email,phone number And Address box", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
