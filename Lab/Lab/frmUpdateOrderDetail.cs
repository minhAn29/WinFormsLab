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
    public partial class frmUpdateOrderDetail : Form
    {
        private SalesManagementContext db = new SalesManagementContext(GetConnectionString());
        public frmUpdateOrderDetail(OrderDetail selectedOrder)
        {
            InitializeComponent();
            LoadSelectedOrder(selectedOrder);
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
            productList.DisplayMember = "ProductName";
            productList.ValueMember = "ProductId";
            productList.DataSource = db.Products.ToList();
        }

        private void LoadSelectedOrder(OrderDetail selectedOrder)
        {
            intOrderId.Value = selectedOrder.OrderId;
            intQuantity.Value = selectedOrder.Quantity;
            floatDiscount.Value = Convert.ToInt32(selectedOrder.Discount * 100);
            productList.SelectedValue = selectedOrder.ProductId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var orderDetail = new OrderDetail()
            {
                OrderId = (int)intOrderId.Value,
                UnitPrice = (decimal)db.Products.Find((int)intOrderId.Value).UnitPrice,
                Quantity = (int)intQuantity.Value,
                Discount = (double)floatDiscount.Value / 100,
                ProductId = (int)productList.SelectedValue
            };
            db.OrderDetails.Update(orderDetail);
            db.SaveChanges();
            this.Close(); //Close form dialog
        }
    }
}
