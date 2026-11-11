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
    public partial class Studenthome : Form
    {
        Login user;
        public Studenthome(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Studenthome_Load(object sender, EventArgs e)
        {

        }

        private void Allbooksbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Allbooksdetails a = new Allbooksdetails(user);
            a.Show();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginview a = new Loginview();
            a.Show();
        }

        private void Ownactivitybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownactivity a = new Ownactivity(user);
            a.Show();
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentprofile a = new Studentprofile(user);
            a.Show();
        }

        private void Changepasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentchangepassword a = new Studentchangepassword(user);
            a.Show();
        }
    }
}
