namespace TradeOrgSistem
{
    partial class Query14Form
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
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetailLocationType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetailLocationName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetailLocationID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(638, 822);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(556, 36);
            this.lblTotalCount.TabIndex = 31;
            this.lblTotalCount.Text = "Общее число активных покупателей:\r\n";
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(644, 184);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 82;
            this.dgvResults.RowTemplate.Height = 33;
            this.dgvResults.Size = new System.Drawing.Size(1030, 610);
            this.dgvResults.TabIndex = 30;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(54, 728);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(520, 66);
            this.btnRunQuery.TabIndex = 29;
            this.btnRunQuery.Text = "Выполнить запрос";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(54, 589);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(520, 31);
            this.dtpEndDate.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 36);
            this.label6.TabIndex = 27;
            this.label6.Text = "Конечная дата";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(54, 516);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(520, 31);
            this.dtpStartDate.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "Начальная дата\r\n";
            // 
            // txtRetailLocationType
            // 
            this.txtRetailLocationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationType.Location = new System.Drawing.Point(48, 442);
            this.txtRetailLocationType.Name = "txtRetailLocationType";
            this.txtRetailLocationType.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationType.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "Тип торговой точки";
            // 
            // txtRetailLocationName
            // 
            this.txtRetailLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationName.Location = new System.Drawing.Point(48, 369);
            this.txtRetailLocationName.Name = "txtRetailLocationName";
            this.txtRetailLocationName.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название торговой точки";
            // 
            // txtRetailLocationID
            // 
            this.txtRetailLocationID.Location = new System.Drawing.Point(48, 296);
            this.txtRetailLocationID.Name = "txtRetailLocationID";
            this.txtRetailLocationID.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID торговой точки";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(148, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1444, 86);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Получить сведения о наиболее активных покупателях по всем торговым точкам, \r\nпо т" +
    "орговым точкам указанного типа, по данной торговой точке.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Query14Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 982);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRetailLocationType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRetailLocationName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRetailLocationID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "Query14Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query14Form";
            this.Load += new System.EventHandler(this.Query14Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetailLocationType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetailLocationName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetailLocationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}