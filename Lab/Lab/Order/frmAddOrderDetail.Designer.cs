namespace SalesWinApp
{
    partial class frmAddOrderDetail
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
            this.intOrderId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ComboBox();
            this.intQuantity = new System.Windows.Forms.NumericUpDown();
            this.floatDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // intOrderId
            // 
            this.intOrderId.Location = new System.Drawing.Point(140, 45);
            this.intOrderId.Name = "intOrderId";
            this.intOrderId.ReadOnly = true;
            this.intOrderId.Size = new System.Drawing.Size(200, 23);
            this.intOrderId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "OrderId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ProductId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Discount (%)";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(45, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 15);
            this.label.TabIndex = 12;
            this.label.Text = "Quantity";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(140, 76);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(200, 23);
            this.productList.TabIndex = 13;
            // 
            // intQuantity
            // 
            this.intQuantity.Location = new System.Drawing.Point(140, 108);
            this.intQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intQuantity.Name = "intQuantity";
            this.intQuantity.Size = new System.Drawing.Size(200, 23);
            this.intQuantity.TabIndex = 14;
            this.intQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // floatDiscount
            // 
            this.floatDiscount.Location = new System.Drawing.Point(140, 140);
            this.floatDiscount.Name = "floatDiscount";
            this.floatDiscount.Size = new System.Drawing.Size(201, 23);
            this.floatDiscount.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 31);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 265);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.floatDiscount);
            this.Controls.Add(this.intQuantity);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intOrderId);
            this.Controls.Add(this.label1);
            this.Name = "frmAddOrderDetail";
            this.Text = "Add Order Detail";
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown intOrderId;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label;
        private ComboBox productList;
        private NumericUpDown intQuantity;
        private NumericUpDown floatDiscount;
        private Button btnAdd;
    }
}