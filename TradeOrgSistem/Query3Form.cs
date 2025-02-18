using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradeOrgSistem.Services;

namespace TradeOrgSistem
{
    public partial class Query3Form : Form
    {
        public Query3Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем параметр Retail Location ID (опционально)
                int? retailLocationId = null;
                if (!string.IsNullOrWhiteSpace(txtRetailLocationID.Text))
                {
                    if (int.TryParse(txtRetailLocationID.Text, out int id))
                        retailLocationId = id;
                    else
                    {
                        MessageBox.Show("Неверный формат Retail Location ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Считываем параметр Retail Location Name (опционально)
                string retailLocationName = txtRetailLocationName.Text.Trim();

                // Создаем экземпляр сервиса для запроса инвентаря торговой точки
                RetailLocationQueryService service = new RetailLocationQueryService();
                var result = service.GetInventoryForRetailLocation(retailLocationId, retailLocationName);
                MessageBox.Show($"Найдено записей: {result.InventoryItems.Count}");


                // Привязываем список элементов инвентаря к DataGridView для отображения
                dgvResults.DataSource = result.InventoryItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
