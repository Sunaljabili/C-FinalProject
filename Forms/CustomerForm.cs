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
            FillCustomer();

        }
      #region Customer Create Method
        //Customer Create Method Start
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if(FullNameTxt.Text == "")
            {
                MessageBox.Show("FullName daxil edin.");
            }
            if (PhoneTxt.Text == "")
            {
                MessageBox.Show("Phone nomreni daxil edin.");
            }
            if (EmailTxt.Text == "")
            {
                MessageBox.Show("Email  daxil edin.");
            }
            if (ActiveRdBtn.Checked == false && DisabledRdBtn.Checked == false)
            {
                MessageBox.Show("Status sechin.");
            }
            if (!string.IsNullOrEmpty(FullNameTxt.Text)  
                && (ActiveRdBtn.Checked || DisabledRdBtn.Checked))
            {
                Customer customer = new Customer();

                customer.FullName = FullNameTxt.Text;
                customer.Phone = PhoneTxt.Text;
                customer.Email = EmailTxt.Text;

                _db.Customers.Add(customer);
                _db.SaveChanges();

                MessageBox.Show("Customer Added"+ FullNameTxt.Text + "New Customer");
                FullNameTxt.Clear();
                PhoneTxt.Clear();
                EmailTxt.Clear();
                ActiveRdBtn.Checked = false;
                DisabledRdBtn.Checked = false;

                FillCustomer();

            }
        }
        //Customer Create Method End
        #endregion

        #region Fill Method for Customer
        // Fill Method for Customer
        public void FillCustomer()
        {
            DgvCustomer.Rows.Clear();

            List<Customer> customer = _db.Customers.ToList();

            foreach (var item in customer)
            {
                DgvCustomer.Rows.Add(item.FullName,item.Email,item.Phone,item.Status ? "Active" :"Disapled");
            }
        }
        // Fill Method for Customer
        #endregion
    }
}
