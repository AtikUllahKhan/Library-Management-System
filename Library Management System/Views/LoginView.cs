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
    public partial class Loginview : Form
    {
        public Loginview()
        {
            InitializeComponent();
            passwordtextbox.PasswordChar = '*';
        }

        private void Loginview_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Showcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showcheckbox.Checked)
            {
                passwordtextbox.UseSystemPasswordChar = true;


            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Login user = LoginController.getUser(useridtextbox.Text, passwordtextbox.Text);
            if (user != null)
            {
                if (user.Role == "admin" && user.Status == "active")
                {
                    this.Hide();
                    Adminhome a = new Adminhome(user);
                    a.Show();

                }

                else if (user.Role == "librarian" && user.Status == "active")
                {
                    this.Hide();
                    Librarianhome a = new Librarianhome(user);
                    a.Show();

                }

                else if (user.Role == "student" && user.Status == "active")
                {
                    this.Hide();
                    Studenthome a = new Studenthome(user);
                    a.Show();

                }



                else
                {

                    MessageBox.Show("Wrong Pass or User Id", "login failed", MessageBoxButtons.OK);
                   useridtextbox.Clear();
                    passwordtextbox.Clear();
                }

            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration a = new Registration();
            a.Show();
        }
    }
}
