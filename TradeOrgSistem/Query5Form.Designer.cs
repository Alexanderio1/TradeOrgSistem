namespace TradeOrgSistem
{
    partial class Query5Form
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
            this.lblAverageRevenue = new System.Windows.Forms.Label();
            this.txtRetailLocationType = new System.Windows.Forms.TextBox();
            this.lblAverageSalesVolume = new System.Windows.Forms.Label();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblAverageRevenue
            // 
            this.lblAverageRevenue.AutoSize = true;
            this.lblAverageRevenue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageRevenue.Location = new System.Drawing.Point(611, 287);
            this.lblAverageRevenue.Name = "lblAverageRevenue";
            this.lblAverageRevenue.Size = new System.Drawing.Size(577, 36);
            this.lblAverageRevenue.TabIndex = 65;
            this.lblAverageRevenue.Text = "Средняя выручка на одного продавца:";
            // 
            // txtRetailLocationType
            // 
            this.txtRetailLocationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationType.Location = new System.Drawing.Point(49, 399);
            this.txtRetailLocationType.Name = "txtRetailLocationType";
            this.txtRetailLocationType.Size = new System.Drawing.Size(519, 31);
            this.txtRetailLocationType.TabIndex = 64;
            // 
            // lblAverageSalesVolume
            // 
            this.lblAverageSalesVolume.AutoSize = true;
            this.lblAverageSalesVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSalesVolume.Location = new System.Drawing.Point(611, 214);
            this.lblAverageSalesVolume.Name = "lblAverageSalesVolume";
            this.lblAverageSalesVolume.Size = new System.Drawing.Size(660, 36);
            this.lblAverageSalesVolume.TabIndex = 63;
            this.lblAverageSalesVolume.Text = "средний объём продаж на одного продавца:";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(48, 488);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(520, 66);
            this.btnRunQuery.TabIndex = 62;
            this.btnRunQuery.Text = "Выполнить запрос";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(43, 360);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(294, 36);
            this.lblStartDate.TabIndex = 61;
            this.lblStartDate.Text = "Тип торговой точки";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(201, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1273, 86);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Получить данные о выработке на одного продавца за указанный \r\nпериод по всем торг" +
    "овым точкам, по торговым точкам заданного типа.\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(43, 287);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(230, 36);
            this.lblProductName.TabIndex = 55;
            this.lblProductName.Text = "Конечная дата";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(43, 214);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(252, 36);
            this.lblProductId.TabIndex = 53;
            this.lblProductId.Text = "Начальная дата";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(49, 254);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(519, 31);
            this.dtpStartDate.TabIndex = 66;
            this.dtpStartDate.Value = new System.DateTime(2025, 2, 19, 2, 29, 16, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(49, 326);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(519, 31);
            this.dtpEndDate.TabIndex = 67;
            // 
            // Query5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 594);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblAverageRevenue);
            this.Controls.Add(this.txtRetailLocationType);
            this.Controls.Add(this.lblAverageSalesVolume);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "Query5Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запрос 5";
            this.Load += new System.EventHandler(this.Query5Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAverageRevenue;
        private System.Windows.Forms.TextBox txtRetailLocationType;
        private System.Windows.Forms.Label lblAverageSalesVolume;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}