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
    public partial class Ownactivity : Form
    {
        Login user;
        public Ownactivity(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Ownactivity_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BorrowController.GetBorrowList1(user.Id);
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenthome a = new Studenthome(user);
            a.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
