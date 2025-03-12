using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgSistem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            QueriesForm queriesForm = new QueriesForm();
            queriesForm.Show();
        }

        private void btnDataManagement_Click(object sender, EventArgs e)
        {
            DataManagementForm dataForm = new DataManagementForm();
            dataForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
