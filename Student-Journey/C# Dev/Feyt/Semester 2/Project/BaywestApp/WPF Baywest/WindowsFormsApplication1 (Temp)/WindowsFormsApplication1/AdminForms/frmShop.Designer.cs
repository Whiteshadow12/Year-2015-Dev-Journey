﻿namespace WindowsFormsApplication1
{
    partial class frmShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpTxtBox = new System.Windows.Forms.GroupBox();
            this.txtShopSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtShopID = new System.Windows.Forms.TextBox();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.grpTxtBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(87, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpTxtBox
            // 
            this.grpTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.grpTxtBox.Controls.Add(this.txtShopSize);
            this.grpTxtBox.Controls.Add(this.label3);
            this.grpTxtBox.Controls.Add(this.label2);
            this.grpTxtBox.Controls.Add(this.label1);
            this.grpTxtBox.Controls.Add(this.txtShopName);
            this.grpTxtBox.Controls.Add(this.txtShopID);
            this.grpTxtBox.Location = new System.Drawing.Point(12, 35);
            this.grpTxtBox.Name = "grpTxtBox";
            this.grpTxtBox.Size = new System.Drawing.Size(228, 239);
            this.grpTxtBox.TabIndex = 4;
            this.grpTxtBox.TabStop = false;
            this.grpTxtBox.Text = "TextBox";
            // 
            // txtShopSize
            // 
            this.txtShopSize.Location = new System.Drawing.Point(84, 91);
            this.txtShopSize.Name = "txtShopSize";
            this.txtShopSize.Size = new System.Drawing.Size(100, 20);
            this.txtShopSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shop Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shop Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop ID";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(84, 55);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(100, 20);
            this.txtShopName.TabIndex = 1;
            // 
            // txtShopID
            // 
            this.txtShopID.Location = new System.Drawing.Point(84, 19);
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(100, 20);
            this.txtShopID.TabIndex = 0;
            // 
            // dgvShop
            // 
            this.dgvShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Location = new System.Drawing.Point(395, 28);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.Size = new System.Drawing.Size(462, 440);
            this.dgvShop.TabIndex = 6;
            this.dgvShop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShop_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.viewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentalAgreementToolStripMenuItem,
            this.shopCallToolStripMenuItem,
            this.shopServiceToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.viewToolStripMenuItem.Text = "Quick Access";
            // 
            // rentalAgreementToolStripMenuItem
            // 
            this.rentalAgreementToolStripMenuItem.Name = "rentalAgreementToolStripMenuItem";
            this.rentalAgreementToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rentalAgreementToolStripMenuItem.Text = "RentalAgreement";
            this.rentalAgreementToolStripMenuItem.Click += new System.EventHandler(this.rentalAgreementToolStripMenuItem_Click);
            // 
            // shopCallToolStripMenuItem
            // 
            this.shopCallToolStripMenuItem.Name = "shopCallToolStripMenuItem";
            this.shopCallToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.shopCallToolStripMenuItem.Text = "ShopCall";
            // 
            // shopServiceToolStripMenuItem
            // 
            this.shopServiceToolStripMenuItem.Name = "shopServiceToolStripMenuItem";
            this.shopServiceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.shopServiceToolStripMenuItem.Text = "ShopService";
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Baywest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvShop);
            this.Controls.Add(this.grpTxtBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpTxtBox.ResumeLayout(false);
            this.grpTxtBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpTxtBox;
        private System.Windows.Forms.TextBox txtShopSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.TextBox txtShopID;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopServiceToolStripMenuItem;
    }
}