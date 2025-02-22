namespace TradeOrgSistem
{
    partial class Query7Form
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSalesVolume = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtRetailLocationName = new System.Windows.Forms.TextBox();
            this.lblMinVolume = new System.Windows.Forms.Label();
            this.txtRetailLocationID = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtRetailLocationType = new System.Windows.Forms.TextBox();
            this.lblRetailLocationType = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(39, 625);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(520, 31);
            this.dtpEndDate.TabIndex = 88;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(39, 548);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(520, 31);
            this.dtpStartDate.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 86;
            this.label1.Text = "Конечная дата";
            // 
            // lblTotalSalesVolume
            // 
            this.lblTotalSalesVolume.AutoSize = true;
            this.lblTotalSalesVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesVolume.Location = new System.Drawing.Point(619, 363);
            this.lblTotalSalesVolume.Name = "lblTotalSalesVolume";
            this.lblTotalSalesVolume.Size = new System.Drawing.Size(345, 36);
            this.lblTotalSalesVolume.TabIndex = 84;
            this.lblTotalSalesVolume.Text = "Общий объем продаж:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(619, 217);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(108, 36);
            this.lblProductName.TabIndex = 82;
            this.lblProductName.Text = "Товар:";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(33, 705);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(520, 66);
            this.btnRunQuery.TabIndex = 81;
            this.btnRunQuery.Text = "Выполнить запрос";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(33, 509);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(252, 36);
            this.lblStartDate.TabIndex = 80;
            this.lblStartDate.Text = "Начальная дата";
            // 
            // txtRetailLocationName
            // 
            this.txtRetailLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationName.Location = new System.Drawing.Point(33, 402);
            this.txtRetailLocationName.Name = "txtRetailLocationName";
            this.txtRetailLocationName.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationName.TabIndex = 79;
            // 
            // lblMinVolume
            // 
            this.lblMinVolume.AutoSize = true;
            this.lblMinVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinVolume.Location = new System.Drawing.Point(33, 363);
            this.lblMinVolume.Name = "lblMinVolume";
            this.lblMinVolume.Size = new System.Drawing.Size(382, 36);
            this.lblMinVolume.TabIndex = 78;
            this.lblMinVolume.Text = "Название торговой точки";
            // 
            // txtRetailLocationID
            // 
            this.txtRetailLocationID.Location = new System.Drawing.Point(33, 329);
            this.txtRetailLocationID.Name = "txtRetailLocationID";
            this.txtRetailLocationID.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationID.TabIndex = 77;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(27, 290);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(273, 36);
            this.lblProductType.TabIndex = 76;
            this.lblProductType.Text = "ID торговой точки";
            // 
            // txtRetailLocationType
            // 
            this.txtRetailLocationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationType.Location = new System.Drawing.Point(33, 475);
            this.txtRetailLocationType.Name = "txtRetailLocationType";
            this.txtRetailLocationType.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationType.TabIndex = 75;
            // 
            // lblRetailLocationType
            // 
            this.lblRetailLocationType.AutoSize = true;
            this.lblRetailLocationType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailLocationType.Location = new System.Drawing.Point(33, 436);
            this.lblRetailLocationType.Name = "lblRetailLocationType";
            this.lblRetailLocationType.Size = new System.Drawing.Size(294, 36);
            this.lblRetailLocationType.TabIndex = 74;
            this.lblRetailLocationType.Text = "Тип торговой точки";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(33, 256);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(526, 31);
            this.txtProductId.TabIndex = 73;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(33, 217);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(155, 36);
            this.lblProductId.TabIndex = 72;
            this.lblProductId.Text = "ID товара";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1406, 129);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "Получить данные об объеме продаж указанного товара за некоторый период\r\nпо всем т" +
    "орговым точкам, по торговым точкам заданного типа, по конкретной\r\nторговой точке" +
    ".\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Query7Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 894);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalSalesVolume);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtRetailLocationName);
            this.Controls.Add(this.lblMinVolume);
            this.Controls.Add(this.txtRetailLocationID);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtRetailLocationType);
            this.Controls.Add(this.lblRetailLocationType);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "Query7Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запрос 7";
            this.Load += new System.EventHandler(this.Query7Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSalesVolume;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtRetailLocationName;
        private System.Windows.Forms.Label lblMinVolume;
        private System.Windows.Forms.TextBox txtRetailLocationID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtRetailLocationType;
        private System.Windows.Forms.Label lblRetailLocationType;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblTitle;
    }
}