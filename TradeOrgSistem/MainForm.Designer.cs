namespace TradeOrgSistem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnDataManagement = new System.Windows.Forms.Button();
            this.btnQueries = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(50, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(864, 90);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать\r\nв информационную систему торговой организации!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlButtons.Controls.Add(this.btnAbout);
            this.pnlButtons.Controls.Add(this.btnDataManagement);
            this.pnlButtons.Controls.Add(this.btnQueries);
            this.pnlButtons.Location = new System.Drawing.Point(231, 166);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(521, 401);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbout.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(100, 280);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(301, 121);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "О программе";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnDataManagement
            // 
            this.btnDataManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDataManagement.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataManagement.Location = new System.Drawing.Point(100, 144);
            this.btnDataManagement.Name = "btnDataManagement";
            this.btnDataManagement.Size = new System.Drawing.Size(301, 110);
            this.btnDataManagement.TabIndex = 1;
            this.btnDataManagement.Text = "Управление данными";
            this.btnDataManagement.UseVisualStyleBackColor = true;
            this.btnDataManagement.Click += new System.EventHandler(this.btnDataManagement_Click);
            // 
            // btnQueries
            // 
            this.btnQueries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQueries.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueries.Location = new System.Drawing.Point(100, 3);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(301, 112);
            this.btnQueries.TabIndex = 0;
            this.btnQueries.Text = "Запросы к системе";
            this.btnQueries.UseVisualStyleBackColor = true;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TradeOrgSystem";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnDataManagement;
        private System.Windows.Forms.Button btnQueries;
    }
}

