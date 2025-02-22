namespace TradeOrgSistem
{
    partial class Query11Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query11Form));
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSalesRevenue = new System.Windows.Forms.Label();
            this.lblRetailLocation = new System.Windows.Forms.Label();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtRetailLocationName = new System.Windows.Forms.TextBox();
            this.lblMinVolume = new System.Windows.Forms.Label();
            this.txtRetailLocationID = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtRetailLocationType = new System.Windows.Forms.TextBox();
            this.lblRetailLocationType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProfitabilityRatio = new System.Windows.Forms.Label();
            this.lblOverheadCosts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(63, 559);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(520, 31);
            this.dtpEndDate.TabIndex = 104;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(63, 482);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(520, 31);
            this.dtpStartDate.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 102;
            this.label1.Text = "Конечная дата";
            // 
            // lblTotalSalesRevenue
            // 
            this.lblTotalSalesRevenue.AutoSize = true;
            this.lblTotalSalesRevenue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesRevenue.Location = new System.Drawing.Point(643, 297);
            this.lblTotalSalesRevenue.Name = "lblTotalSalesRevenue";
            this.lblTotalSalesRevenue.Size = new System.Drawing.Size(255, 36);
            this.lblTotalSalesRevenue.TabIndex = 101;
            this.lblTotalSalesRevenue.Text = "Общая выручка:";
            // 
            // lblRetailLocation
            // 
            this.lblRetailLocation.AutoSize = true;
            this.lblRetailLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailLocation.Location = new System.Drawing.Point(643, 224);
            this.lblRetailLocation.Name = "lblRetailLocation";
            this.lblRetailLocation.Size = new System.Drawing.Size(242, 36);
            this.lblRetailLocation.TabIndex = 100;
            this.lblRetailLocation.Text = "Торговая точка:";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(57, 715);
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
            this.lblStartDate.Location = new System.Drawing.Point(57, 443);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(252, 36);
            this.lblStartDate.TabIndex = 98;
            this.lblStartDate.Text = "Начальная дата";
            // 
            // txtRetailLocationName
            // 
            this.txtRetailLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationName.Location = new System.Drawing.Point(57, 336);
            this.txtRetailLocationName.Name = "txtRetailLocationName";
            this.txtRetailLocationName.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationName.TabIndex = 97;
            // 
            // lblMinVolume
            // 
            this.lblMinVolume.AutoSize = true;
            this.lblMinVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinVolume.Location = new System.Drawing.Point(57, 297);
            this.lblMinVolume.Name = "lblMinVolume";
            this.lblMinVolume.Size = new System.Drawing.Size(382, 36);
            this.lblMinVolume.TabIndex = 96;
            this.lblMinVolume.Text = "Название торговой точки";
            // 
            // txtRetailLocationID
            // 
            this.txtRetailLocationID.Location = new System.Drawing.Point(57, 263);
            this.txtRetailLocationID.Name = "txtRetailLocationID";
            this.txtRetailLocationID.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationID.TabIndex = 95;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(51, 224);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(273, 36);
            this.lblProductType.TabIndex = 94;
            this.lblProductType.Text = "ID торговой точки";
            // 
            // txtRetailLocationType
            // 
            this.txtRetailLocationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationType.Location = new System.Drawing.Point(57, 409);
            this.txtRetailLocationType.Name = "txtRetailLocationType";
            this.txtRetailLocationType.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationType.TabIndex = 93;
            // 
            // lblRetailLocationType
            // 
            this.lblRetailLocationType.AutoSize = true;
            this.lblRetailLocationType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailLocationType.Location = new System.Drawing.Point(57, 370);
            this.lblRetailLocationType.Name = "lblRetailLocationType";
            this.lblRetailLocationType.Size = new System.Drawing.Size(294, 36);
            this.lblRetailLocationType.TabIndex = 92;
            this.lblRetailLocationType.Text = "Тип торговой точки";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1539, 172);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = resources.GetString("lblTitle.Text");
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitabilityRatio
            // 
            this.lblProfitabilityRatio.AutoSize = true;
            this.lblProfitabilityRatio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitabilityRatio.Location = new System.Drawing.Point(643, 443);
            this.lblProfitabilityRatio.Name = "lblProfitabilityRatio";
            this.lblProfitabilityRatio.Size = new System.Drawing.Size(263, 36);
            this.lblProfitabilityRatio.TabIndex = 105;
            this.lblProfitabilityRatio.Text = "Рентабельность:";
            // 
            // lblOverheadCosts
            // 
            this.lblOverheadCosts.AutoSize = true;
            this.lblOverheadCosts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverheadCosts.Location = new System.Drawing.Point(643, 370);
            this.lblOverheadCosts.Name = "lblOverheadCosts";
            this.lblOverheadCosts.Size = new System.Drawing.Size(322, 36);
            this.lblOverheadCosts.TabIndex = 106;
            this.lblOverheadCosts.Text = "Накладные расходы:";
            // 
            // Query11Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 898);
            this.Controls.Add(this.lblOverheadCosts);
            this.Controls.Add(this.lblProfitabilityRatio);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalSalesRevenue);
            this.Controls.Add(this.lblRetailLocation);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtRetailLocationName);
            this.Controls.Add(this.lblMinVolume);
            this.Controls.Add(this.txtRetailLocationID);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtRetailLocationType);
            this.Controls.Add(this.lblRetailLocationType);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "Query11Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query11Form";
            this.Load += new System.EventHandler(this.Query11Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSalesRevenue;
        private System.Windows.Forms.Label lblRetailLocation;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtRetailLocationName;
        private System.Windows.Forms.Label lblMinVolume;
        private System.Windows.Forms.TextBox txtRetailLocationID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtRetailLocationType;
        private System.Windows.Forms.Label lblRetailLocationType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProfitabilityRatio;
        private System.Windows.Forms.Label lblOverheadCosts;
    }
}