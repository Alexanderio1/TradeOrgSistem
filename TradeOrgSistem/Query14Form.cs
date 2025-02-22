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
    public partial class Query14Form : Form
    {
        public Query14Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Считываем период (опционально)
                    DateTime? startDate = dtpStartDate.Value;
                    DateTime? endDate = dtpEndDate.Value;

                    // Считываем параметры для торговой точки
                    int? retailLocationId = null;
                    if (!string.IsNullOrWhiteSpace(txtRetailLocationID.Text))
                    {
                        if (int.TryParse(txtRetailLocationID.Text, out int rid))
                            retailLocationId = rid;
                        else
                        {
                            MessageBox.Show("Неверный формат Retail Location ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string retailLocationName = txtRetailLocationName.Text.Trim();
                    string retailLocationType = txtRetailLocationType.Text.Trim();

                    // Создаем экземпляр сервиса для запроса активных покупателей
                    ActiveCustomerQueryService service = new ActiveCustomerQueryService();
                    var result = service.GetActiveCustomers(startDate, endDate, retailLocationId, retailLocationName, retailLocationType);

                    // Привязываем полученный список активных покупателей к DataGridView
                    dgvResults.DataSource = result.ActiveCustomers;

                    // Выводим общее число найденных покупателей
                    lblTotalCount.Text = $"Общее число активных покупателей: {result.TotalCount}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Query14Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForRetailLocationName();
            SetupAutoCompleteForRetailLocationType();
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtRetailLocationName на основе уникальных названий торговых точек.
        /// </summary>
        private void SetupAutoCompleteForRetailLocationName()
        {
            var locationNames = DataRepository.Instance.Data.RetailLocations
                                    .Select(r => r.Name)
                                    .Distinct()
                                    .ToArray();
            AutoCompleteStringCollection acLocationNames = new AutoCompleteStringCollection();
            acLocationNames.AddRange(locationNames);

            txtRetailLocationName.Multiline = false;
            txtRetailLocationName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationName.AutoCompleteCustomSource = acLocationNames;
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtRetailLocationType на основе уникальных типов торговых точек.
        /// </summary>
        private void SetupAutoCompleteForRetailLocationType()
        {
            var locationTypes = DataRepository.Instance.Data.RetailLocations
                                    .Select(r => r.Type)
                                    .Distinct()
                                    .ToArray();
            AutoCompleteStringCollection acLocationTypes = new AutoCompleteStringCollection();
            acLocationTypes.AddRange(locationTypes);

            txtRetailLocationType.Multiline = false;
            txtRetailLocationType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationType.AutoCompleteCustomSource = acLocationTypes;
        }
    }
}
