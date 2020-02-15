using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd_Final_Project.Models;
using BackEnd_Final_Project.Forms;
using BackEnd_Final_Project.Data;


namespace BackEnd_Final_Project.Forms
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

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



        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtName.Text) && CmboxAuthor.SelectedItem!=null && (RdBtnActive.Checked || RdBtnDisabled.Checked))
             {
                CmbBoxItem selectedAuthor = CmboxAuthor.SelectedItem as CmbBoxItem;

                Book book = new Book();

                book.Name = TxtName.Text;
                book.SalePrice = nTextSale.Value;
                book.RentPrice = nTextRent.Value;
                book.Status = RdBtnActive.Checked ? true : false;
                book.AuthorId = selectedAuthor.Value;


              }
                


        }
    }
}
