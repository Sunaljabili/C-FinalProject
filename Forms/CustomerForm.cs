using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd_Final_Project.Data;
using BackEnd_Final_Project.Models;
using System.ComponentModel.DataAnnotations;


namespace BackEnd_Final_Project.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly LibraryDbContext _db;
        private Customer _customer;

        public CustomerForm()

        {
            _db = new LibraryDbContext();

            InitializeComponent();
            FillCustomers();

        }


        #region Fill Method for Customer
        // Fill Method for Customer

        public void FillCustomers()
        {
            DgvCustomer.Rows.Clear();

            List<Customer> customers = _db.Customers.ToList();

            foreach (var item in customers)
            {
                DgvCustomer.Rows.Add(item.Id, item.FullName, item.Phone, item.Email, item.Status ? "Active" : "Disabled");

            }
        }


        // Fill Method for Customer
        #endregion

        #region Customer Reset
        //Reset Customer    
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        public void ResetForm()
        {
            FullNameTxt.Clear();
            PhoneTxt.Clear();
            EmailTxt.Clear();
            if (ActiveRdBtn.Checked)
            {
                DisabledRdBtn.Checked = false;
            }
            if (DisabledRdBtn.Checked)
            {
                ActiveRdBtn.Checked = false;
            }
        }

        //Reset Customer End
        #endregion

        #region Update Method
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FullNameTxt.Text) && !string.IsNullOrEmpty(EmailTxt.Text) && !string.IsNullOrEmpty(PhoneTxt.Text)
                && (ActiveRdBtn.Checked || DisabledRdBtn.Checked))
            {
                _customer.FullName = FullNameTxt.Text;
                _customer.Email = EmailTxt.Text;
                _customer.Phone = EmailTxt.Text;
                _customer.Status = ActiveRdBtn.Checked ? true : false;
                _db.SaveChanges();

                ResetForm();
                FillCustomers();
            }
        }


        #endregion

        #region Double Click Update Delete
       
        #endregion

        #region  Delete Method 
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                MessageBox.Show("Selecet Customer", "Error!!!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Selected Customer will be deleted peramently", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _db.Customers.Remove(_customer);
                _db.SaveChanges();
                FillCustomers();
                ResetForm();
            }
            else
            {
                ResetForm();
            }
        }

        #endregion

        #region BtnCreate Method Customer
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (FullNameTxt.Text == "")
            {
                MessageBox.Show("FullName daxil edin.");
            }
            if (PhoneTxt.Text == "")
            {
                MessageBox.Show("Phone nomreni daxil edin");
            }
            if (EmailTxt.Text == "")
            {
                MessageBox.Show("Email daxil edin");
            }

            if (ActiveRdBtn.Checked == false && DisabledRdBtn.Checked == false)
            {
                MessageBox.Show("Status sechin");
            }
            if (!string.IsNullOrEmpty(FullNameTxt.Text) && !string.IsNullOrEmpty(EmailTxt.Text) && !string.IsNullOrEmpty(PhoneTxt.Text)
                && (ActiveRdBtn.Checked || DisabledRdBtn.Checked))
            {
                Customer customer = new Customer();

                customer.FullName = FullNameTxt.Text;
                customer.Status = ActiveRdBtn.Checked ? true : false;
                customer.Phone = PhoneTxt.Text;
                customer.Email = EmailTxt.Text;

                _db.Customers.Add(customer);
                _db.SaveChanges();

                MessageBox.Show("Author Added:" + FullNameTxt.Text+ "New Author");
                FullNameTxt.Clear();
                PhoneTxt.Clear();
                EmailTxt.Clear();
                ActiveRdBtn.Checked = false;
                DisabledRdBtn.Checked = false;

                FillCustomers();
            }
        }

        #endregion

        private void DgvCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());

            _customer = _db.Customers.Find(id);

            UpdateBtn.Show();
            DeleteBtn.Show();

            FullNameTxt.Text = _customer.FullName;
            EmailTxt.Text = _customer.Email;
            PhoneTxt.Text = _customer.Phone;
            if (_customer.Status == false)
            {
                ActiveRdBtn.Checked = true;
            }
            else
            {
                DisabledRdBtn.Checked = true;
            }
            BtnCreate.Enabled = false;
        }
    }
}
