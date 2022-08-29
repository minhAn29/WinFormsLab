using DataAccess.Models;
using Lab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        private SalesManagementContext _db = InstanceDBContext.Instance;
        private static Member loginMember = null;
        private int memberId;
        private string email;
        private string companyName;
        private string city;
        private string country;
        private string password;
        private string confirmPassword;

        public frmMember()
        {
            InitializeComponent();
            loginMember = frmLogin.member;
            LoadData(loginMember);
        }

        private void LoadData(Member loginMember)
        {
            numMemberId.Value = loginMember.MemberId;
            numMemberId.Enabled = false;
            txtEmail.Text = loginMember.Email;
            txtCompanyName.Text = loginMember.CompanyName;
            txtCity.Text = loginMember.City;
            txtCountry.Text = loginMember.Country;
            txtPassword.Text = loginMember.Password;
            txtConfirmPassword.Text = loginMember.Password;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidAddInfo())
            {
                Member updatedMember = loginMember;
                if (updatedMember != null)
                {
                    updatedMember.MemberId = decimal.ToInt32(numMemberId.Value);
                    updatedMember.Email = email;
                    updatedMember.CompanyName = companyName;
                    updatedMember.City = city;
                    updatedMember.Country = country;
                    updatedMember.Password = password;

                    _db.Update(updatedMember);
                    _db.SaveChanges();
                    LoadData(updatedMember);
                    MessageBox.Show("Update successful");
                }
                else
                {
                    MessageBox.Show("You are not allowed when click Add button");
                }
            }
        }

        private bool ValidAddInfo()
        {
            memberId = decimal.ToInt32(numMemberId.Value);
            email = txtEmail.Text;
            companyName = txtCompanyName.Text;
            city = txtCity.Text;
            country = txtCountry.Text;
            password = txtPassword.Text;
            confirmPassword = txtConfirmPassword.Text;
            if (email == null || email.Equals(""))
            {
                MessageBox.Show("Email was null");
                return false;
            }
            if (companyName == null || companyName.Equals(""))
            {
                MessageBox.Show("Company name was null");
                return false;
            }
            if (city == null || city.Equals(""))
            {
                MessageBox.Show("City was null");
                return false;
            }
            if (country == null || country.Equals(""))
            {
                MessageBox.Show("Country was null");
                return false;
            }
            if (password == null || password.Equals(""))
            {
                MessageBox.Show("Password was null");
                return false;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("The passwords are not the same");
                return false;
            }
            return true;
        }

        private void LoadOrderList()
        {
            orderList.DataSource = _db.Orders.Where(o => o.MemberId == loginMember.MemberId).ToList();
        }

        private void frmMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void orderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(orderList.SelectedRows.Count > 0)
            {
                int selectedId = int.Parse(orderList.SelectedRows[0].Cells["OrderId"].Value.ToString());
                orderDetailList.DataSource = _db.OrderDetails.Where(a => a.OrderId == selectedId).ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            orderList.DataSource = _db.Orders.Where(o => o.MemberId == loginMember.MemberId && o.OrderId.ToString().Contains(txtKeyword.Text)).ToList();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        { 
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
