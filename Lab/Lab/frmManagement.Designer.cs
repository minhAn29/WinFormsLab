namespace SalesWinApp
{
    partial class frmManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStripMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStripMember,
            this.mnuStripOrder,
            this.mnuStripProduct});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStripMember
            // 
            this.mnuStripMember.Checked = true;
            this.mnuStripMember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuStripMember.Name = "mnuStripMember";
            this.mnuStripMember.Size = new System.Drawing.Size(138, 20);
            this.mnuStripMember.Text = "Member Management";
            this.mnuStripMember.Click += new System.EventHandler(this.mnuStripMember_Click);
            // 
            // mnuStripOrder
            // 
            this.mnuStripOrder.Name = "mnuStripOrder";
            this.mnuStripOrder.Size = new System.Drawing.Size(123, 20);
            this.mnuStripOrder.Text = "Order Management";
            this.mnuStripOrder.Click += new System.EventHandler(this.mnuStripOrder_Click);
            // 
            // mnuStripProduct
            // 
            this.mnuStripProduct.Name = "mnuStripProduct";
            this.mnuStripProduct.Size = new System.Drawing.Size(135, 20);
            this.mnuStripProduct.Text = "Product Management";
            this.mnuStripProduct.Click += new System.EventHandler(this.mnuStripProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(816, 489);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelShowForm
            // 
            this.panelShowForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelShowForm.Location = new System.Drawing.Point(34, 47);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(857, 436);
            this.panelShowForm.TabIndex = 7;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 524);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagement";
            this.Load += new System.EventHandler(this.frmManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuStripMember;
        private ToolStripMenuItem mnuStripOrder;
        private ToolStripMenuItem mnuStripProduct;
        private Button btnLogout;
        private Panel panelShowForm;
    }
}