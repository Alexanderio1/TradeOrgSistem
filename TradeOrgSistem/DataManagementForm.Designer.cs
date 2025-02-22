namespace TradeOrgSistem
{
    partial class DataManagementForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageSuppliers = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageRetailLocations = new System.Windows.Forms.Button();
            this.btnManageDeliveries = new System.Windows.Forms.Button();
            this.btnManageSales = new System.Windows.Forms.Button();
            this.btnManageSellers = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управление данными";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnManageSellers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnManageSales, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnManageDeliveries, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnManageRetailLocations, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnManageCustomers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnManageSuppliers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManageProducts, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 636);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageProducts.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.Location = new System.Drawing.Point(3, 3);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(535, 153);
            this.btnManageProducts.TabIndex = 0;
            this.btnManageProducts.Text = "Управление товарами";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnManageSuppliers
            // 
            this.btnManageSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageSuppliers.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSuppliers.Location = new System.Drawing.Point(544, 3);
            this.btnManageSuppliers.Name = "btnManageSuppliers";
            this.btnManageSuppliers.Size = new System.Drawing.Size(535, 153);
            this.btnManageSuppliers.TabIndex = 1;
            this.btnManageSuppliers.Text = "Управление поставщиками";
            this.btnManageSuppliers.UseVisualStyleBackColor = true;
            this.btnManageSuppliers.Click += new System.EventHandler(this.btnManageSuppliers_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageCustomers.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.Location = new System.Drawing.Point(3, 162);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(535, 153);
            this.btnManageCustomers.TabIndex = 2;
            this.btnManageCustomers.Text = "Управление покупателями";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageRetailLocations
            // 
            this.btnManageRetailLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageRetailLocations.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRetailLocations.Location = new System.Drawing.Point(544, 162);
            this.btnManageRetailLocations.Name = "btnManageRetailLocations";
            this.btnManageRetailLocations.Size = new System.Drawing.Size(535, 153);
            this.btnManageRetailLocations.TabIndex = 3;
            this.btnManageRetailLocations.Text = "Управление торговыми точками";
            this.btnManageRetailLocations.UseVisualStyleBackColor = true;
            this.btnManageRetailLocations.Click += new System.EventHandler(this.btnManageRetailLocations_Click);
            // 
            // btnManageDeliveries
            // 
            this.btnManageDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageDeliveries.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDeliveries.Location = new System.Drawing.Point(3, 321);
            this.btnManageDeliveries.Name = "btnManageDeliveries";
            this.btnManageDeliveries.Size = new System.Drawing.Size(535, 153);
            this.btnManageDeliveries.TabIndex = 4;
            this.btnManageDeliveries.Text = "Управление поставками";
            this.btnManageDeliveries.UseVisualStyleBackColor = true;
            this.btnManageDeliveries.Click += new System.EventHandler(this.btnManageDeliveries_Click);
            // 
            // btnManageSales
            // 
            this.btnManageSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageSales.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSales.Location = new System.Drawing.Point(544, 321);
            this.btnManageSales.Name = "btnManageSales";
            this.btnManageSales.Size = new System.Drawing.Size(535, 153);
            this.btnManageSales.TabIndex = 5;
            this.btnManageSales.Text = "Управление продажами";
            this.btnManageSales.UseVisualStyleBackColor = true;
            this.btnManageSales.Click += new System.EventHandler(this.btnManageSales_Click);
            // 
            // btnManageSellers
            // 
            this.btnManageSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageSellers.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSellers.Location = new System.Drawing.Point(3, 480);
            this.btnManageSellers.Name = "btnManageSellers";
            this.btnManageSellers.Size = new System.Drawing.Size(535, 153);
            this.btnManageSellers.TabIndex = 6;
            this.btnManageSellers.Text = "Управление продавцами";
            this.btnManageSellers.UseVisualStyleBackColor = true;
            this.btnManageSellers.Click += new System.EventHandler(this.btnManageSellers_Click);
            // 
            // DataManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 812);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DataManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataManagementForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnManageSellers;
        private System.Windows.Forms.Button btnManageSales;
        private System.Windows.Forms.Button btnManageDeliveries;
        private System.Windows.Forms.Button btnManageRetailLocations;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageSuppliers;
        private System.Windows.Forms.Button btnManageProducts;
    }
}