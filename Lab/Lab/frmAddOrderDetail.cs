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
        private SalesManagementContext db = new SalesManagementContext(GetConnectionString());

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
            var orderDetail = new OrderDetail()
            {
                OrderId = (int)intOrderId.Value,
                UnitPrice = (decimal)db.Products.Find((int)intOrderId.Value).UnitPrice,
                Quantity = (int)intQuantity.Value,
                Discount = (double)floatDiscount.Value / 100,
                ProductId = (int)productList.SelectedValue
            };
            db.OrderDetails.Add(orderDetail);
            db.SaveChanges();
            this.Close(); //Close form dialog
        }
    }
}
