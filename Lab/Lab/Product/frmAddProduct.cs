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
    public partial class frmAddProduct : Form
    {
        private SalesManagementContext db = InstanceDBContext.Instance;
        public frmAddProduct()
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
        private bool IsDuplicated()
        {
            if (db.Products.Find(productId) == null)
                return false;
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidAddInfo())
            {
                if (IsDuplicated() == false)
                {
                    Product addProduct = new Product()
                    {
                        ProductId = productId,
                        CategoryId = categoryId,
                        ProductName = productName,
                        Weight = weight,
                        UnitPrice = unitPrice,
                        UnitslnStock = unitsInStock,
                    };
                    
                    db.Products.Add(addProduct);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Id Duplicated");
                }
            }
        }

    }
}
