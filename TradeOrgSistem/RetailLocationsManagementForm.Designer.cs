namespace TradeOrgSistem
{
    partial class RetailLocationsManagementForm
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
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.txtNewLocationType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewLocationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewLocationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            this.txtNewLocationCounters = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewLocationHalls = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewLocationArea = new System.Windows.Forms.TextBox();
            this.txtNewLocationUtilities = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNewLocationRent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEditLocationUtilities = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditLocationRent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditLocationCounters = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEditLocationHalls = new System.Windows.Forms.TextBox();
            this.txtEditLocationArea = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEditLocationType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEditLocationName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLocation.Location = new System.Drawing.Point(859, 675);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(478, 66);
            this.btnDeleteLocation.TabIndex = 45;
            this.btnDeleteLocation.Text = "Удалить торговую точку";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.Location = new System.Drawing.Point(54, 685);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(478, 66);
            this.btnAddLocation.TabIndex = 44;
            this.btnAddLocation.Text = "Добавить торговую точку";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // txtNewLocationType
            // 
            this.txtNewLocationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewLocationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewLocationType.Location = new System.Drawing.Point(54, 259);
            this.txtNewLocationType.Name = "txtNewLocationType";
            this.txtNewLocationType.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationType.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 36);
            this.label4.TabIndex = 42;
            this.label4.Text = "Тип торговой точки";
            // 
            // txtNewLocationName
            // 
            this.txtNewLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewLocationName.Location = new System.Drawing.Point(54, 186);
            this.txtNewLocationName.Name = "txtNewLocationName";
            this.txtNewLocationName.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationName.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "Название торговой точки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID торговой точки";
            // 
            // txtNewLocationId
            // 
            this.txtNewLocationId.Location = new System.Drawing.Point(54, 113);
            this.txtNewLocationId.Name = "txtNewLocationId";
            this.txtNewLocationId.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 49);
            this.label1.TabIndex = 37;
            this.label1.Text = "Добавление новой торговой точки";
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(859, 589);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(478, 66);
            this.btnEditLocation.TabIndex = 31;
            this.btnEditLocation.Text = "Редактировать торговую точку";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(858, 49);
            this.label5.TabIndex = 33;
            this.label5.Text = "Редактирование/удаление торговой точки";
            // 
            // dgvLocations
            // 
            this.dgvLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLocations.Location = new System.Drawing.Point(0, 785);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.ReadOnly = true;
            this.dgvLocations.RowHeadersWidth = 82;
            this.dgvLocations.RowTemplate.Height = 33;
            this.dgvLocations.Size = new System.Drawing.Size(1713, 427);
            this.dgvLocations.TabIndex = 30;
            // 
            // txtNewLocationCounters
            // 
            this.txtNewLocationCounters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewLocationCounters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewLocationCounters.Location = new System.Drawing.Point(54, 478);
            this.txtNewLocationCounters.Name = "txtNewLocationCounters";
            this.txtNewLocationCounters.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationCounters.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 36);
            this.label8.TabIndex = 50;
            this.label8.Text = "Число прилавков";
            // 
            // txtNewLocationHalls
            // 
            this.txtNewLocationHalls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewLocationHalls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewLocationHalls.Location = new System.Drawing.Point(54, 405);
            this.txtNewLocationHalls.Name = "txtNewLocationHalls";
            this.txtNewLocationHalls.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationHalls.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 36);
            this.label9.TabIndex = 48;
            this.label9.Text = "Число залов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 36);
            this.label10.TabIndex = 47;
            this.label10.Text = "Площадь";
            // 
            // txtNewLocationArea
            // 
            this.txtNewLocationArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewLocationArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewLocationArea.Location = new System.Drawing.Point(54, 332);
            this.txtNewLocationArea.Name = "txtNewLocationArea";
            this.txtNewLocationArea.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationArea.TabIndex = 46;
            // 
            // txtNewLocationUtilities
            // 
            this.txtNewLocationUtilities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewLocationUtilities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewLocationUtilities.Location = new System.Drawing.Point(54, 624);
            this.txtNewLocationUtilities.Name = "txtNewLocationUtilities";
            this.txtNewLocationUtilities.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationUtilities.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(372, 36);
            this.label11.TabIndex = 54;
            this.label11.Text = "Коммунальные платежи";
            // 
            // txtNewLocationRent
            // 
            this.txtNewLocationRent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewLocationRent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewLocationRent.Location = new System.Drawing.Point(54, 551);
            this.txtNewLocationRent.Name = "txtNewLocationRent";
            this.txtNewLocationRent.Size = new System.Drawing.Size(478, 31);
            this.txtNewLocationRent.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 36);
            this.label12.TabIndex = 52;
            this.label12.Text = "Аренда";
            // 
            // txtEditLocationUtilities
            // 
            this.txtEditLocationUtilities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditLocationUtilities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditLocationUtilities.Location = new System.Drawing.Point(859, 551);
            this.txtEditLocationUtilities.Name = "txtEditLocationUtilities";
            this.txtEditLocationUtilities.Size = new System.Drawing.Size(478, 31);
            this.txtEditLocationUtilities.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(853, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(472, 36);
            this.label7.TabIndex = 68;
            this.label7.Text = "Новые коммунальные платежи";
            // 
            // txtEditLocationRent
            // 
            this.txtEditLocationRent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditLocationRent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditLocationRent.Location = new System.Drawing.Point(859, 478);
            this.txtEditLocationRent.Name = "txtEditLocationRent";
            this.txtEditLocationRent.Size = new System.Drawing.Size(478, 31);
            this.txtEditLocationRent.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(853, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 36);
            this.label13.TabIndex = 66;
            this.label13.Text = "Новая аренда";
            // 
            // txtEditLocationCounters
            // 
            this.txtEditLocationCounters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditLocationCounters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditLocationCounters.Location = new System.Drawing.Point(859, 405);
            this.txtEditLocationCounters.Name = "txtEditLocationCounters";
            this.txtEditLocationCounters.Size = new System.Drawing.Size(478, 31);
            this.txtEditLocationCounters.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(853, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(361, 36);
            this.label14.TabIndex = 64;
            this.label14.Text = "Новое число прилавков";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(853, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(294, 36);
            this.label15.TabIndex = 63;
            this.label15.Text = "Новое число залов";
            // 
            // txtEditLocationHalls
            // 
            this.txtEditLocationHalls.Location = new System.Drawing.Point(859, 332);
            this.txtEditLocationHalls.Name = "txtEditLocationHalls";
            this.txtEditLocationHalls.Size = new System.Drawing.Size(478, 31);
            this.txtEditLocationHalls.TabIndex = 62;
            // 
            // txtEditLocationArea
            // 
            this.txtEditLocationArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditLocationArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditLocationArea.Location = new System.Drawing.Point(859, 259);
            this.txtEditLocationArea.Name = "txtEditLocationArea";
            this.txtEditLocationArea.Size = new System.Drawing.Size(478, 31);
            this.txtEditLocationArea.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(853, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 36);
            this.label16.TabIndex = 60;
            this.label16.Text = "Новая площадь";
            // 
            // txtEditLocationType
            // 
            this.txtEditLocationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditLocationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditLocationType.Location = new System.Drawing.Point(859, 186);
            this.txtEditLocationType.Name = "txtEditLocationType";
            this.txtEditLocationType.Size = new System.Drawing.Size(478, 31);
            this.txtEditLocationType.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(853, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 36);
            this.label17.TabIndex = 58;
            this.label17.Text = "Новый тип";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(853, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(250, 36);
            this.label18.TabIndex = 57;
            this.label18.Text = "Новое название";
            // 
            // txtEditLocationName
            // 
            this.txtEditLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEditLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEditLocationName.Location = new System.Drawing.Point(859, 113);
            this.txtEditLocationName.Name = "txtEditLocationName";
            this.txtEditLocationName.Size = new System.Drawing.Size(478, 31);
            this.txtEditLocationName.TabIndex = 56;
            // 
            // RetailLocationsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 1212);
            this.Controls.Add(this.txtEditLocationUtilities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEditLocationRent);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEditLocationCounters);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEditLocationHalls);
            this.Controls.Add(this.txtEditLocationArea);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtEditLocationType);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtEditLocationName);
            this.Controls.Add(this.txtNewLocationUtilities);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNewLocationRent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNewLocationCounters);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNewLocationHalls);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNewLocationArea);
            this.Controls.Add(this.btnDeleteLocation);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.txtNewLocationType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewLocationName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewLocationId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLocations);
            this.MaximizeBox = false;
            this.Name = "RetailLocationsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление торговыми точками";
            this.Load += new System.EventHandler(this.RetailLocationsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.TextBox txtNewLocationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewLocationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewLocationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLocations;
        private System.Windows.Forms.TextBox txtNewLocationCounters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewLocationHalls;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewLocationArea;
        private System.Windows.Forms.TextBox txtNewLocationUtilities;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNewLocationRent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEditLocationUtilities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditLocationRent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditLocationCounters;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEditLocationHalls;
        private System.Windows.Forms.TextBox txtEditLocationArea;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEditLocationType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEditLocationName;
    }
}