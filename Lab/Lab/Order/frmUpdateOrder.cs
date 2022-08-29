using DataAccess.Models;
using Microsoft.Extensions.Configuration;
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
    public partial class frmUpdateOrder : Form
    {
        private SalesManagementContext db = InstanceDBContext.Instance;
        private Order selectedOrder = frmOrderManagement.selectedOrder;
        public frmUpdateOrder(Order selectedOrder)
        {
            InitializeComponent();
            LoadMemberList();
            LoadSelectedOrder(selectedOrder);
        }
        private static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:SalesManagementDB"];
            return strConn;
        }

        private void LoadMemberList()
        {
            memberList.DisplayMember = "MemberId";
            memberList.ValueMember = "MemberId";
            memberList.DataSource = db.Members.ToList();
        }

        private void LoadSelectedOrder(Order selectedOrder)
        {
            intOrderId.Value = selectedOrder.OrderId;
            orderDatePicker.Value = selectedOrder.OrderDate;
            requireDatePicker.Value = (DateTime)selectedOrder.RequiredDate;
            shippedDatePicker.Value = (DateTime)selectedOrder.ShippedDate;
            decFreight.Value = (decimal)selectedOrder.Freight;
            memberList.SelectedValue = selectedOrder.MemberId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedOrder.OrderDate = orderDatePicker.Value;
            selectedOrder.RequiredDate = requireDatePicker.Value;
            selectedOrder.ShippedDate = shippedDatePicker.Value;
            selectedOrder.Freight = decFreight.Value;
            selectedOrder.MemberId = (int)memberList.SelectedValue;
            db.Orders.Update(selectedOrder);
            db.SaveChanges();
            this.Close(); //Close form dialog
        }

    }
}
