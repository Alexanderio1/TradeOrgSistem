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
    public partial class Query9Form : Form
    {
        public Query9Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                int? supplierId = null;
                if (!string.IsNullOrWhiteSpace(txtSupplierID.Text))
                {
                    if (int.TryParse(txtSupplierID.Text, out int sid))
                        supplierId = sid;
                    else
                    {
                        MessageBox.Show("Неверный формат Supplier ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string supplierName = txtSupplierName.Text.Trim();

                int? productId = null;
                if (!string.IsNullOrWhiteSpace(txtProductID.Text))
                {
                    if (int.TryParse(txtProductID.Text, out int pid))
                        productId = pid;
                    else
                    {
                        MessageBox.Show("Неверный формат Product ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string productName = txtProductName.Text.Trim();

                if (!productId.HasValue && string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Необходимо указать либо Product ID, либо Product Name.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime? startDate = dtpStartDate.Value;
                DateTime? endDate = dtpEndDate.Value;

                DeliveryQueryService service = new DeliveryQueryService();
                var result = service.GetDeliveriesForSupplierAndProduct(
                    supplierId, supplierName,
                    productId, productName,
                    startDate, endDate
                );

                dgvResults.DataSource = result.Deliveries;

                lblTotalCount.Text = $"Общее число поставок: {result.TotalCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupAutoCompleteForSupplierName()
        {
            var supplierNames = DataRepository.Instance.Data.Suppliers
                                    .Select(s => s.Name)
                                    .Distinct()
                                    .ToArray();
            AutoCompleteStringCollection acSuppliers = new AutoCompleteStringCollection();
            acSuppliers.AddRange(supplierNames);

            txtSupplierName.Multiline = false;
            txtSupplierName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSupplierName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSupplierName.AutoCompleteCustomSource = acSuppliers;
        }

        private void SetupAutoCompleteForProductName()
        {
            var productNames = DataRepository.Instance.Data.Products
                                    .Select(p => p.Name)
                                    .Distinct()
                                    .ToArray();
            AutoCompleteStringCollection acProducts = new AutoCompleteStringCollection();
            acProducts.AddRange(productNames);

            txtProductName.Multiline = false;
            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = acProducts;
        }

        private void Query9Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForSupplierName();
            SetupAutoCompleteForProductName();
        }
    }
}
