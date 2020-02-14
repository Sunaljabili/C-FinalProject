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
        public BookAuthorForm()
        {
            _db = new LibraryDbContext();

            InitializeComponent();
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
            if (RdBtnActive.Checked == false && RdBtnDisabled.Checked==false)
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

                MessageBox.Show("Author Added:" + TxtName.Text, "New Author");
                TxtName.Clear();
                RdBtnActive.Checked = false;
                RdBtnDisabled.Checked = false;
            }
        }
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
        #endregion

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        public void FillAuthors()
        {
            DgvAuthors.Rows.Clear();

            List<Author> authors = _db.Authors.ToList();

            foreach(var item in authors)
            {

            }
        }
    }
}

