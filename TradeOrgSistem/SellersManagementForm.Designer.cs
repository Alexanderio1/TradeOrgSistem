namespace TradeOrgSistem
{
    partial class SellersManagementForm
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
            this.btnDeleteSeller = new System.Windows.Forms.Button();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.txtNewSellerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewSellerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditSeller = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSellers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewRetailLocationId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewSellerSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditSellerSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditRetailLocationId = new System.Windows.Forms.TextBox();
            this.txtEditSellerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSeller.Location = new System.Drawing.Point(910, 477);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(478, 66);
            this.btnDeleteSeller.TabIndex = 57;
            this.btnDeleteSeller.Text = "Удалить продавца";
            this.btnDeleteSeller.UseVisualStyleBackColor = true;
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeller.Location = new System.Drawing.Point(105, 477);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(478, 66);
            this.btnAddSeller.TabIndex = 56;
            this.btnAddSeller.Text = "Добавить продавца";
            this.btnAddSeller.UseVisualStyleBackColor = true;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // txtNewSellerName
            // 
            this.txtNewSellerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewSellerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewSellerName.Location = new System.Drawing.Point(105, 243);
            this.txtNewSellerName.Name = "txtNewSellerName";
            this.txtNewSellerName.Size = new System.Drawing.Size(478, 31);
            this.txtNewSellerName.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 36);
            this.label3.TabIndex = 54;
            this.label3.Text = "Имя продавца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 36);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID продавца";
            // 
            // txtNewSellerId
            // 
            this.txtNewSellerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewSellerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewSellerId.Location = new System.Drawing.Point(105, 170);
            this.txtNewSellerId.Name = "txtNewSellerId";
            this.txtNewSellerId.Size = new System.Drawing.Size(478, 31);
            this.txtNewSellerId.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 49);
            this.label1.TabIndex = 51;
            this.label1.Text = "Добавление нового продавца";
            // 
            // btnEditSeller
            // 
            this.btnEditSeller.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSeller.Location = new System.Drawing.Point(910, 377);
            this.btnEditSeller.Name = "btnEditSeller";
            this.btnEditSeller.Size = new System.Drawing.Size(478, 66);
            this.btnEditSeller.TabIndex = 47;
            this.btnEditSeller.Text = "Редактировать продавца";
            this.btnEditSeller.UseVisualStyleBackColor = true;
            this.btnEditSeller.Click += new System.EventHandler(this.btnEditSeller_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(901, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(726, 49);
            this.label5.TabIndex = 49;
            this.label5.Text = "Редактирование/удаление продавца";
            // 
            // dgvSellers
            // 
            this.dgvSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSellers.Location = new System.Drawing.Point(0, 600);
            this.dgvSellers.Name = "dgvSellers";
            this.dgvSellers.ReadOnly = true;
            this.dgvSellers.RowHeadersWidth = 82;
            this.dgvSellers.RowTemplate.Height = 33;
            this.dgvSellers.Size = new System.Drawing.Size(1712, 343);
            this.dgvSellers.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 36);
            this.label4.TabIndex = 59;
            this.label4.Text = "ID торговой точки";
            // 
            // txtNewRetailLocationId
            // 
            this.txtNewRetailLocationId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewRetailLocationId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewRetailLocationId.Location = new System.Drawing.Point(105, 316);
            this.txtNewRetailLocationId.Name = "txtNewRetailLocationId";
            this.txtNewRetailLocationId.Size = new System.Drawing.Size(478, 31);
            this.txtNewRetailLocationId.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 36);
            this.label7.TabIndex = 61;
            this.label7.Text = "Зарплата";
            // 
            // txtNewSellerSalary
            // 
            this.txtNewSellerSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewSellerSalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewSellerSalary.Location = new System.Drawing.Point(105, 389);
            this.txtNewSellerSalary.Name = "txtNewSellerSalary";
            this.txtNewSellerSalary.Size = new System.Drawing.Size(478, 31);
            this.txtNewSellerSalary.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(907, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 36);
            this.label6.TabIndex = 67;
            this.label6.Text = "Новая зарплата";
            // 
            // txtEditSellerSalary
            // 
            this.txtEditSellerSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditSellerSalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditSellerSalary.Location = new System.Drawing.Point(910, 316);
            this.txtEditSellerSalary.Name = "txtEditSellerSalary";
            this.txtEditSellerSalary.Size = new System.Drawing.Size(478, 31);
            this.txtEditSellerSalary.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(907, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 36);
            this.label8.TabIndex = 65;
            this.label8.Text = "Новый ID торговой точки";
            // 
            // txtEditRetailLocationId
            // 
            this.txtEditRetailLocationId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditRetailLocationId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditRetailLocationId.Location = new System.Drawing.Point(910, 243);
            this.txtEditRetailLocationId.Name = "txtEditRetailLocationId";
            this.txtEditRetailLocationId.Size = new System.Drawing.Size(478, 31);
            this.txtEditRetailLocationId.TabIndex = 64;
            // 
            // txtEditSellerName
            // 
            this.txtEditSellerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditSellerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditSellerName.Location = new System.Drawing.Point(910, 170);
            this.txtEditSellerName.Name = "txtEditSellerName";
            this.txtEditSellerName.Size = new System.Drawing.Size(478, 31);
            this.txtEditSellerName.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(904, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 36);
            this.label9.TabIndex = 62;
            this.label9.Text = "Новое имя продавца";
            // 
            // SellersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 943);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEditSellerSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEditRetailLocationId);
            this.Controls.Add(this.txtEditSellerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewSellerSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewRetailLocationId);
            this.Controls.Add(this.btnDeleteSeller);
            this.Controls.Add(this.btnAddSeller);
            this.Controls.Add(this.txtNewSellerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewSellerId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditSeller);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSellers);
            this.Name = "SellersManagementForm";
            this.Text = "SellersManagementForm";
            this.Load += new System.EventHandler(this.SellersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSeller;
        private System.Windows.Forms.Button btnAddSeller;
        private System.Windows.Forms.TextBox txtNewSellerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewSellerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditSeller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSellers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewRetailLocationId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewSellerSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditSellerSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditRetailLocationId;
        private System.Windows.Forms.TextBox txtEditSellerName;
        private System.Windows.Forms.Label label9;
    }
}