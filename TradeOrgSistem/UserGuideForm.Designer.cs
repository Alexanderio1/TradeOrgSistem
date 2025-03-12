namespace TradeOrgSistem
{
    partial class UserGuideForm
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
            this.rtbUserGuide = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbUserGuide
            // 
            this.rtbUserGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbUserGuide.Font = new System.Drawing.Font("Cascadia Code", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUserGuide.Location = new System.Drawing.Point(0, 0);
            this.rtbUserGuide.Name = "rtbUserGuide";
            this.rtbUserGuide.ReadOnly = true;
            this.rtbUserGuide.Size = new System.Drawing.Size(1226, 820);
            this.rtbUserGuide.TabIndex = 0;
            this.rtbUserGuide.Text = "";
            // 
            // UserGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 820);
            this.Controls.Add(this.rtbUserGuide);
            this.MaximizeBox = false;
            this.Name = "UserGuideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUserGuide;
    }
}