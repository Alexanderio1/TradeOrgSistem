namespace TradeOrgSistem
{
    partial class CustomersManagementForm
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
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtNewCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.txtEditCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(859, 362);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(478, 66);
            this.btnDeleteCustomer.TabIndex = 45;
            this.btnDeleteCustomer.Text = "Удалить покупателя";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(54, 333);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(478, 66);
            this.btnAddCustomer.TabIndex = 44;
            this.btnAddCustomer.Text = "Добавить покупателя";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtNewCustomerName
            // 
            this.txtNewCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewCustomerName.Location = new System.Drawing.Point(54, 238);
            this.txtNewCustomerName.Name = "txtNewCustomerName";
            this.txtNewCustomerName.Size = new System.Drawing.Size(478, 31);
            this.txtNewCustomerName.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "Имя покупателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID покупателя";
            // 
            // txtNewCustomerId
            // 
            this.txtNewCustomerId.Location = new System.Drawing.Point(54, 165);
            this.txtNewCustomerId.Name = "txtNewCustomerId";
            this.txtNewCustomerId.Size = new System.Drawing.Size(478, 31);
            this.txtNewCustomerId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 49);
            this.label1.TabIndex = 37;
            this.label1.Text = "Добавление нового покупателя\r\n";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Location = new System.Drawing.Point(859, 261);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(478, 66);
            this.btnEditCustomer.TabIndex = 31;
            this.btnEditCustomer.Text = "Редактировать покупателя";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // txtEditCustomerName
            // 
            this.txtEditCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditCustomerName.Location = new System.Drawing.Point(859, 165);
            this.txtEditCustomerName.Name = "txtEditCustomerName";
            this.txtEditCustomerName.Size = new System.Drawing.Size(539, 31);
            this.txtEditCustomerName.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 36);
            this.label6.TabIndex = 32;
            this.label6.Text = "Новое имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(889, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(770, 49);
            this.label5.TabIndex = 33;
            this.label5.Text = "Редактирование/удаление покупателя";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 539);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 82;
            this.dgvCustomers.RowTemplate.Height = 33;
            this.dgvCustomers.Size = new System.Drawing.Size(1701, 420);
            this.dgvCustomers.TabIndex = 30;
            // 
            // CustomersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 959);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtNewCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewCustomerId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.txtEditCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "CustomersManagementForm";
            this.Text = "Управление покупателями";
            this.Load += new System.EventHandler(this.CustomersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtNewCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.TextBox txtEditCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}