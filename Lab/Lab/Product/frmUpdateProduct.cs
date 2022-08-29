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
    public partial class frmUpdateProduct : Form
    {
        private SalesManagementContext db = InstanceDBContext.Instance;
        public frmUpdateProduct()
        {
            InitializeComponent();
        }
        private int productId;
        private int categoryId;
        private string productName;
        private string weight;
        private decimal unitPrice;
        private int unitsInStock;

        private bool ValidAddInfo()
        {
            productId = decimal.ToInt32(numProductId.Value);
            categoryId = decimal.ToInt32(numCategoryId.Value);
            productName = txtProductName.Text;
            weight = txtWeight.Text;
            unitPrice = numPrice.Value;
            unitsInStock = decimal.ToInt32(numStock.Value);
            if (productName == null || productName.Equals(""))
            {
                MessageBox.Show("Product name was null");
                txtProductName.Focus();
                return false;
            }
            else if (weight.Equals("") || weight == null)
            {
                MessageBox.Show("Weight was null");
                txtWeight.Focus();
                return false;
            }
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidAddInfo())
            {
                Product product = frmProductManagement.updateProduct;
                if (product != null)
                {
                    product.CategoryId = categoryId;
                    product.ProductName = productName;
                    product.Weight = weight;
                    product.UnitPrice = unitPrice;
                    product.UnitslnStock = unitsInStock;
                    db.Update(product);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You are not allowed to update when click Add button");
                }
            }
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            Product product = frmProductManagement.updateProduct;
            if (product != null)
            {
                numProductId.Value = product.ProductId;
                numProductId.Enabled = false;
                numCategoryId.Value = product.CategoryId;
                txtProductName.Text = product.ProductName;
                txtWeight.Text = product.Weight;
                numPrice.Value = product.UnitPrice;
                numStock.Value = product.UnitslnStock;
            }
        }
    }
}
