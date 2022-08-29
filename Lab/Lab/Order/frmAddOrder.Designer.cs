namespace SalesWinApp
{
    partial class frmAddOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intOrderId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.memberList = new System.Windows.Forms.ComboBox();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.requireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.shippedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.decFreight = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decFreight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "OrderDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "MemberId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "RequireDate";
            // 
            // intOrderId
            // 
            this.intOrderId.Location = new System.Drawing.Point(110, 29);
            this.intOrderId.Name = "intOrderId";
            this.intOrderId.Size = new System.Drawing.Size(200, 23);
            this.intOrderId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "ShippedDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Freight";
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(110, 57);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(200, 23);
            this.memberList.TabIndex = 8;
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(110, 86);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(200, 23);
            this.orderDatePicker.TabIndex = 9;
            // 
            // requireDatePicker
            // 
            this.requireDatePicker.Location = new System.Drawing.Point(110, 115);
            this.requireDatePicker.Name = "requireDatePicker";
            this.requireDatePicker.Size = new System.Drawing.Size(200, 23);
            this.requireDatePicker.TabIndex = 10;
            // 
            // shippedDatePicker
            // 
            this.shippedDatePicker.Location = new System.Drawing.Point(110, 144);
            this.shippedDatePicker.Name = "shippedDatePicker";
            this.shippedDatePicker.Size = new System.Drawing.Size(200, 23);
            this.shippedDatePicker.TabIndex = 11;
            // 
            // decFreight
            // 
            this.decFreight.Location = new System.Drawing.Point(110, 173);
            this.decFreight.Name = "decFreight";
            this.decFreight.Size = new System.Drawing.Size(200, 23);
            this.decFreight.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 269);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.decFreight);
            this.Controls.Add(this.shippedDatePicker);
            this.Controls.Add(this.requireDatePicker);
            this.Controls.Add(this.orderDatePicker);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.intOrderId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddOrder";
            this.Text = "Add Order";
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decFreight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown intOrderId;
        private Label label5;
        private Label label6;
        private ComboBox memberList;
        private DateTimePicker orderDatePicker;
        private DateTimePicker requireDatePicker;
        private DateTimePicker shippedDatePicker;
        private NumericUpDown decFreight;
        private Button btnAdd;
    }
}