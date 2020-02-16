using BackEnd_Final_Project.Data;
using BackEnd_Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace BackEnd_Final_Project.Forms
{
    public partial class BookForm : Form
    {
        private readonly LibraryDbContext _db;
        private Book _book;

        public BookForm()

        {
            _db = new LibraryDbContext();
            InitializeComponent();
            FillBooks();
        }

        #region Fill Method for Book
        // Fill Method for Book

        public void FillBooks()
        {
            DgvBook.Rows.Clear();

            List<Book> books = _db.Books.ToList();


            foreach (var item in books)
            {
                DgvBook.Rows.Add(item.Id, item.Name, item.Author, item.SalePrice, item.RentPrice, item.Status ? "Active" : "Disabled");

            }
        }


        // Fill Method for Book
        #endregion


        #region CmbBoxItem
        public class CmbBoxItem
        {
            public string FirstName { get; set; }

            public string SecondName { get; set; }

            public int Value { get; set; }

            public override string ToString()
            {
                return FirstName + " " + SecondName;

            }

        }
        #endregion



        #region Create Method
       // Create Method
        private void BtnCreate_Click(object sender, EventArgs e)
        {

            if (TxtName.Text == "")
            {
                MessageBox.Show("Name daxil edin.");
            }
            if (CmboxAuthor.Text == "")
            {
                MessageBox.Show("Author teyin  edin");
            }
            if(nTextSale.Value == 0)
            {
                MessageBox.Show("Reqem daxil edin");
            }
            if (nTextRent.Value == 0)
            {
                MessageBox.Show("Reqem daxil edin");
            }
            if (nTextCount.Value == 0)
            {
                MessageBox.Show("Reqem daxil edin");
            }
            if (RdBtnActive.Checked == false && RdBtnDisabled.Checked == false)
            {
                MessageBox.Show("Status sechin");
            }
            if (!string.IsNullOrEmpty(TxtName.Text) && !string.IsNullOrEmpty(CmboxAuthor.Text) 

                && (nTextCount.Value ==0) && (nTextRent.Value == 0) && (nTextSale.Value == 0) && (RdBtnActive.Checked || RdBtnDisabled.Checked))
            {
                Book book = new Book();

                book.Name = TxtName.Text;
                
             

                _db.Books.Add(book);
                _db.SaveChanges();

              

                //FillCustomers();
            }


            if (!string.IsNullOrEmpty(TxtName.Text) && CmboxAuthor.SelectedItem != null && (RdBtnActive.Checked || RdBtnDisabled.Checked))
            {
                CmbBoxItem selectedAuthor = CmboxAuthor.SelectedItem as CmbBoxItem;

                Book book = new Book();

                book.Name = TxtName.Text;
                book.SalePrice = nTextSale.Value;
                book.RentPrice = nTextRent.Value;
                book.Status = RdBtnActive.Checked ? true : false;
                book.AuthorId = selectedAuthor.Value;
                book.Count = Convert.ToInt32(nTextCount.Value);
                book.CreatedAt = DateTime.Now;

                _db.Books.Add(book);
                _db.SaveChanges();

                MessageBox.Show("Book added :  " + TxtName.Text, " New Book ");
                TxtName.Clear();
                RdBtnActive.Checked = false;
                RdBtnDisabled.Checked = false;

                FillBooks();
                Reset();

            }





        }
        #endregion


        #region Reset For Book
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            TxtName.Clear();
            CmboxAuthor.SelectedItem = null;
            CmboxAuthor.Text = "";

            nTextSale.Value = 0;
            nTextCount.Value = 0;
            nTextRent.Value = 0;
            RdBtnActive.Checked = false;
            RdBtnDisabled.Checked = false;

           if(BtnCreate.Enabled == false)
            {
                BtnCreate.Enabled = true;
            }
        }
        #endregion


    }
}

