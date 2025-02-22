using System;
using System.Windows.Forms;

namespace TradeOrgSistem
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnproger_Click(object sender, EventArgs e)
        {
            ProgerForm progerForm = new ProgerForm();
            progerForm.Show();
        }

        private void btnguid_Click(object sender, EventArgs e)
        {
            UserGuideForm userGuideForm = new UserGuideForm();
            userGuideForm.Show();
        }
    }
}
