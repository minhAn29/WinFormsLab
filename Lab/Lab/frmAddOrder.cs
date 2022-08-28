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
using Microsoft.Extensions.Configuration;

namespace SalesWinApp
{
    public partial class frmAddOrder: Form
    {
        private SalesManagementContext db = new SalesManagementContext(GetConnectionString());
        public frmAddOrder()
        {
            InitializeComponent();
            LoadMemberList();
        }

        private static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:CustomerAccountsDB"];
            return strConn;
        }

        private void LoadMemberList()
        {
            memberList.DisplayMember = "MemberId";
            memberList.ValueMember = "MemberId";
            memberList.DataSource = db.Members.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                var order = new Order()
                {
                    OrderId = (int)intOrderId.Value,
                    OrderDate = orderDatePicker.Value,
                    RequiredDate = requireDatePicker.Value,
                    ShippedDate = shippedDatePicker.Value,
                    Freight = decFreight.Value,
                    MemberId = (int)memberList.SelectedValue
                };
                db.Orders.Add(order);
                db.SaveChanges();
                this.Close(); //Close form dialog
            }
            else
            {
                MessageBox.Show("Your input data is not valid !");
            }
        }

        private bool CheckValid()
        {
            if (db.Orders.Where(a => a.OrderId == intOrderId.Value).Any())
                return false;
            return true;
        }
    }
}
