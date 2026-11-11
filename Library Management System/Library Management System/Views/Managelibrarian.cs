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
    public partial class Managelibrarian : Form
    {
        Login user;
        public string Id;
        public Managelibrarian(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void Managelibrarian_Load(object sender, EventArgs e)
        {
            managelibrariandatagridview.DataSource = LibrarianController.GetLibrarianList();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
           Adminhome a = new Adminhome(user);
            a.Show();
        }

        private void Managelibrariandatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Id = managelibrariandatagridview.SelectedRows[0].Cells[0].Value.ToString();
            nametextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[1].Value.ToString();
            emailtextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[2].Value.ToString();
            phonenotextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[3].Value.ToString();
            addresstextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[5].Value.ToString();
            salarytextbox.Text = managelibrariandatagridview.SelectedRows[0].Cells[6].Value.ToString();

            passwordtextbox.Clear();
            answertextbox.Clear();
        }

        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 10000000);
            string a = "L-" + y;
            return a;

        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            if ((nametextbox.Text != "") && (phonenotextbox.Text != ""))
            {
                if (emailtextbox.Text != "")
                {
                    if ((maleradiobutton.Checked) || (femaleradiobutton.Checked))
                    {
                        if ((answertextbox.Text != "") && (passwordtextbox.Text != "")&& (addresstextbox.Text != "") && (salarytextbox.Text != ""))
                        {
                            Librarian o = new Librarian();
                            o.Id = CreateId();
                            o.Name = nametextbox.Text;
                            o.Email = emailtextbox.Text;
                            try
                            {

                                o.Phoneno = phonenotextbox.Text;
                                
                                if (maleradiobutton.Checked)
                                {
                                    o.Gender = "male";

                                }

                                else if (femaleradiobutton.Checked)
                                {
                                    o.Gender = "Female";

                                }

                                o.Address = addresstextbox.Text;
                                o.Salary = salarytextbox.Text;

                                o.Status = "active";

                                Login u = new Login();
                                u.Id = o.Id;
                                u.Password = passwordtextbox.Text;
                                u.Status = "active";
                                u.Role = "librarian";
                                u.Answer = answertextbox.Text;

                                LibrarianController.InsertLibrarian(o);
                                LoginController.InsertUser(u);
                                MessageBox.Show("Librarian Inserted.Librarian id" + o.Id, "Add Librarian", MessageBoxButtons.OK);
                                nametextbox.Clear();
                                emailtextbox.Clear();
                                phonenotextbox.Clear();
                                addresstextbox.Clear();
                                salarytextbox.Clear();
                                answertextbox.Clear();
                                passwordtextbox.Clear();
                                Id = null;

                                managelibrariandatagridview.DataSource = LibrarianController.GetLibrarianList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "Add Librarian", MessageBoxButtons.OK);
                                nametextbox.Clear();
                                emailtextbox.Clear();
                                phonenotextbox.Clear();
                                addresstextbox.Clear();
                                salarytextbox.Clear();
                                answertextbox.Clear();
                                passwordtextbox.Clear();
                                Id = null;

                            }

                        }

                    }


                }

            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            emailtextbox.Clear();
            phonenotextbox.Clear();
            addresstextbox.Clear();
            salarytextbox.Clear();
            answertextbox.Clear();
            passwordtextbox.Clear();
            Id = null;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                LibrarianController.UpdateLibrarian(Id,nametextbox.Text,salarytextbox.Text);



                nametextbox.Clear();
                emailtextbox.Clear();
                phonenotextbox.Clear();
                addresstextbox.Clear();
                salarytextbox.Clear();
                answertextbox.Clear();
                passwordtextbox.Clear();
                Id = null;

                managelibrariandatagridview.DataSource = LibrarianController.GetLibrarianList();
                MessageBox.Show("Librarian updatetd", "update Librarian", MessageBoxButtons.OK);
                

            }

            else
            {
                MessageBox.Show("please select an Librarian", "update librarian", MessageBoxButtons.OK);

            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                LibrarianController.DeleteLibrarian(Id);
                LoginController.DeleteUser(Id);


                nametextbox.Clear();
                emailtextbox.Clear();
                phonenotextbox.Clear();
                addresstextbox.Clear();
                salarytextbox.Clear();
                answertextbox.Clear();
                passwordtextbox.Clear();
                Id = null;

                managelibrariandatagridview.DataSource = LibrarianController.GetLibrarianList();
                MessageBox.Show("Librarian deleted", "delete Librarian", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select an Librarian", "delete librarian", MessageBoxButtons.OK);

            }
        }
    }
}
