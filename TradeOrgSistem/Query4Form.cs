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
    public partial class Query4Form : Form
    {
        public Query4Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем обязательный параметр: Product ID
                int? productId = null;
                if (!string.IsNullOrWhiteSpace(txtProductId.Text))
                {
                    if (int.TryParse(txtProductId.Text, out int pid))
                        productId = pid;
                    else
                    {
                        MessageBox.Show("Неверный формат Product ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Если Product ID не задан, пытаемся использовать Product Name
                string productName = txtProductName.Text.Trim();
                if (!productId.HasValue && string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Необходимо указать либо Product ID, либо Product Name.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Считываем параметры фильтрации для торговой точки
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

                // Создаем экземпляр сервиса запроса
                ProductPriceVolumeQueryService service = new ProductPriceVolumeQueryService();
                var result = service.GetProductPriceVolumeInfo(productId, productName, retailLocationType, retailLocationId, retailLocationName);

                // Отображаем агрегированные результаты в метках
                lblTotalVolume.Text = $"Общий объем продаж: {result.TotalVolume}";
                lblMinPrice.Text = $"Минимальная цена: {result.MinPrice:C}";
                lblMaxPrice.Text = $"Максимальная цена: {result.MaxPrice:C}";
                lblAveragePrice.Text = $"Средняя цена: {result.AveragePrice:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        /// <summary>
        /// Настраивает автодополнение для поля txtProductName на основе названий товаров.
        /// </summary>
        private void SetupAutoCompleteForProductName()
        {
            var productNames = DataRepository.Instance.Data.Products
                                .Select(p => p.Name)
                                .Distinct()
                                .ToArray();
            AutoCompleteStringCollection autoCompleteProducts = new AutoCompleteStringCollection();
            autoCompleteProducts.AddRange(productNames);

            txtProductName.Multiline = false;
            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = autoCompleteProducts;
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

        private void Query4Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForRetailLocationName();
            SetupAutoCompleteForRetailLocationType();
            SetupAutoCompleteForProductName();
        }
    }
}
