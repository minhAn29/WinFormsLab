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
        private SalesManagementContext db = InstanceDBContext.Instance;
        private OrderDetail updateOrderDetail = frmOrderManagement.updateOrderDetail;
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
            var strConn = config["ConnectionStrings:SalesManagementDB"];
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
            updateOrderDetail.UnitPrice = (decimal)db.Products.Find(updateOrderDetail.ProductId).UnitPrice;
            updateOrderDetail.Quantity = (int)intQuantity.Value;
            updateOrderDetail.Discount = (double)floatDiscount.Value / 100;
            db.OrderDetails.Update(updateOrderDetail);
            db.SaveChanges();
            this.Close(); //Close form dialog
        }

        private void frmUpdateOrderDetail_Load(object sender, EventArgs e)
        {
            LoadMemberList();
            productList.Enabled = false;
            intOrderId.Enabled = false;
        }
    }
}
