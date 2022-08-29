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
    public partial class frmAddOrderDetail : Form
    {
        private SalesManagementContext db = InstanceDBContext.Instance;

        public frmAddOrderDetail(Order selectedOrder)
        {
            InitializeComponent();
            LoadData(selectedOrder);
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

        private void LoadData(Order order)
        {
            productList.DisplayMember = "ProductName";
            productList.ValueMember = "ProductId";
            productList.DataSource = db.Products.ToList();

            intOrderId.Value = order.OrderId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int orderId = decimal.ToInt32(intOrderId.Value);
            int productId = int.Parse(productList.SelectedValue.ToString());
            decimal unitPrice = db.Products.Find(productId).UnitPrice;
            int quantity = decimal.ToInt32(intQuantity.Value);
            double discount = (double)floatDiscount.Value / 100;
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = orderId,
                ProductId = productId,
                UnitPrice = unitPrice,
                Quantity = quantity,
                Discount = discount
            };
            db.OrderDetails.Add(orderDetail);
            db.SaveChanges();
            this.Close(); //Close form dialog
        }
    }
}
