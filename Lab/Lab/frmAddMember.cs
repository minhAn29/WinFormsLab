﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;

namespace SalesWinApp;



public partial class frmAddMember : Form
{
    private SalesManagementContext _db = InstanceDBContext.Instance;
    private int memberId;
    private string email;
    private string companyName;
    private string city;
    private string country;
    private string password;
    private string confirmPassword;

    public frmAddMember()
    {
        InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Hide();
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
    private bool isDuplicate()
    {
        Member checkMember = _db.Members.Find(memberId);
        if (checkMember == null)
            return false;
        return true;
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (ValidAddInfo())
        {
            if (isDuplicate() == false)
            {
                Member addMember = new Member()
                {
                    MemberId = memberId,
                    Email = email,
                    CompanyName = companyName,
                    City = city,
                    Country = country,
                    Password = password,
                };
                _db.Add(addMember);
                _db.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Duplicated member ID");
            }
        }
    }

    private void frmAddMember_Load(object sender, EventArgs e)
    {
        var selectedMember = frmMemberManagement.selectedMember;
        if (selectedMember != null)
        {
            numMemberId.Value = selectedMember.MemberId;
            numMemberId.Enabled = false;
            txtEmail.Text = selectedMember.Email;
            txtCompanyName.Text = selectedMember.CompanyName;
            txtCity.Text = selectedMember.City;
            txtCountry.Text = selectedMember.Country;
            txtPassword.Text = selectedMember.Password;
            txtConfirmPassword.Text = selectedMember.Password;

        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (ValidAddInfo())
        {
            Member updatedMember = frmMemberManagement.selectedMember;
            updatedMember.MemberId = decimal.ToInt32(numMemberId.Value);
            updatedMember.Email = email;
            updatedMember.CompanyName = companyName;
            updatedMember.City = city;
            updatedMember.Country = country;
            updatedMember.Password = password;

            _db.Update(updatedMember);
            _db.SaveChanges();
            this.Close();
        }
    }
}
