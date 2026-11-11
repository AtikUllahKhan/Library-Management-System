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
    public partial class Booklist : Form
    {
        Login user;
        public Booklist(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Booklist_Load(object sender, EventArgs e)
        {
            booklistdatagridview.DataSource = BookController.GetBookList();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminhome a = new Adminhome(user);
            a.Show();
        }

        private void Booklistdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
