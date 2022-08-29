namespace SalesWinApp
{
    partial class frmUpdateProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.numProductId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCategoryId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product ID";
            // 
            // numProductId
            // 
            this.numProductId.Location = new System.Drawing.Point(134, 32);
            this.numProductId.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numProductId.Name = "numProductId";
            this.numProductId.Size = new System.Drawing.Size(169, 23);
            this.numProductId.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category ID";
            // 
            // numCategoryId
            // 
            this.numCategoryId.Location = new System.Drawing.Point(134, 66);
            this.numCategoryId.Name = "numCategoryId";
            this.numCategoryId.Size = new System.Drawing.Size(169, 23);
            this.numCategoryId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Weight";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(134, 153);
            this.numPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(169, 23);
            this.numPrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unit Stock";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(134, 182);
            this.numStock.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(169, 23);
            this.numStock.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(134, 95);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(169, 23);
            this.txtProductName.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(134, 124);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(169, 23);
            this.txtWeight.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 313);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numCategoryId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numProductId);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateProduct";
            this.Text = "frmUpdateProduct";
            this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown numProductId;
        private Label label2;
        private NumericUpDown numCategoryId;
        private Label label4;
        private Label label6;
        private Label label7;
        private NumericUpDown numPrice;
        private Label label5;
        private NumericUpDown numStock;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private Button btnUpdate;
    }
}