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
            // Создаем экземпляр формы запросов (например, QueryForm)
            QueriesForm queriesForm = new QueriesForm();
            // Открываем форму немодально, чтобы можно было работать с несколькими окнами
            queriesForm.Show();
        }

        private void btnDataManagement_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы управления данными (например, DataManagementForm)
            DataManagementForm dataForm = new DataManagementForm();
            dataForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы "О программе"
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
