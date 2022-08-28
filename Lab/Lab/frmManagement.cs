using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmManagement : Form
{
    Member member = frmLogin.member;
    public frmManagement()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Hide();
        frmLogin frmLogin = new frmLogin();
        frmLogin.Show();
    }
}
