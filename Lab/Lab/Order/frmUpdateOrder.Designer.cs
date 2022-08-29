namespace SalesWinApp
{
    partial class frmUpdateOrder
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
            this.decFreight = new System.Windows.Forms.NumericUpDown();
            this.shippedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.requireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.memberList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intOrderId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decFreight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 28);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // decFreight
            // 
            this.decFreight.Location = new System.Drawing.Point(138, 193);
            this.decFreight.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.decFreight.Name = "decFreight";
            this.decFreight.Size = new System.Drawing.Size(200, 23);
            this.decFreight.TabIndex = 25;
            // 
            // shippedDatePicker
            // 
            this.shippedDatePicker.Location = new System.Drawing.Point(138, 164);
            this.shippedDatePicker.Name = "shippedDatePicker";
            this.shippedDatePicker.Size = new System.Drawing.Size(200, 23);
            this.shippedDatePicker.TabIndex = 24;
            // 
            // requireDatePicker
            // 
            this.requireDatePicker.Location = new System.Drawing.Point(138, 135);
            this.requireDatePicker.Name = "requireDatePicker";
            this.requireDatePicker.Size = new System.Drawing.Size(200, 23);
            this.requireDatePicker.TabIndex = 23;
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(138, 106);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(200, 23);
            this.orderDatePicker.TabIndex = 22;
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(138, 77);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(200, 23);
            this.memberList.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Freight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "ShippedDate";
            // 
            // intOrderId
            // 
            this.intOrderId.Location = new System.Drawing.Point(138, 49);
            this.intOrderId.Name = "intOrderId";
            this.intOrderId.ReadOnly = true;
            this.intOrderId.Size = new System.Drawing.Size(200, 23);
            this.intOrderId.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "RequireDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "MemberId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "OrderDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "OrderId";
            // 
            // frmUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 353);
            this.Controls.Add(this.btnUpdate);
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
            this.Name = "frmUpdateOrder";
            this.Text = "Update Order";
            ((System.ComponentModel.ISupportInitialize)(this.decFreight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intOrderId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private NumericUpDown decFreight;
        private DateTimePicker shippedDatePicker;
        private DateTimePicker requireDatePicker;
        private DateTimePicker orderDatePicker;
        private ComboBox memberList;
        private Label label6;
        private Label label5;
        private NumericUpDown intOrderId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}