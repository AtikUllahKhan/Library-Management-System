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
    public partial class Manageborrowbook : Form
    {
        Login user;
        public string Id;
        public Manageborrowbook(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Manageborrowbook_Load(object sender, EventArgs e)
        {
            borrowbookdatagridview.DataSource = BorrowController.GetBorrowList();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianhome a = new Librarianhome(user);
            a.Show();
        }

        private void Searchdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Borrowbookdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = borrowbookdatagridview.SelectedRows[0].Cells[0].Value.ToString();
            studentidtextbox.Text = borrowbookdatagridview.SelectedRows[0].Cells[1].Value.ToString();
            bookidtextbox.Text = borrowbookdatagridview.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 10000000);
            string a = "BB-" + y;
            return a;

        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                BorrowController.DeleteBorrow(Id);



                studentidtextbox.Clear();
                bookidtextbox.Clear();
               
                Id = null;


                borrowbookdatagridview.DataSource = BorrowController.GetBorrowList();
                MessageBox.Show("borrow deleted", "delete borrow", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a borrow", "delete borrow", MessageBoxButtons.OK);

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            studentidtextbox.Clear();
            bookidtextbox.Clear();

            Id = null;

        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            if ((studentidtextbox.Text!="")&& (bookidtextbox.Text != ""))
            {
                Borrow o=new Borrow();
                o.Id= CreateId();
                o.Studentid = studentidtextbox.Text;
                o.Bookid = bookidtextbox.Text;
                o.Issuedate = issuedatepicker.Value;
                o.Returedate = new DateTime(1998, 01, 01);
                o.Borrowstatus = "borrowed";
                o.Status = "active";
                BorrowController.InsertBorrow(o);



                studentidtextbox.Clear();
                bookidtextbox.Clear();

                Id = null;


                borrowbookdatagridview.DataSource = BorrowController.GetBorrowList();
                MessageBox.Show("borrow inserted", "Insertborrow", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a borrow", "delete borrow", MessageBoxButtons.OK);

            }
        }

        private void Returnbutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
              
                BorrowController.Returnborrow(Id,DateTime.Today);



                studentidtextbox.Clear();
                bookidtextbox.Clear();

                Id = null;


                borrowbookdatagridview.DataSource = BorrowController.GetBorrowList();
                MessageBox.Show("borrow deleted", "delete borrow", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a borrow", "delete borrow", MessageBoxButtons.OK);

            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if(searchtextbox.Text!="")
            {
                if(studentradiobutton.Checked)
                {
                    searchdatagridview.DataSource = StudentController.GetStudentList1(searchtextbox.Text);
                }
                if(bookradiobutton.Checked)
                {
                    searchdatagridview.DataSource = BookController.GetBookList1(searchtextbox.Text);
                }
            }
        }
    }
}
