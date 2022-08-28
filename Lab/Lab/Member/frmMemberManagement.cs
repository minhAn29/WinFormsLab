using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using Lab;

namespace SalesWinApp;

public partial class frmMemberManagement : Form
{
    private SalesManagementContext _db = InstanceDBContext.Instance;
    private Member member = frmLogin.member;
    public static Member selectedMember = null;
    public frmMemberManagement()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }
    private void LoadData()
    {
        dataGridView1.DataSource = _db.Members.ToList();
    }
    private void frmMemberManagement_Load(object sender, EventArgs e)
    {
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        LoadData();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        //if (member.Email.Contains("admin")) {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            var result = MessageBox.Show("Are you want to delete this member?", "Delete confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberId"].Value.ToString());
                DataAccess.Models.Member deletedMember = _db.Members.Find(memberId);
                if (deletedMember != null)
                {
                    if (deletedMember.MemberId == member.MemberId)
                    {
                        MessageBox.Show("This account currently in use, cannot delete");
                    }
                    else
                    {
                        _db.Members.Remove(deletedMember);
                        _db.SaveChanges();
                        LoadData();
                    }
                }
            }
            //}
            //else
            //{
            //    MessageBox.Show("Only admin is allowed to access this function");
            //}
        }
        else
        {
            MessageBox.Show("Select a row to delete");
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmAddMember frmAddMember = new frmAddMember();
        frmAddMember.ShowDialog();

        LoadData();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        //if (member.Email.Contains("admin")) {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberId"].Value.ToString());
            selectedMember = _db.Members.Find(memberId);
            if (selectedMember != null)
            {
                frmAddMember frmAddMember = new frmAddMember();
                selectedMember = _db.Members.Find(memberId);
                frmAddMember.ShowDialog();
                LoadData();
            }

            //}
            //else
            //{
            //    MessageBox.Show("Only admin is allowed to access this function");
            //}
        }
        else
        {
            MessageBox.Show("Select a row to update");
        }
    }
}
