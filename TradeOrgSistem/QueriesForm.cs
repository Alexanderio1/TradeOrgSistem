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
    public partial class QueriesForm : Form
    {
        public QueriesForm()
        {
            InitializeComponent();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            Query1Form form = new Query1Form();
            form.Show();
        }
    }
}
