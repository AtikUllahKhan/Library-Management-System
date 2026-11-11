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
    public partial class librarianchangepassword : Form
    {
        Login user;
        public librarianchangepassword(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Librarianchangepassword_Load(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianhome a = new Librarianhome(user);
            a.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (newpasswordtextbox.Text != "")
            {
                LoginController.UpdatePassword(user.Id, newpasswordtextbox.Text);
                newpasswordtextbox.Clear();

                MessageBox.Show("password Change", "Change Password", MessageBoxButtons.OK);
                this.Hide();
                Loginview a = new Loginview();
                a.Show();


            }
            else
            {
                MessageBox.Show("please give new password", "Change Password", MessageBoxButtons.OK);

            }
        }
    }
}
