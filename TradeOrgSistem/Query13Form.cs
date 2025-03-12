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
    public partial class Query13Form : Form
    {
        public Query13Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
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
                string productName = txtProductName.Text.Trim();
                string productType = txtProductType.Text.Trim();

                if (!productId.HasValue && string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Необходимо указать либо Product ID, либо Product Name.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime? startDate = dtpStartDate.Value;
                DateTime? endDate = dtpEndDate.Value;

                int? retailLocationId = null;
                if (!string.IsNullOrWhiteSpace(txtRetailLocationId.Text))
                {
                    if (int.TryParse(txtRetailLocationId.Text, out int rid))
                        retailLocationId = rid;
                    else
                    {
                        MessageBox.Show("Неверный формат Retail Location ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string retailLocationName = txtRetailLocationName.Text.Trim();
                string retailLocationType = txtRetailLocationType.Text.Trim();

                ProductCustomerQueryService service = new ProductCustomerQueryService();
                var result = service.GetCustomersForProduct(
                    productId,
                    productName,
                    productType,
                    startDate,
                    endDate,
                    retailLocationId,
                    retailLocationName,
                    retailLocationType
                );

                dgvResults.DataSource = result.Customers;
                lblTotalCount.Text = $"Общее число покупателей: {result.TotalCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void SetupAutoCompleteForProductType()
        {
            var productTypes = DataRepository.Instance.Data.Products
                                .Select(p => p.Type)
                                .Distinct()
                                .ToArray();
            AutoCompleteStringCollection acTypes = new AutoCompleteStringCollection();
            acTypes.AddRange(productTypes);
            txtProductType.Multiline = false;
            txtProductType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductType.AutoCompleteCustomSource = acTypes;
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

        private void Query13Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForProductName();
            SetupAutoCompleteForProductType();
            SetupAutoCompleteForRetailLocationName();
            SetupAutoCompleteForRetailLocationType();
        }
    }
}
