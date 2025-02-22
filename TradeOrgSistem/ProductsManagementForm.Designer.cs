namespace TradeOrgSistem
{
    partial class ProductsManagementForm
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
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.txtEditProductType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtNewProductType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Location = new System.Drawing.Point(859, 316);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(478, 66);
            this.btnEditProduct.TabIndex = 15;
            this.btnEditProduct.Text = "Редактировать товар";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // txtEditProductType
            // 
            this.txtEditProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditProductType.Location = new System.Drawing.Point(859, 243);
            this.txtEditProductType.Name = "txtEditProductType";
            this.txtEditProductType.Size = new System.Drawing.Size(539, 31);
            this.txtEditProductType.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(853, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Новый тип";
            // 
            // txtEditProductName
            // 
            this.txtEditProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditProductName.Location = new System.Drawing.Point(859, 170);
            this.txtEditProductName.Name = "txtEditProductName";
            this.txtEditProductName.Size = new System.Drawing.Size(539, 31);
            this.txtEditProductName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Новое название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(889, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(726, 49);
            this.label5.TabIndex = 17;
            this.label5.Text = "Редактирование выбранного товара";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProducts.Location = new System.Drawing.Point(0, 530);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 82;
            this.dgvProducts.RowTemplate.Height = 33;
            this.dgvProducts.Size = new System.Drawing.Size(1691, 420);
            this.dgvProducts.TabIndex = 14;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(54, 417);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(478, 66);
            this.btnAddProduct.TabIndex = 28;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtNewProductType
            // 
            this.txtNewProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewProductType.Location = new System.Drawing.Point(54, 316);
            this.txtNewProductType.Name = "txtNewProductType";
            this.txtNewProductType.Size = new System.Drawing.Size(478, 31);
            this.txtNewProductType.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "Тип товара";
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewProductName.Location = new System.Drawing.Point(54, 243);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(478, 31);
            this.txtNewProductName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID товара";
            // 
            // txtNewProductId
            // 
            this.txtNewProductId.Location = new System.Drawing.Point(54, 170);
            this.txtNewProductId.Name = "txtNewProductId";
            this.txtNewProductId.Size = new System.Drawing.Size(478, 31);
            this.txtNewProductId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 49);
            this.label1.TabIndex = 21;
            this.label1.Text = "Добавление нового товара";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(859, 417);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(478, 66);
            this.btnDeleteProduct.TabIndex = 29;
            this.btnDeleteProduct.Text = "Удалить товар";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // ProductsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 950);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtNewProductType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.txtEditProductType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEditProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProducts);
            this.MaximizeBox = false;
            this.Name = "ProductsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление товарами";
            this.Load += new System.EventHandler(this.ProductsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.TextBox txtEditProductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtNewProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}