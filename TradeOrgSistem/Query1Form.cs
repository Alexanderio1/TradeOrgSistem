﻿using System;
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
    public partial class Query1Form : Form
    {
        public Query1Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем параметр Product ID (опционально)
                int? productId = null;
                if (!string.IsNullOrWhiteSpace(txtProductID.Text))
                {
                    if (int.TryParse(txtProductID.Text, out int pid))
                        productId = pid;
                    else
                    {
                        MessageBox.Show("Неверный формат ID товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Считываем параметры Product Name и Product Type (опционально)
                string productName = txtProductName.Text.Trim();
                string productType = txtProductType.Text.Trim();

                // Считываем Min Volume (опционально)
                int? minVolume = null;
                if (!string.IsNullOrWhiteSpace(txtMinVolume.Text))
                {
                    if (int.TryParse(txtMinVolume.Text, out int vol))
                        minVolume = vol;
                    else
                    {
                        MessageBox.Show("Неверный формат минимального объема.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Считываем даты (при условии, что DateTimePicker всегда содержит значение)
                DateTime? startDate = dtpStartDate.Value;
                DateTime? endDate = dtpEndDate.Value;

                // Создаем экземпляр сервиса запроса
                SupplierQueryService service = new SupplierQueryService();

                // Вызываем метод запроса с полученными параметрами
                var result = service.GetSuppliersByProductCriteria(productType, productId, productName, minVolume, startDate, endDate);

                // Привязываем список поставщиков к DataGridView для отображения результатов.
                dgvResults.DataSource = result.Suppliers;

                if (dgvResults.Columns["ProductIds"] != null)
                {
                    dgvResults.Columns["ProductIds"].Visible = false;
                }

                lblTotalCount.Text = $"Общее число поставщиков: {result.TotalCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query1Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForProductName();
            SetupAutoCompleteForProductType();
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtProductName, используя список названий товаров.
        /// </summary>
        private void SetupAutoCompleteForProductName()
        {
            // Извлекаем все уникальные названия товаров из репозитория
            var productNames = DataRepository.Instance.Data.Products
                                .Select(p => p.Name)
                                .Distinct()
                                .ToArray();

            AutoCompleteStringCollection autoCompleteNames = new AutoCompleteStringCollection();
            autoCompleteNames.AddRange(productNames);

            // Обеспечиваем, что TextBox однострочный
            txtProductName.Multiline = false;
            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = autoCompleteNames;
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtProductType, используя список типов товаров.
        /// </summary>
        private void SetupAutoCompleteForProductType()
        {
            // Извлекаем все уникальные типы товаров из репозитория
            var productTypes = DataRepository.Instance.Data.Products
                                .Select(p => p.Type)
                                .Distinct()
                                .ToArray();

            AutoCompleteStringCollection autoCompleteTypes = new AutoCompleteStringCollection();
            autoCompleteTypes.AddRange(productTypes);

            txtProductType.Multiline = false;
            txtProductType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductType.AutoCompleteCustomSource = autoCompleteTypes;
        }
    }
}
