namespace TradeOrgSistem
{
    partial class Query6Form
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
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalSalesVolume = new System.Windows.Forms.Label();
            this.lblResultRetailLocation = new System.Windows.Forms.Label();
            this.lblResultSellerName = new System.Windows.Forms.Label();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtRetailLocationName = new System.Windows.Forms.TextBox();
            this.lblMinVolume = new System.Windows.Forms.Label();
            this.txtRetailLocationId = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(634, 427);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(255, 36);
            this.lblTotalRevenue.TabIndex = 67;
            this.lblTotalRevenue.Text = "Общая выручка:";
            // 
            // lblTotalSalesVolume
            // 
            this.lblTotalSalesVolume.AutoSize = true;
            this.lblTotalSalesVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesVolume.Location = new System.Drawing.Point(634, 354);
            this.lblTotalSalesVolume.Name = "lblTotalSalesVolume";
            this.lblTotalSalesVolume.Size = new System.Drawing.Size(345, 36);
            this.lblTotalSalesVolume.TabIndex = 66;
            this.lblTotalSalesVolume.Text = "Общий объем продаж:";
            // 
            // lblResultRetailLocation
            // 
            this.lblResultRetailLocation.AutoSize = true;
            this.lblResultRetailLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultRetailLocation.Location = new System.Drawing.Point(634, 281);
            this.lblResultRetailLocation.Name = "lblResultRetailLocation";
            this.lblResultRetailLocation.Size = new System.Drawing.Size(242, 36);
            this.lblResultRetailLocation.TabIndex = 65;
            this.lblResultRetailLocation.Text = "Торговая точка:";
            // 
            // lblResultSellerName
            // 
            this.lblResultSellerName.AutoSize = true;
            this.lblResultSellerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSellerName.Location = new System.Drawing.Point(634, 208);
            this.lblResultSellerName.Name = "lblResultSellerName";
            this.lblResultSellerName.Size = new System.Drawing.Size(167, 36);
            this.lblResultSellerName.TabIndex = 63;
            this.lblResultSellerName.Text = "Продавец:";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(48, 696);
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
            this.lblStartDate.Location = new System.Drawing.Point(48, 500);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(252, 36);
            this.lblStartDate.TabIndex = 61;
            this.lblStartDate.Text = "Начальная дата";
            // 
            // txtRetailLocationName
            // 
            this.txtRetailLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationName.Location = new System.Drawing.Point(48, 466);
            this.txtRetailLocationName.Name = "txtRetailLocationName";
            this.txtRetailLocationName.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationName.TabIndex = 60;
            // 
            // lblMinVolume
            // 
            this.lblMinVolume.AutoSize = true;
            this.lblMinVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinVolume.Location = new System.Drawing.Point(48, 427);
            this.lblMinVolume.Name = "lblMinVolume";
            this.lblMinVolume.Size = new System.Drawing.Size(382, 36);
            this.lblMinVolume.TabIndex = 59;
            this.lblMinVolume.Text = "Название торговой точки";
            // 
            // txtRetailLocationId
            // 
            this.txtRetailLocationId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationId.Location = new System.Drawing.Point(48, 393);
            this.txtRetailLocationId.Name = "txtRetailLocationId";
            this.txtRetailLocationId.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationId.TabIndex = 58;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(42, 354);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(273, 36);
            this.lblProductType.TabIndex = 57;
            this.lblProductType.Text = "ID торговой точки";
            // 
            // txtSellerName
            // 
            this.txtSellerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtSellerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSellerName.Location = new System.Drawing.Point(48, 320);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(526, 31);
            this.txtSellerName.TabIndex = 56;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(48, 281);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(223, 36);
            this.lblProductName.TabIndex = 55;
            this.lblProductName.Text = "Имя процавца";
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(48, 247);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(526, 31);
            this.txtSellerId.TabIndex = 54;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(48, 208);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(193, 36);
            this.lblProductId.TabIndex = 53;
            this.lblProductId.Text = "ID продавца";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(40, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1330, 86);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Получить данные о выработке отдельно взятого продавца отдельно взятой\r\nторговой т" +
    "очки за указанный период.\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 68;
            this.label1.Text = "Конечная дата";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(54, 539);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(520, 31);
            this.dtpStartDate.TabIndex = 69;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(54, 616);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(520, 31);
            this.dtpEndDate.TabIndex = 70;
            // 
            // Query6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 821);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.lblTotalSalesVolume);
            this.Controls.Add(this.lblResultRetailLocation);
            this.Controls.Add(this.lblResultSellerName);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtRetailLocationName);
            this.Controls.Add(this.lblMinVolume);
            this.Controls.Add(this.txtRetailLocationId);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtSellerName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtSellerId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "Query6Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запрос 6";
            this.Load += new System.EventHandler(this.Query6Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalSalesVolume;
        private System.Windows.Forms.Label lblResultRetailLocation;
        private System.Windows.Forms.Label lblResultSellerName;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtRetailLocationName;
        private System.Windows.Forms.Label lblMinVolume;
        private System.Windows.Forms.TextBox txtRetailLocationId;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}