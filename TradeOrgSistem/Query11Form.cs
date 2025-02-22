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
    public partial class Query11Form : Form
    {
        public Query11Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем опциональный параметр Retail Location ID
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

                // Считываем название и тип торговой точки
                string retailLocationName = txtRetailLocationName.Text.Trim();
                string retailLocationType = txtRetailLocationType.Text.Trim();

                // Считываем период
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                // Создаем экземпляр сервиса для получения рентабельности торговой точки
                RetailLocationProfitabilityQueryService service = new RetailLocationProfitabilityQueryService();
                var result = service.GetProfitability(retailLocationId, retailLocationName, retailLocationType, startDate, endDate);

                // Отображаем результаты в метках
                lblRetailLocation.Text = $"Торговая точка: {result.RetailLocationName} (ID: {result.RetailLocationId})";
                lblTotalSalesRevenue.Text = $"Общая выручка: {result.TotalSalesRevenue:C}";
                lblOverheadCosts.Text = $"Накладные расходы: {result.OverheadCosts:C}";
                lblProfitabilityRatio.Text = $"Рентабельность: {result.ProfitabilityRatio:P}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtRetailLocationName на основе уникальных названий торговых точек.
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
        /// Настраивает автодополнение для поля txtRetailLocationType на основе уникальных типов торговых точек.
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

        private void Query11Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForRetailLocationName();
            SetupAutoCompleteForRetailLocationType();
        }
    }
}
