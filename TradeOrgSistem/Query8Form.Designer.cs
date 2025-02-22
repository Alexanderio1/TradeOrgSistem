namespace TradeOrgSistem
{
    partial class Query8Form
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
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.txtRetailLocationName = new System.Windows.Forms.TextBox();
            this.lblMinVolume = new System.Windows.Forms.Label();
            this.txtRetailLocationID = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtRetailLocationType = new System.Windows.Forms.TextBox();
            this.lblRetailLocationType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(642, 851);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(384, 36);
            this.lblTotalCount.TabIndex = 101;
            this.lblTotalCount.Text = "Общее число продавцов:";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(46, 706);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(520, 66);
            this.btnRunQuery.TabIndex = 99;
            this.btnRunQuery.Text = "Выполнить запрос";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // txtRetailLocationName
            // 
            this.txtRetailLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationName.Location = new System.Drawing.Point(46, 404);
            this.txtRetailLocationName.Name = "txtRetailLocationName";
            this.txtRetailLocationName.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationName.TabIndex = 97;
            // 
            // lblMinVolume
            // 
            this.lblMinVolume.AutoSize = true;
            this.lblMinVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinVolume.Location = new System.Drawing.Point(46, 365);
            this.lblMinVolume.Name = "lblMinVolume";
            this.lblMinVolume.Size = new System.Drawing.Size(382, 36);
            this.lblMinVolume.TabIndex = 96;
            this.lblMinVolume.Text = "Название торговой точки";
            // 
            // txtRetailLocationID
            // 
            this.txtRetailLocationID.Location = new System.Drawing.Point(46, 331);
            this.txtRetailLocationID.Name = "txtRetailLocationID";
            this.txtRetailLocationID.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationID.TabIndex = 95;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(46, 292);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(273, 36);
            this.lblProductType.TabIndex = 94;
            this.lblProductType.Text = "ID торговой точки";
            // 
            // txtRetailLocationType
            // 
            this.txtRetailLocationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRetailLocationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetailLocationType.Location = new System.Drawing.Point(46, 477);
            this.txtRetailLocationType.Name = "txtRetailLocationType";
            this.txtRetailLocationType.Size = new System.Drawing.Size(526, 31);
            this.txtRetailLocationType.TabIndex = 93;
            // 
            // lblRetailLocationType
            // 
            this.lblRetailLocationType.AutoSize = true;
            this.lblRetailLocationType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailLocationType.Location = new System.Drawing.Point(46, 438);
            this.lblRetailLocationType.Name = "lblRetailLocationType";
            this.lblRetailLocationType.Size = new System.Drawing.Size(294, 36);
            this.lblRetailLocationType.TabIndex = 92;
            this.lblRetailLocationType.Text = "Тип торговой точки";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1387, 86);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "Получить данные о заработной плате продавцов по всем торговым точкам, по\r\nторговы" +
    "м точкам заданного типа, по конкретной торговой точке.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(648, 170);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 82;
            this.dgvResults.RowTemplate.Height = 33;
            this.dgvResults.Size = new System.Drawing.Size(940, 619);
            this.dgvResults.TabIndex = 102;
            // 
            // Query8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 964);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.txtRetailLocationName);
            this.Controls.Add(this.lblMinVolume);
            this.Controls.Add(this.txtRetailLocationID);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtRetailLocationType);
            this.Controls.Add(this.lblRetailLocationType);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "Query8Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запрос 8";
            this.Load += new System.EventHandler(this.Query8Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.TextBox txtRetailLocationName;
        private System.Windows.Forms.Label lblMinVolume;
        private System.Windows.Forms.TextBox txtRetailLocationID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtRetailLocationType;
        private System.Windows.Forms.Label lblRetailLocationType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}