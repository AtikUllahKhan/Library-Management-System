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
    public partial class Adminhome : Form
    {
        Login user;
        public Adminhome(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Adminhome_Load(object sender, EventArgs e)
        {

        }

        private void Managelibrarianbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managelibrarian a = new Managelibrarian(user);
            a.Show();

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void Booklistbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booklist a = new Booklist(user);
            a.Show();
        }

        private void Studentlistbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList a = new StudentList(user);
            a.Show();
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile a = new Profile(user);
            a.Show();
        }

        private void Changepasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Changepassword a = new Changepassword(user);
            a.Show();
        }
    }
}
