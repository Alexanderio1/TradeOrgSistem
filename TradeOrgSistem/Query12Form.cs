using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Services;

namespace TradeOrgSistem
{
    public partial class Query12Form : Form
    {
        public Query12Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем номер заказа (обязательный параметр)
                string orderNumber = txtOrderNumber.Text.Trim();
                if (string.IsNullOrWhiteSpace(orderNumber))
                {
                    MessageBox.Show("Номер заказа не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создаем экземпляр сервиса запроса поставок по номеру заказа
                DeliveryOrderQueryService service = new DeliveryOrderQueryService();
                var result = service.GetDeliveriesByOrderNumber(orderNumber);

                // Привязываем список поставок к DataGridView
                dgvResults.DataSource = result.Deliveries;

                // Отображаем общее число найденных поставок
                lblTotalCount.Text = $"Общее число поставок: {result.TotalCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtOrderNumber на основе уникальных номеров заказов из поставок.
        /// </summary>
        private void SetupAutoCompleteForOrderNumber()
        {
            var orderNumbers = DataRepository.Instance.Data.Deliveries
                                .Select(d => d.OrderNumber)
                                .Where(o => !string.IsNullOrWhiteSpace(o))
                                .Distinct()
                                .ToArray();
            AutoCompleteStringCollection acOrders = new AutoCompleteStringCollection();
            acOrders.AddRange(orderNumbers);

            txtOrderNumber.Multiline = false;
            txtOrderNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtOrderNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtOrderNumber.AutoCompleteCustomSource = acOrders;
        }

        private void Query12Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForOrderNumber();
        }
    }
}
