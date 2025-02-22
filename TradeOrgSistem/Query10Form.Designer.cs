namespace TradeOrgSistem
{
    partial class Query10Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query10Form));
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultRetailLocation = new System.Windows.Forms.Label();
            this.lblResultSeller = new System.Windows.Forms.Label();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtRetailLocationId = new System.Windows.Forms.TextBox();
            this.lblMinVolume = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtRetailLocationName = new System.Windows.Forms.TextBox();
            this.lblRetailLocationType = new System.Windows.Forms.Label();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbNormalizationFactor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNormalizationValue = new System.Windows.Forms.Label();
            this.lblRatio = new System.Windows.Forms.Label();
            this.lblTotalSalesVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(71, 626);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(520, 31);
            this.dtpEndDate.TabIndex = 104;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(71, 549);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(520, 31);
            this.dtpStartDate.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 102;
            this.label1.Text = "Конечная дата";
            // 
            // lblResultRetailLocation
            // 
            this.lblResultRetailLocation.AutoSize = true;
            this.lblResultRetailLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultRetailLocation.Location = new System.Drawing.Point(651, 364);
            this.lblResultRetailLocation.Name = "lblResultRetailLocation";
            this.lblResultRetailLocation.Size = new System.Drawing.Size(242, 36);
            this.lblResultRetailLocation.TabIndex = 101;
            this.lblResultRetailLocation.Text = "Торговая точка:";
            // 
            // lblResultSeller
            // 
            this.lblResultSeller.AutoSize = true;
            this.lblResultSeller.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSeller.Location = new System.Drawing.Point(651, 291);
            this.lblResultSeller.Name = "lblResultSeller";
            this.lblResultSeller.Size = new System.Drawing.Size(167, 36);
            this.lblResultSeller.TabIndex = 100;
            this.lblResultSeller.Text = "Продавец:";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(71, 816);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(520, 66);
            this.btnRunQuery.TabIndex = 99;
            this.btnRunQuery.Text = "Выполнить запрос";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(65, 510);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(252, 36);
            this.lblStartDate.TabIndex = 98;
            this.lblStartDate.Text = "Начальная дата";
            // 
            // txtRetailLocationId
            // 
            this.txtRetailLocationId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationId.Location = new System.Drawing.Point(65, 403);
            this.txtRetailLocationId.Name = "txtRetailLocationId";
            this.txtRetailLocationId.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationId.TabIndex = 97;
            // 
            // lblMinVolume
            // 
            this.lblMinVolume.AutoSize = true;
            this.lblMinVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinVolume.Location = new System.Drawing.Point(65, 364);
            this.lblMinVolume.Name = "lblMinVolume";
            this.lblMinVolume.Size = new System.Drawing.Size(273, 36);
            this.lblMinVolume.TabIndex = 96;
            this.lblMinVolume.Text = "ID торговой точки";
            // 
            // txtSellerName
            // 
            this.txtSellerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtSellerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSellerName.Location = new System.Drawing.Point(65, 330);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(526, 31);
            this.txtSellerName.TabIndex = 95;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(59, 291);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(223, 36);
            this.lblProductType.TabIndex = 94;
            this.lblProductType.Text = "Имя продавца";
            // 
            // txtRetailLocationName
            // 
            this.txtRetailLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationName.Location = new System.Drawing.Point(65, 476);
            this.txtRetailLocationName.Name = "txtRetailLocationName";
            this.txtRetailLocationName.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationName.TabIndex = 93;
            // 
            // lblRetailLocationType
            // 
            this.lblRetailLocationType.AutoSize = true;
            this.lblRetailLocationType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailLocationType.Location = new System.Drawing.Point(65, 437);
            this.lblRetailLocationType.Name = "lblRetailLocationType";
            this.lblRetailLocationType.Size = new System.Drawing.Size(382, 36);
            this.lblRetailLocationType.TabIndex = 92;
            this.lblRetailLocationType.Text = "Название торговой точки";
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(65, 257);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(526, 31);
            this.txtSellerId.TabIndex = 91;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(65, 218);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(193, 36);
            this.lblProductId.TabIndex = 90;
            this.lblProductId.Text = "ID продавца";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(127, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1406, 172);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = resources.GetString("lblTitle.Text");
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNormalizationFactor
            // 
            this.cmbNormalizationFactor.FormattingEnabled = true;
            this.cmbNormalizationFactor.Location = new System.Drawing.Point(71, 699);
            this.cmbNormalizationFactor.Name = "cmbNormalizationFactor";
            this.cmbNormalizationFactor.Size = new System.Drawing.Size(520, 33);
            this.cmbNormalizationFactor.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 36);
            this.label2.TabIndex = 106;
            this.label2.Text = "Тип нормализации";
            // 
            // lblNormalizationValue
            // 
            this.lblNormalizationValue.AutoSize = true;
            this.lblNormalizationValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalizationValue.Location = new System.Drawing.Point(651, 510);
            this.lblNormalizationValue.Name = "lblNormalizationValue";
            this.lblNormalizationValue.Size = new System.Drawing.Size(401, 36);
            this.lblNormalizationValue.TabIndex = 107;
            this.lblNormalizationValue.Text = "Нормировочное значение:";
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatio.Location = new System.Drawing.Point(651, 587);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(500, 36);
            this.lblRatio.TabIndex = 108;
            this.lblRatio.Text = "Отношение (объем/нормировка):";
            // 
            // lblTotalSalesVolume
            // 
            this.lblTotalSalesVolume.AutoSize = true;
            this.lblTotalSalesVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesVolume.Location = new System.Drawing.Point(651, 437);
            this.lblTotalSalesVolume.Name = "lblTotalSalesVolume";
            this.lblTotalSalesVolume.Size = new System.Drawing.Size(345, 36);
            this.lblTotalSalesVolume.TabIndex = 109;
            this.lblTotalSalesVolume.Text = "Общий объем продаж:";
            // 
            // Query10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 942);
            this.Controls.Add(this.lblTotalSalesVolume);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.lblNormalizationValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNormalizationFactor);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultRetailLocation);
            this.Controls.Add(this.lblResultSeller);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtRetailLocationId);
            this.Controls.Add(this.lblMinVolume);
            this.Controls.Add(this.txtSellerName);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtRetailLocationName);
            this.Controls.Add(this.lblRetailLocationType);
            this.Controls.Add(this.txtSellerId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "Query10Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query10Form";
            this.Load += new System.EventHandler(this.Query10Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultRetailLocation;
        private System.Windows.Forms.Label lblResultSeller;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtRetailLocationId;
        private System.Windows.Forms.Label lblMinVolume;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtRetailLocationName;
        private System.Windows.Forms.Label lblRetailLocationType;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbNormalizationFactor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNormalizationValue;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Label lblTotalSalesVolume;
    }
}