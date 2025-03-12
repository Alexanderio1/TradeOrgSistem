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

                DateTime? startDate = dtpStartDate.Value;
                DateTime? endDate = dtpEndDate.Value;

                CustomerQueryService service = new CustomerQueryService();
                var result = service.GetCustomersByProductCriteria(
                    productType,
                    productId,
                    productName,
                    minVolume,
                    startDate,
                    endDate
                );

                dgvResults.DataSource = result.Customers;


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

        private void SetupAutoCompleteForProductName()
        {
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

        private void SetupAutoCompleteForProductType()
        {
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
