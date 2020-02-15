using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using BackEnd_Final_Project.Models;
using BackEnd_Final_Project.Data;

namespace BackEnd_Final_Project.Forms
{
    public partial class BookAuthorForm : Form
    {
        private readonly LibraryDbContext _db;
        private Author _author;
        public BookAuthorForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();
            FillAuthors();
        }

        #region Author Creat Method
        // Author Create Method
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Name daxil edin.");
            }
            if (TxtSurname.Text == "")
            {
                MessageBox.Show("Surname daxil edin");
            }
            if (RdBtnActive.Checked == false && RdBtnDisabled.Checked == false)
            {
                MessageBox.Show("Status sechin");
            }
            if (!string.IsNullOrEmpty(TxtName.Text) && !string.IsNullOrEmpty(TxtSurname.Text)
                && (RdBtnActive.Checked || RdBtnDisabled.Checked))
            {
                Author author = new Author();

                author.Name = TxtName.Text;
                author.Status = RdBtnActive.Checked ? true : false;
                author.Surname = TxtSurname.Text;

                _db.Authors.Add(author);
                _db.SaveChanges();

                MessageBox.Show("Author Added:" + TxtName.Text, TxtSurname.Text + "New Author");
                TxtSurname.Clear();
                TxtName.Clear();
                RdBtnActive.Checked = false;
                RdBtnDisabled.Checked = false;

                FillAuthors();
            }
        }
        //Author Create Method End
        #endregion



        #region Author Reset
        //Reset Author
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        public void ResetForm()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            if (RdBtnActive.Checked)
            {
                RdBtnDisabled.Checked = false;
            }
            if (RdBtnDisabled.Checked)
            {
                RdBtnActive.Checked = false;
            }
        }
        //Reset Author End
        #endregion

        #region Update Method 
        //Author Update Btn_Click
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtName.Text) && !string.IsNullOrEmpty(TxtSurname.Text)
                && (RdBtnActive.Checked || RdBtnDisabled.Checked))
            {
                _author.Name = TxtName.Text;
                _author.Surname = TxtSurname.Text;
                _author.Status = RdBtnActive.Checked ? true : false;
                _db.SaveChanges();

                ResetForm();
                FillAuthors();
            }
        }
        //Author Update Method End
        #endregion

        #region FillAuthors Method
        //Fill Authors Method
        public void FillAuthors()
        {
            DgvAuthors.Rows.Clear();

            List<Author> authors = _db.Authors.ToList();

            foreach (var item in authors)
            {
                DgvAuthors.Rows.Add(item.Id, item.Name, item.Surname, item.Status ? "Active" : "Disabled");

            }
        }

        //Fill Aauthors Method End
        #endregion


        #region Author Update Method for Row
        //Author Update Method 
        private void DgvAuthors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvAuthors.Rows[e.RowIndex].Cells[0].Value.ToString());

            _author = _db.Authors.Find(id);

            UpdateBtn.Show();
            DeleteBtn.Show();

            TxtName.Text = _author.Name;
            TxtSurname.Text = _author.Surname;
            if (_author.Status == false)
            {
                RdBtnActive.Checked = true;
            }
            else
            {
                RdBtnDisabled.Checked = true;
            }
            BtnCreate.Enabled = false;


        }
        //Author Update Method End
        #endregion

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (_author == null)
            {
                MessageBox.Show("Selecet Author", "Error!!!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Selected Author will be deleted peramently" , "Warning" , MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _db.Authors.Remove(_author);
                _db.SaveChanges();
                FillAuthors();
                ResetForm();
            }
            else
            {
                ResetForm();
            }

        }

       
    }
   
 }



