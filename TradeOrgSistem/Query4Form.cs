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
                if (!productId.HasValue && string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Необходимо указать либо Product ID, либо Product Name.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

                ProductPriceVolumeQueryService service = new ProductPriceVolumeQueryService();
                var result = service.GetProductPriceVolumeInfo(productId, productName, retailLocationType, retailLocationId, retailLocationName);

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
