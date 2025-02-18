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
    public partial class Query2Form : Form
    {
        public Query2Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считываем параметры

                // productId
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

                // productName
                string productName = txtProductName.Text.Trim();

                // productType
                string productType = txtProductType.Text.Trim();

                // minVolume
                int? minVolume = null;
                if (!string.IsNullOrWhiteSpace(txtMinVolume.Text))
                {
                    if (int.TryParse(txtMinVolume.Text, out int vol))
                        minVolume = vol;
                    else
                    {
                        MessageBox.Show("Неверный формат Min Volume.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // startDate и endDate
                DateTime? startDate = dtpStartDate.Value;
                DateTime? endDate = dtpEndDate.Value;

                // 2. Вызываем сервис
                CustomerQueryService service = new CustomerQueryService();
                var result = service.GetCustomersByProductCriteria(
                    productType,
                    productId,
                    productName,
                    minVolume,
                    startDate,
                    endDate
                );

                // 3. Отображаем результаты
                dgvResults.DataSource = result.Customers;


                // 4. Выводим общее число покупателей
                lblTotalCount.Text = $"Общее число покупателей: {result.TotalCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query2Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForProductName();
            SetupAutoCompleteForProductType();
        }

        /// <summary>
        /// Настраивает автодополнение для поля Product Name на основе данных из репозитория.
        /// </summary>
        private void SetupAutoCompleteForProductName()
        {
            // Извлекаем все названия товаров из репозитория
            var productNames = DataRepository.Instance.Data.Products
                .Select(p => p.Name)
                .Distinct()
                .ToArray();

            AutoCompleteStringCollection autoCompleteNames = new AutoCompleteStringCollection();
            autoCompleteNames.AddRange(productNames);

            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = autoCompleteNames;
        }

        /// <summary>
        /// Настраивает автодополнение для поля Product Type на основе данных из репозитория.
        /// </summary>
        private void SetupAutoCompleteForProductType()
        {
            // Извлекаем все типы товаров из репозитория
            var productTypes = DataRepository.Instance.Data.Products
                .Select(p => p.Type)
                .Distinct()
                .ToArray();

            AutoCompleteStringCollection autoCompleteTypes = new AutoCompleteStringCollection();
            autoCompleteTypes.AddRange(productTypes);

            txtProductType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductType.AutoCompleteCustomSource = autoCompleteTypes;
        }
    }
}
