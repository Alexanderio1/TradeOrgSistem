namespace TradeOrgSistem
{
    partial class QueriesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.btnQuery5 = new System.Windows.Forms.Button();
            this.btnQuery6 = new System.Windows.Forms.Button();
            this.btnQuery7 = new System.Windows.Forms.Button();
            this.btnQuery8 = new System.Windows.Forms.Button();
            this.btnQuery9 = new System.Windows.Forms.Button();
            this.btnQuery10 = new System.Windows.Forms.Button();
            this.btnQuery11 = new System.Windows.Forms.Button();
            this.btnQuery12 = new System.Windows.Forms.Button();
            this.btnQuery13 = new System.Windows.Forms.Button();
            this.btnQuery14 = new System.Windows.Forms.Button();
            this.btnQuery15 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запросы к системе";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuery15, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery14, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1538, 720);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnQuery1
            // 
            this.btnQuery1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery1.Location = new System.Drawing.Point(3, 3);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(506, 138);
            this.btnQuery1.TabIndex = 0;
            this.btnQuery1.Text = "1. Поставщики \r\n(по виду/товару, объём, период)";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery2.Location = new System.Drawing.Point(515, 3);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(506, 138);
            this.btnQuery2.TabIndex = 1;
            this.btnQuery2.Text = "2. Покупатели (по виду, объём, период)";
            this.btnQuery2.UseVisualStyleBackColor = true;
            // 
            // btnQuery3
            // 
            this.btnQuery3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery3.Location = new System.Drawing.Point(1027, 3);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(508, 138);
            this.btnQuery3.TabIndex = 2;
            this.btnQuery3.Text = "3. Номенклатура торговой точки";
            this.btnQuery3.UseVisualStyleBackColor = true;
            // 
            // btnQuery4
            // 
            this.btnQuery4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery4.Location = new System.Drawing.Point(3, 147);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(506, 138);
            this.btnQuery4.TabIndex = 3;
            this.btnQuery4.Text = "4. Объём и цены товара (все/тип/точка)";
            this.btnQuery4.UseVisualStyleBackColor = true;
            // 
            // btnQuery5
            // 
            this.btnQuery5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery5.Location = new System.Drawing.Point(515, 147);
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(506, 138);
            this.btnQuery5.TabIndex = 4;
            this.btnQuery5.Text = "5. Выработка продавца (средняя по точкам)";
            this.btnQuery5.UseVisualStyleBackColor = true;
            // 
            // btnQuery6
            // 
            this.btnQuery6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery6.Location = new System.Drawing.Point(1027, 147);
            this.btnQuery6.Name = "btnQuery6";
            this.btnQuery6.Size = new System.Drawing.Size(508, 138);
            this.btnQuery6.TabIndex = 5;
            this.btnQuery6.Text = "6. Выработка продавца (конкретная точка)";
            this.btnQuery6.UseVisualStyleBackColor = true;
            // 
            // btnQuery7
            // 
            this.btnQuery7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery7.Location = new System.Drawing.Point(3, 291);
            this.btnQuery7.Name = "btnQuery7";
            this.btnQuery7.Size = new System.Drawing.Size(506, 138);
            this.btnQuery7.TabIndex = 6;
            this.btnQuery7.Text = "7. Объём продаж товара (все/тип/точка)";
            this.btnQuery7.UseVisualStyleBackColor = true;
            // 
            // btnQuery8
            // 
            this.btnQuery8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery8.Location = new System.Drawing.Point(515, 291);
            this.btnQuery8.Name = "btnQuery8";
            this.btnQuery8.Size = new System.Drawing.Size(506, 138);
            this.btnQuery8.TabIndex = 7;
            this.btnQuery8.Text = "8. Заработная плата продавцов";
            this.btnQuery8.UseVisualStyleBackColor = true;
            // 
            // btnQuery9
            // 
            this.btnQuery9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery9.Location = new System.Drawing.Point(1027, 291);
            this.btnQuery9.Name = "btnQuery9";
            this.btnQuery9.Size = new System.Drawing.Size(508, 138);
            this.btnQuery9.TabIndex = 8;
            this.btnQuery9.Text = "9. Поставки товара (поставщик, период)";
            this.btnQuery9.UseVisualStyleBackColor = true;
            // 
            // btnQuery10
            // 
            this.btnQuery10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery10.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery10.Location = new System.Drawing.Point(3, 435);
            this.btnQuery10.Name = "btnQuery10";
            this.btnQuery10.Size = new System.Drawing.Size(506, 138);
            this.btnQuery10.TabIndex = 9;
            this.btnQuery10.Text = "10. Отношение объёма продаж к нормировке";
            this.btnQuery10.UseVisualStyleBackColor = true;
            // 
            // btnQuery11
            // 
            this.btnQuery11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery11.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery11.Location = new System.Drawing.Point(515, 435);
            this.btnQuery11.Name = "btnQuery11";
            this.btnQuery11.Size = new System.Drawing.Size(506, 138);
            this.btnQuery11.TabIndex = 10;
            this.btnQuery11.Text = "11. Рентабельность торговой точки";
            this.btnQuery11.UseVisualStyleBackColor = true;
            // 
            // btnQuery12
            // 
            this.btnQuery12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery12.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery12.Location = new System.Drawing.Point(1027, 435);
            this.btnQuery12.Name = "btnQuery12";
            this.btnQuery12.Size = new System.Drawing.Size(508, 138);
            this.btnQuery12.TabIndex = 11;
            this.btnQuery12.Text = "12. Поставки по номеру заказа";
            this.btnQuery12.UseVisualStyleBackColor = true;
            // 
            // btnQuery13
            // 
            this.btnQuery13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery13.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery13.Location = new System.Drawing.Point(3, 579);
            this.btnQuery13.Name = "btnQuery13";
            this.btnQuery13.Size = new System.Drawing.Size(506, 138);
            this.btnQuery13.TabIndex = 12;
            this.btnQuery13.Text = "13. Покупатели товара (период, точка)";
            this.btnQuery13.UseVisualStyleBackColor = true;
            // 
            // btnQuery14
            // 
            this.btnQuery14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery14.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery14.Location = new System.Drawing.Point(515, 579);
            this.btnQuery14.Name = "btnQuery14";
            this.btnQuery14.Size = new System.Drawing.Size(506, 138);
            this.btnQuery14.TabIndex = 13;
            this.btnQuery14.Text = "14. Наиболее активные покупатели";
            this.btnQuery14.UseVisualStyleBackColor = true;
            // 
            // btnQuery15
            // 
            this.btnQuery15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery15.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery15.Location = new System.Drawing.Point(1027, 579);
            this.btnQuery15.Name = "btnQuery15";
            this.btnQuery15.Size = new System.Drawing.Size(508, 138);
            this.btnQuery15.TabIndex = 14;
            this.btnQuery15.Text = "15. Товарооборот торговой точки/группы";
            this.btnQuery15.UseVisualStyleBackColor = true;
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 831);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QueriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запросы к системе";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnQuery6;
        private System.Windows.Forms.Button btnQuery5;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnQuery15;
        private System.Windows.Forms.Button btnQuery14;
        private System.Windows.Forms.Button btnQuery13;
        private System.Windows.Forms.Button btnQuery12;
        private System.Windows.Forms.Button btnQuery11;
        private System.Windows.Forms.Button btnQuery10;
        private System.Windows.Forms.Button btnQuery9;
        private System.Windows.Forms.Button btnQuery8;
        private System.Windows.Forms.Button btnQuery7;
    }
}