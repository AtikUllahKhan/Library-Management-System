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
    public partial class Allbooksdetails : Form
    {
        Login user;
        public Allbooksdetails(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Allbooksdetails_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BookController.GetBookList();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenthome a = new Studenthome(user);
            a.Show();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if(searchtextbox.Text!="")
            {

                dataGridView1.DataSource = BookController.GetBookList1(searchtextbox.Text);
            }
        }
    }
}
