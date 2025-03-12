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
                string orderNumber = txtOrderNumber.Text.Trim();
                if (string.IsNullOrWhiteSpace(orderNumber))
                {
                    MessageBox.Show("Номер заказа не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DeliveryOrderQueryService service = new DeliveryOrderQueryService();
                var result = service.GetDeliveriesByOrderNumber(orderNumber);

                dgvResults.DataSource = result.Deliveries;

                lblTotalCount.Text = $"Общее число поставок: {result.TotalCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
