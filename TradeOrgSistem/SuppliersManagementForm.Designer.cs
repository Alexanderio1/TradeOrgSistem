namespace TradeOrgSistem
{
    partial class SuppliersManagementForm
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
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtNewSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewSupplierId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.txtEditSupplierName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(859, 355);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(478, 66);
            this.btnDeleteSupplier.TabIndex = 45;
            this.btnDeleteSupplier.Text = "Удалить товар";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(54, 355);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(478, 66);
            this.btnAddSupplier.TabIndex = 44;
            this.btnAddSupplier.Text = "Добавить поставщика";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtNewSupplierName
            // 
            this.txtNewSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewSupplierName.Location = new System.Drawing.Point(54, 239);
            this.txtNewSupplierName.Name = "txtNewSupplierName";
            this.txtNewSupplierName.Size = new System.Drawing.Size(478, 31);
            this.txtNewSupplierName.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "Имя поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID поставщика";
            // 
            // txtNewSupplierId
            // 
            this.txtNewSupplierId.Location = new System.Drawing.Point(54, 166);
            this.txtNewSupplierId.Name = "txtNewSupplierId";
            this.txtNewSupplierId.Size = new System.Drawing.Size(478, 31);
            this.txtNewSupplierId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 49);
            this.label1.TabIndex = 37;
            this.label1.Text = "Добавление поставщика";
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.Location = new System.Drawing.Point(859, 254);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(478, 66);
            this.btnEditSupplier.TabIndex = 31;
            this.btnEditSupplier.Text = "Редактировать товар";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // txtEditSupplierName
            // 
            this.txtEditSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditSupplierName.Location = new System.Drawing.Point(859, 166);
            this.txtEditSupplierName.Name = "txtEditSupplierName";
            this.txtEditSupplierName.Size = new System.Drawing.Size(539, 31);
            this.txtEditSupplierName.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 36);
            this.label6.TabIndex = 32;
            this.label6.Text = "Новое имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(889, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(528, 49);
            this.label5.TabIndex = 33;
            this.label5.Text = "Редактирование/удаление";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSuppliers.Location = new System.Drawing.Point(0, 513);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersWidth = 82;
            this.dgvSuppliers.RowTemplate.Height = 33;
            this.dgvSuppliers.Size = new System.Drawing.Size(1719, 430);
            this.dgvSuppliers.TabIndex = 30;
            // 
            // SuppliersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 943);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.txtNewSupplierName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewSupplierId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.txtEditSupplierName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSuppliers);
            this.MaximizeBox = false;
            this.Name = "SuppliersManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление поставщиками";
            this.Load += new System.EventHandler(this.SuppliersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox txtNewSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewSupplierId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.TextBox txtEditSupplierName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSuppliers;
    }
}