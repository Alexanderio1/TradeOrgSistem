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
    public partial class Query15Form : Form
    {
        public Query15Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем период
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                // Считываем опциональные параметры для торговой точки
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

                // Создаем экземпляр сервиса запроса товарооборота
                RetailTurnoverQueryService service = new RetailTurnoverQueryService();
                var result = service.GetRetailTurnover(startDate, endDate, retailLocationId, retailLocationName, retailLocationType);

                // Отображаем общие агрегированные показатели
                lblTotalRevenue.Text = $"Общая выручка: {result.TotalSalesRevenue:C}";
                lblTotalVolume.Text = $"Общий объем продаж: {result.TotalSalesVolume}";

                // Отображаем подробную разбивку по торговым точкам в DataGridView
                dgvBreakdown.DataSource = result.Breakdown;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query15Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForRetailLocationName();
            SetupAutoCompleteForRetailLocationType();
        }

        /// <summary>
        /// Настраивает автодополнение для txtRetailLocationName на основе уникальных названий торговых точек.
        /// </summary>
        private void SetupAutoCompleteForRetailLocationName()
        {
            var names = DataRepository.Instance.Data.RetailLocations
                            .Select(r => r.Name)
                            .Distinct()
                            .ToArray();
            AutoCompleteStringCollection acNames = new AutoCompleteStringCollection();
            acNames.AddRange(names);

            txtRetailLocationName.Multiline = false;
            txtRetailLocationName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationName.AutoCompleteCustomSource = acNames;
        }

        /// <summary>
        /// Настраивает автодополнение для txtRetailLocationType на основе уникальных типов торговых точек.
        /// </summary>
        private void SetupAutoCompleteForRetailLocationType()
        {
            var types = DataRepository.Instance.Data.RetailLocations
                            .Select(r => r.Type)
                            .Distinct()
                            .ToArray();
            AutoCompleteStringCollection acTypes = new AutoCompleteStringCollection();
            acTypes.AddRange(types);

            txtRetailLocationType.Multiline = false;
            txtRetailLocationType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationType.AutoCompleteCustomSource = acTypes;
        }
    }
}
