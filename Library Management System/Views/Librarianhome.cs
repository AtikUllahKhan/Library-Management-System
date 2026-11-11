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
    public partial class Librarianhome : Form
    {
        Login user;
        public Librarianhome(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Librarianhome_Load(object sender, EventArgs e)
        {

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void Managestudentbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managestudent a = new Managestudent(user);
            a.Show();
        }

        private void Managebooksbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managebook a = new Managebook(user);
            a.Show();
        }

        private void Manageborrowbooksbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manageborrowbook a = new Manageborrowbook(user);
            a.Show();
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianprofile a = new Librarianprofile(user);
            a.Show();
        }

        private void Changepasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            librarianchangepassword a = new librarianchangepassword(user);
            a.Show();
        }
    }
}
