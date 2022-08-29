using Microsoft.Extensions.Configuration;
using DataAccess.Models;
using SalesWinApp;

namespace Lab
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:SalesManagementDB"];
            return strConn;
        }
        private Tuple<string,string> GetDefaultAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            string email = config["DefaultAccount:Email"];
            string password = config["DefaultAccount:Password"];
            return new Tuple<string,string>(email,password);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string email;
        private string password;
        public static Member? member;
        private SalesManagementContext db;

        private bool ValidLogin()
        {
            email = txtEmail.Text;
            password = txtPassword.Text;
            if(email == null || email.Equals(""))
            {
                MessageBox.Show("MemberId was null");
                txtEmail.Focus();
                return false;
            }
            else if (password == null || password.Equals(""))
            {
                MessageBox.Show("Password was null");
                txtPassword.Focus();
                return false;
            }
            else
            {
                db=new SalesManagementContext(GetConnectionString());

                var defaultAcc = GetDefaultAccount();
                if(email == defaultAcc.Item1 && password == defaultAcc.Item2)
                {
                    MessageBox.Show("You are logging in with Admin account");
                    return true;
                }
                member=db.Members.Where(x=>x.Email==email && x.Password==password).FirstOrDefault();
                if (member == null)
                {
                    MessageBox.Show("Account does not exist");
                    return false;
                }
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidLogin())
            {
                this.Hide();
                InstanceDBContext.Instance = db;
                if(member == null)
                {
                frmManagement frmManagement = new frmManagement();
                frmManagement.Show();
                }
                else
                {
                    frmMember frmMember = new frmMember();
                    frmMember.Show();

                }
            }
        }
    }
}