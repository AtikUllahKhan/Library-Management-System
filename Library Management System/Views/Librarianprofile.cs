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
    public partial class Librarianprofile : Form
    {
        Login user;
        public Librarianprofile(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Librarianprofile_Load(object sender, EventArgs e)
        {
            Librarian m = new Librarian();
            m = LibrarianController.GetLibrarian(user.Id);
            useridtextbox.Text = m.Id;
            nametextbox.Text = m.Name;
            emailtextbox.Text = m.Email;
            phonenotextbox.Text = m.Phoneno;
            addresstextbox.Text = m.Address;
            salarytextbox.Text = m.Salary;
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianhome a = new Librarianhome(user);
            a.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if ((emailtextbox.Text != "") && (phonenotextbox.Text != "") && (addresstextbox.Text != ""))
            {

                LibrarianController.UpdateLibrarianSelf(useridtextbox.Text, emailtextbox.Text, phonenotextbox.Text, addresstextbox.Text);
                MessageBox.Show("Email,Phone number and Address updated", "update", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Please fill Email,phone number And Address box", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
