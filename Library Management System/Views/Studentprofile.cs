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
    public partial class Studentprofile : Form
    {
        Login user;
        public Studentprofile(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Studentprofile_Load(object sender, EventArgs e)
        {
            Student m = new Student();
            m = StudentController.GetStudent(user.Id);
            useridtextbox.Text = m.Id;
            nametextbox.Text = m.Name;
            emailtextbox.Text = m.Email;
            phonenotextbox.Text = m.Phoneno;
            addresstextbox.Text = m.Address;
            institutiontextbox.Text = m.Institution;
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenthome a = new Studenthome(user);
            a.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if ((emailtextbox.Text != "") && (phonenotextbox.Text != "") && (addresstextbox.Text != ""))
            {

                StudentController.UpdateStudentSelf(useridtextbox.Text, emailtextbox.Text, phonenotextbox.Text, addresstextbox.Text);
                MessageBox.Show("Email,Phone number and Address updated", "update", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Please fill Email,phone number And Address box", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
