namespace SalesWinApp
{
    partial class frmOrderManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderList = new System.Windows.Forms.DataGridView();
            this.orderDetailList = new System.Windows.Forms.DataGridView();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.btnUpdateOrderDetail = new System.Windows.Forms.Button();
            this.btnAddOrderDetail = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Location = new System.Drawing.Point(29, 42);
            this.orderList.MultiSelect = false;
            this.orderList.Name = "orderList";
            this.orderList.ReadOnly = true;
            this.orderList.RowTemplate.Height = 25;
            this.orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderList.Size = new System.Drawing.Size(338, 296);
            this.orderList.TabIndex = 0;
            this.orderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderList_CellContentClick);
            // 
            // orderDetailList
            // 
            this.orderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailList.Location = new System.Drawing.Point(415, 42);
            this.orderDetailList.MultiSelect = false;
            this.orderDetailList.Name = "orderDetailList";
            this.orderDetailList.ReadOnly = true;
            this.orderDetailList.RowTemplate.Height = 25;
            this.orderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDetailList.Size = new System.Drawing.Size(373, 296);
            this.orderDetailList.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(558, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Details";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(29, 388);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(109, 34);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add an order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(144, 388);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(109, 34);
            this.btnUpdateOrder.TabIndex = 5;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(258, 388);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(109, 34);
            this.btnDeleteOrder.TabIndex = 6;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(668, 388);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(109, 34);
            this.btnDeleteOrderDetail.TabIndex = 9;
            this.btnDeleteOrderDetail.Text = "Delete Detail";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // btnUpdateOrderDetail
            // 
            this.btnUpdateOrderDetail.Location = new System.Drawing.Point(554, 388);
            this.btnUpdateOrderDetail.Name = "btnUpdateOrderDetail";
            this.btnUpdateOrderDetail.Size = new System.Drawing.Size(109, 34);
            this.btnUpdateOrderDetail.TabIndex = 8;
            this.btnUpdateOrderDetail.Text = "Update Detail";
            this.btnUpdateOrderDetail.UseVisualStyleBackColor = true;
            this.btnUpdateOrderDetail.Click += new System.EventHandler(this.btnUpdateOrderDetail_Click);
            // 
            // btnAddOrderDetail
            // 
            this.btnAddOrderDetail.Location = new System.Drawing.Point(415, 388);
            this.btnAddOrderDetail.Name = "btnAddOrderDetail";
            this.btnAddOrderDetail.Size = new System.Drawing.Size(133, 34);
            this.btnAddOrderDetail.TabIndex = 7;
            this.btnAddOrderDetail.Text = "Add product to order";
            this.btnAddOrderDetail.UseVisualStyleBackColor = true;
            this.btnAddOrderDetail.Click += new System.EventHandler(this.btnAddOrderDetail_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(29, 359);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(191, 23);
            this.txtKeyword.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(226, 359);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search by OrderId";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.btnDeleteOrderDetail);
            this.Controls.Add(this.btnUpdateOrderDetail);
            this.Controls.Add(this.btnAddOrderDetail);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDetailList);
            this.Controls.Add(this.orderList);
            this.Name = "frmOrderManagement";
            this.Text = "Order Management";
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView orderList;
        private DataGridView orderDetailList;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Label label2;
        private Button btnAddOrder;
        private Button btnUpdateOrder;
        private Button btnDeleteOrder;
        private Button btnDeleteOrderDetail;
        private Button btnUpdateOrderDetail;
        private Button btnAddOrderDetail;
        private TextBox txtKeyword;
        private Button btnSearch;
    }
}