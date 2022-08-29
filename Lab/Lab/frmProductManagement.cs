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

namespace SalesWinApp;

public partial class frmProductManagement : Form
{
    private SalesManagementContext db = InstanceDBContext.Instance;
    public frmProductManagement()
    {
        InitializeComponent();
    }

    private void LoadData()
    {
        var productList = db.Products.ToList();
        dgvProducts.DataSource = productList;
    }
    private void frmProductManagement_Load(object sender, EventArgs e)
    {
        LoadData();
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        //if (member.Email.Contains("admin")) {
        if (dgvProducts.SelectedRows.Count > 0)
        {
            var result = MessageBox.Show("Are you want to delete this product?", "Delete confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductId"].Value.ToString());
                Product deletedProduct = db.Products.Find(productId);
                if (deletedProduct != null)
                {
                    try
                    {
                        db.Products.Remove(deletedProduct);
                        db.SaveChanges();
                        LoadData();
                    }catch (Exception ex)
                    {
                        MessageBox.Show("This product is saved in an order detail, and can't be deleted until the order is completed. Delete the order detail first to delete this product.");
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
    private int productId;
    private string productName;
    private decimal price;
    private int stock;

    private void btnSearch_Click(object sender, EventArgs e)
    {
        productName = txtProductName.Text;
        dgvProducts.DataSource=db.Products.Where(x=>x.ProductName.Contains(productName)).ToList();
    }

    private void btnSearchStock_Click(object sender, EventArgs e)
    {
        stock = decimal.ToInt32(numUnitStock.Value);
        dgvProducts.DataSource=db.Products.Where(x=>x.UnitslnStock==stock).ToList();
    }

    private void btnSearchPrice_Click(object sender, EventArgs e)
    {
        price = numUnitPrice.Value;
        dgvProducts.DataSource=db.Products.Where(x=>x.UnitPrice==price).ToList();
    }

    private void btnSearchId_Click(object sender, EventArgs e)
    {
        productId = Convert.ToInt32(numProductId.Value);
        dgvProducts.DataSource=db.Products.Where(x=>x.ProductId==productId).ToList();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmAddUpdateProduct frmAddUpdateProduct = new frmAddUpdateProduct();
        frmAddUpdateProduct.ShowDialog();
        LoadData();
    }
    public static Product updateProduct;
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        //if (member.Email.Contains("admin")) {
        if (dgvProducts.SelectedRows.Count > 0)
        {
            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductId"].Value.ToString());
            updateProduct = db.Products.Find(productId);
            if (updateProduct != null)
            {
                frmAddUpdateProduct frmAddUpdateProduct= new frmAddUpdateProduct();
                updateProduct = db.Products.Find(productId);
                frmAddUpdateProduct.ShowDialog();
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