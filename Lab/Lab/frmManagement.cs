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
    private SalesManagementContext _db = InstanceDBContext.Instance;
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

    private void loadForm(object Form)
    {
        if (this.panelShowForm.Controls.Count > 0)
        {
            this.panelShowForm.Controls.RemoveAt(0);
        }
        Form f = Form as Form;
        f.TopLevel = false;
        f.Dock=DockStyle.Fill;
        this.panelShowForm.Controls.Add(f);
        this.panelShowForm.Tag = f;
        f.Show();
    }
    private void mnuStripMember_Click(object sender, EventArgs e)
    {
        frmMemberManagement frmMemberManagement = new frmMemberManagement();
        frmMemberManagement.AutoScroll = true;
        loadForm(frmMemberManagement);
    }

    private void mnuStripOrder_Click(object sender, EventArgs e)
    {
        frmOrderManagement frmOrderManagement = new frmOrderManagement();
        frmOrderManagement.AutoScroll = true;
        loadForm(frmOrderManagement);
    }

    private void mnuStripProduct_Click(object sender, EventArgs e)
    {
        frmProductManagement frmProductManagement = new frmProductManagement();
        frmProductManagement.AutoScroll = true;
        loadForm(frmProductManagement);
    }

    private void frmManagement_Load(object sender, EventArgs e)
    {
        frmMemberManagement frmMemberManagement = new frmMemberManagement();
        frmMemberManagement.AutoScroll = true;
        loadForm(frmMemberManagement);
    }
}
