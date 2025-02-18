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
    public partial class Query5Form : Form
    {
        public Query5Form()
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

                // Считываем тип торговой точки (опционально)
                string retailLocationType = txtRetailLocationType.Text.Trim();

                // Создаем экземпляр сервиса для вычисления средней выработки продавца
                AverageSellerPerformanceQueryService service = new AverageSellerPerformanceQueryService();
                var result = service.GetAverageSellerPerformance(startDate, endDate, retailLocationType);

                // Отображаем результаты
                lblAverageSalesVolume.Text = $"Средний объем продаж на одного продавца: {result.AverageSalesVolume}";
                lblAverageRevenue.Text = $"Средняя выручка на одного продавца: {result.AverageRevenue:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query5Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForRetailLocationType();
        }
        /// <summary>
        /// Настраивает автодополнение для поля txtRetailLocationType, используя уникальные типы торговых точек из репозитория.
        /// </summary>
        private void SetupAutoCompleteForRetailLocationType()
        {
            var types = DataRepository.Instance.Data.RetailLocations
                            .Select(r => r.Type)
                            .Distinct()
                            .ToArray();
            AutoCompleteStringCollection autoCompleteTypes = new AutoCompleteStringCollection();
            autoCompleteTypes.AddRange(types);

            // Убедитесь, что поле однострочное
            txtRetailLocationType.Multiline = false;
            txtRetailLocationType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationType.AutoCompleteCustomSource = autoCompleteTypes;
        }
    }
}
