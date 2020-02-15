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
using CryptoHelper;
using BackEnd_Final_Project.Models;

namespace BackEnd_Final_Project.Forms
{
    public partial class LoginForm : Form
    {
        private readonly LibraryDbContext _context;
        public LoginForm(DashBoardForm dashBoardForm)
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(EmailTxt.Text))
            {
                MessageBox.Show("Email yazin");
                return;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Password yazin");
                return;
            }


            Customer customer = (_context.Customers.FirstOrDefault(u => u.Email == EmailTxt.Text));

            if (customer != null && Crypto.VerifyHashedPassword(TxtPassword.Text, EmailTxt.Text))
            {
                DashBoardForm dashBoard = new DashBoardForm();
                dashBoard.Show();

                this.Hide();
                return;
            }
            MessageBox.Show("Email və ya Password yalnishdir.");
        }
    }
}
