
﻿using Microsoft.Extensions.Configuration;
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


namespace SalesWinApp
{
    public partial class frmOrderManagement : Form
    {
        private SalesManagementContext db = new SalesManagementContext(GetConnectionString());
        public frmOrderManagement()
        {
            InitializeComponent();
            LoadData();
        }

        private static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:SalesMangementDB"];
            return strConn;
        }

        private void LoadData()
        {
            orderList.DataSource = db.Orders.ToList();
            orderDetailList.DataSource = db.OrderDetails.Where(a => a.OrderId == db.Orders.FirstOrDefault().OrderId).ToList();
        }

        private void orderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderList.SelectedRows.Count > 0)
            {
                int? selectedId = (int)orderList.SelectedRows[0].Cells["OrderId"].Value;
                orderDetailList.DataSource = db.OrderDetails.Where((a) => a.OrderId == selectedId).ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            orderList.DataSource = db.Orders.Where(a => a.OrderId.ToString().Contains(txtKeyword.Text));
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmAddOrder frmAddOrder = new frmAddOrder();
            frmAddOrder.ShowDialog();
            LoadData();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (orderList.SelectedRows.Count > 0)
            {
                int Id = (int)orderList.SelectedRows[0].Cells["OrderId"].Value;

                var deleteOrder = db.Orders.Find(Id);
                if (deleteOrder != null)
                {
                    db.Orders.Remove(deleteOrder);
                    db.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select item to delete!");
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (orderList.SelectedRows.Count > 0)
            {
                int Id = (int)orderList.SelectedRows[0].Cells["OrderId"].Value;

                var selectedOrder = db.Orders.Find(Id);
                if (selectedOrder == null)
                {
                    MessageBox.Show("Order has not existed !");
                }
                else
                {
                    frmUpdateOrder frmUpdateOrder = new frmUpdateOrder(selectedOrder);
                    frmUpdateOrder.ShowDialog();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select item to update!");
            }

        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (orderDetailList.SelectedRows.Count > 0)
            {
                int orderId = (int)orderDetailList.SelectedRows[0].Cells["OrderId"].Value;
                int prodId = (int)orderDetailList.SelectedRows[0].Cells["ProductId"].Value;

                var deleteOrderDetail = db.OrderDetails.Find(orderId, prodId);
                if (deleteOrderDetail != null)
                {
                    db.OrderDetails.Remove(deleteOrderDetail);
                    db.SaveChanges();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("This detail has not existed!");
                }
            }
            else
            {
                MessageBox.Show("Please select item to delete!");
            }
        }

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (orderList.SelectedRows.Count > 0)
            {
                int Id = (int)orderList.SelectedRows[0].Cells["OrderId"].Value;

                var selectedOrder = db.Orders.Find(Id);
                if (selectedOrder == null)
                {
                    MessageBox.Show("Order has not existed !");
                }
                else
                {
                    frmAddOrderDetail frmAddOrderDetail = new frmAddOrderDetail(selectedOrder);
                    frmAddOrderDetail.ShowDialog();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select item to update!");
            }
        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            if (orderDetailList.SelectedRows.Count > 0)
            {
                int orderId = (int)orderDetailList.SelectedRows[0].Cells["OrderId"].Value;
                int prodId = (int)orderDetailList.SelectedRows[0].Cells["ProductId"].Value;

                var selectedOrder = db.OrderDetails.Find(orderId, prodId);
                if (selectedOrder == null)
                {
                    MessageBox.Show("Order has not existed !");
                }
                else
                {
                    frmUpdateOrderDetail frmUpdateOrderDetail = new frmUpdateOrderDetail(selectedOrder);
                    frmUpdateOrderDetail.ShowDialog();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select item to update!");
            }
        }
    }
}
