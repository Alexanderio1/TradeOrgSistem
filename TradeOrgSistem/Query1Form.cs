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

                string productName = txtProductName.Text.Trim();
                string productType = txtProductType.Text.Trim();

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

                DateTime? startDate = dtpStartDate.Value;
                DateTime? endDate = dtpEndDate.Value;

                SupplierQueryService service = new SupplierQueryService();

                var result = service.GetSuppliersByProductCriteria(productType, productId, productName, minVolume, startDate, endDate);

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

        private void SetupAutoCompleteForProductName()
        {
            var productNames = DataRepository.Instance.Data.Products
                                .Select(p => p.Name)
                                .Distinct()
                                .ToArray();

            AutoCompleteStringCollection autoCompleteNames = new AutoCompleteStringCollection();
            autoCompleteNames.AddRange(productNames);

            txtProductName.Multiline = false;
            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = autoCompleteNames;
        }

        private void SetupAutoCompleteForProductType()
        {
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
