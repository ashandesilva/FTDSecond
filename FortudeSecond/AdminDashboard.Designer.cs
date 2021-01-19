namespace FortudeSecond
{
    partial class AdminDashboard
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
            this.NavRegister = new System.Windows.Forms.Button();
            this.NavOrder = new System.Windows.Forms.Button();
            this.NavItem = new System.Windows.Forms.Button();
            this.NavUserMgt = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NavRegister
            // 
            this.NavRegister.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavRegister.Location = new System.Drawing.Point(66, 161);
            this.NavRegister.Name = "NavRegister";
            this.NavRegister.Size = new System.Drawing.Size(225, 34);
            this.NavRegister.TabIndex = 0;
            this.NavRegister.Text = "User Registrartion";
            this.NavRegister.UseVisualStyleBackColor = true;
            this.NavRegister.Click += new System.EventHandler(this.NavRegister_Click);
            // 
            // NavOrder
            // 
            this.NavOrder.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavOrder.Location = new System.Drawing.Point(66, 328);
            this.NavOrder.Name = "NavOrder";
            this.NavOrder.Size = new System.Drawing.Size(225, 34);
            this.NavOrder.TabIndex = 0;
            this.NavOrder.Text = "Order Management";
            this.NavOrder.UseVisualStyleBackColor = true;
            this.NavOrder.Click += new System.EventHandler(this.NavOrder_Click);
            // 
            // NavItem
            // 
            this.NavItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavItem.Location = new System.Drawing.Point(66, 245);
            this.NavItem.Name = "NavItem";
            this.NavItem.Size = new System.Drawing.Size(225, 34);
            this.NavItem.TabIndex = 0;
            this.NavItem.Text = "Item Management";
            this.NavItem.UseVisualStyleBackColor = true;
            this.NavItem.Click += new System.EventHandler(this.NavItem_Click);
            // 
            // NavUserMgt
            // 
            this.NavUserMgt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavUserMgt.Location = new System.Drawing.Point(459, 161);
            this.NavUserMgt.Name = "NavUserMgt";
            this.NavUserMgt.Size = new System.Drawing.Size(225, 34);
            this.NavUserMgt.TabIndex = 0;
            this.NavUserMgt.Text = "User Management";
            this.NavUserMgt.UseVisualStyleBackColor = true;
            this.NavUserMgt.Click += new System.EventHandler(this.NavUserMgt_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(66, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminName.Location = new System.Drawing.Point(165, 60);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(0, 24);
            this.lblAdminName.TabIndex = 3;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogout.Location = new System.Drawing.Point(686, 27);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(88, 24);
            this.linkLabelLogout.TabIndex = 2;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Log Out";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.NavUserMgt);
            this.Controls.Add(this.NavItem);
            this.Controls.Add(this.NavOrder);
            this.Controls.Add(this.NavRegister);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NavRegister;
        private System.Windows.Forms.Button NavOrder;
        private System.Windows.Forms.Button NavItem;
        private System.Windows.Forms.Button NavUserMgt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
    }
}