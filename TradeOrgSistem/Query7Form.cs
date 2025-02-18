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
    public partial class Query7Form : Form
    {
        public Query7Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считываем обязательный параметр: Product ID
                if (string.IsNullOrWhiteSpace(txtProductId.Text))
                {
                    MessageBox.Show("Product ID обязателен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtProductId.Text, out int productId))
                {
                    MessageBox.Show("Неверный формат Product ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Считываем период
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                // 3. Считываем фильтры для торговой точки
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

                // 4. Создаем экземпляр сервиса запроса объёма продаж товара
                ProductSalesVolumeQueryService service = new ProductSalesVolumeQueryService();
                var result = service.GetProductSalesVolume(productId, startDate, endDate, retailLocationType, retailLocationId, retailLocationName);

                // 5. Отображаем результаты в метках
                lblProductName.Text = $"Товар: {result.ProductName} (ID: {result.ProductId})";
                lblTotalSalesVolume.Text = $"Общий объем продаж: {result.TotalSalesVolume}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Настраивает автодополнение для поля txtRetailLocationName на основе названий торговых точек.
        /// </summary>
        private void SetupAutoCompleteForRetailLocationName()
        {
            var names = DataRepository.Instance.Data.RetailLocations
                            .Select(r => r.Name)
                            .Distinct()
                            .ToArray();
            AutoCompleteStringCollection autoCompleteNames = new AutoCompleteStringCollection();
            autoCompleteNames.AddRange(names);

            txtRetailLocationName.Multiline = false;
            txtRetailLocationName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationName.AutoCompleteCustomSource = autoCompleteNames;
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtRetailLocationType на основе типов торговых точек.
        /// </summary>
        private void SetupAutoCompleteForRetailLocationType()
        {
            var types = DataRepository.Instance.Data.RetailLocations
                            .Select(r => r.Type)
                            .Distinct()
                            .ToArray();
            AutoCompleteStringCollection autoCompleteTypes = new AutoCompleteStringCollection();
            autoCompleteTypes.AddRange(types);

            txtRetailLocationType.Multiline = false;
            txtRetailLocationType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationType.AutoCompleteCustomSource = autoCompleteTypes;
        }

        private void Query7Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForRetailLocationName();
            SetupAutoCompleteForRetailLocationType();
        }
    }
}
