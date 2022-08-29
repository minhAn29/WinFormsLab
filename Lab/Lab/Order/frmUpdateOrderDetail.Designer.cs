namespace SalesWinApp
{
    partial class frmUpdateOrderDetail
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.floatDiscount = new System.Windows.Forms.NumericUpDown();
            this.intQuantity = new System.Windows.Forms.NumericUpDown();
            this.productList = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intOrderId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floatDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 31);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // floatDiscount
            // 
            this.floatDiscount.Location = new System.Drawing.Point(156, 145);
            this.floatDiscount.Name = "floatDiscount";
            this.floatDiscount.Size = new System.Drawing.Size(201, 23);
            this.floatDiscount.TabIndex = 24;
            // 
            // intQuantity
            // 
            this.intQuantity.Location = new System.Drawing.Point(156, 113);
            this.intQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.intQuantity.Name = "intQuantity";
            this.intQuantity.Size = new System.Drawing.Size(200, 23);
            this.intQuantity.TabIndex = 23;
            this.intQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(156, 81);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(200, 23);
            this.productList.TabIndex = 22;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(61, 115);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 15);
            this.label.TabIndex = 21;
            this.label.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Discount (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Product Name";
            // 
            // intOrderId
            // 
            this.intOrderId.Location = new System.Drawing.Point(156, 50);
            this.intOrderId.Name = "intOrderId";
            this.intOrderId.ReadOnly = true;
            this.intOrderId.Size = new System.Drawing.Size(200, 23);
            this.intOrderId.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Order ID";
            // 
            // frmUpdateOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 276);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.floatDiscount);
            this.Controls.Add(this.intQuantity);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intOrderId);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateOrderDetail";
            this.Text = "Update Order Detail";
            this.Load += new System.EventHandler(this.frmUpdateOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.floatDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private NumericUpDown floatDiscount;
        private NumericUpDown intQuantity;
        private ComboBox productList;
        private Label label;
        private Label label5;
        private Label label2;
        private NumericUpDown intOrderId;
        private Label label1;
    }
}