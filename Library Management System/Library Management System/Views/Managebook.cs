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
    public partial class Managebook : Form
    {
        Login user;
        public string Id;
        public Managebook(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Managebook_Load(object sender, EventArgs e)
        {
            managelibrariandatagridview.DataSource = BookController.GetBookList();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarianhome a = new Librarianhome(user);
            a.Show();
        }

        private void Managelibrariandatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = managelibrariandatagridview.SelectedRows[0].Cells[0].Value.ToString();
            titletextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[1].Value.ToString();
            authortextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[2].Value.ToString();
            editiontextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[3].Value.ToString();
            typecombobox.Text = managelibrariandatagridview.SelectedRows[0].Cells[4].Value.ToString();
            isbntextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[5].Value.ToString();
            noofcopytextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[6].Value.ToString();
            bookshelfcombobox.Text = managelibrariandatagridview.SelectedRows[0].Cells[7].Value.ToString();
            publicationtextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[8].Value.ToString();
            

            

        }

        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 10000000);
            string a = "B-" + y;
            return a;

        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            if ((titletextbox.Text != "") && (authortextbox.Text != ""))
            {
                if (editiontextbox.Text != "")
                {
                    if ((typecombobox.Text!="") )
                    {
                        if ((isbntextbox.Text != "") && (noofcopytextbox.Text != "") && (bookshelfcombobox.Text != "") && (publicationtextbox.Text != ""))
                        {
                            Book o = new Book();
                            o.Id = CreateId();
                            o.Title = titletextbox.Text;
                            o.Author = authortextbox.Text;
                            try
                            {

                                o.Edition = editiontextbox.Text;
                                o.Type = typecombobox.Text;



                                o.Isbn = isbntextbox.Text;
                                o.Noofcopy = noofcopytextbox.Text;
                                o.Bookshelf = bookshelfcombobox.Text;
                                o.Publication = publicationtextbox.Text;

                                o.Status = "active";

                                

                                BookController.InsertBook(o);
                              
                                MessageBox.Show("Book Inserted.Book id" + o.Id, "Add Book", MessageBoxButtons.OK);
                                titletextbox.Clear();
                                authortextbox.Clear();
                                editiontextbox.Clear();
                                typecombobox.Text="";
                                isbntextbox.Clear();
                                noofcopytextbox.Clear();
                                publicationtextbox.Clear();
                                Id = null;
                                bookshelfcombobox.Text = "";

                                managelibrariandatagridview.DataSource = BookController.GetBookList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "Add book", MessageBoxButtons.OK);
                                titletextbox.Clear();
                                authortextbox.Clear();
                                editiontextbox.Clear();
                                typecombobox.Text = "";
                                isbntextbox.Clear();
                                noofcopytextbox.Clear();
                                publicationtextbox.Clear();
                                Id = null;
                                bookshelfcombobox.Text = "";

                            }

                        }

                    }


                }

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                BookController.UpdateBook(Id, titletextbox.Text, noofcopytextbox.Text);



                titletextbox.Clear();
                authortextbox.Clear();
                editiontextbox.Clear();
                typecombobox.Text = "";
                isbntextbox.Clear();
                noofcopytextbox.Clear();
                publicationtextbox.Clear();
                Id = null;
                bookshelfcombobox.Text = "";

                managelibrariandatagridview.DataSource = BookController.GetBookList();
                MessageBox.Show("book updatetd", "update book", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a book", "update book", MessageBoxButtons.OK);

            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            titletextbox.Clear();
            authortextbox.Clear();
            editiontextbox.Clear();
            typecombobox.Text = "";
            isbntextbox.Clear();
            noofcopytextbox.Clear();
            publicationtextbox.Clear();
            Id = null;
            bookshelfcombobox.Text = "";
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                BookController.DeleteBook(Id);



                titletextbox.Clear();
                authortextbox.Clear();
                editiontextbox.Clear();
                typecombobox.Text = "";
                isbntextbox.Clear();
                noofcopytextbox.Clear();
                publicationtextbox.Clear();
                Id = null;
                bookshelfcombobox.Text = "";

                managelibrariandatagridview.DataSource = BookController.GetBookList();
                MessageBox.Show("book deleted", "delete book", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a book", "delete book", MessageBoxButtons.OK);

            }
        }
    }
}
