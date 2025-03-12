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
    public partial class Query6Form : Form
    {
        public Query6Form()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                int? sellerId = null;
                if (!string.IsNullOrWhiteSpace(txtSellerId.Text))
                {
                    if (int.TryParse(txtSellerId.Text, out int sid))
                        sellerId = sid;
                    else
                    {
                        MessageBox.Show("Неверный формат Seller ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string sellerName = txtSellerName.Text.Trim();

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

                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                IndividualSellerPerformanceQueryService service = new IndividualSellerPerformanceQueryService();
                var result = service.GetPerformanceForSellerAtLocation(
                    sellerId,
                    sellerName,
                    retailLocationId,
                    retailLocationName,
                    startDate,
                    endDate
                );

                lblResultSellerName.Text = $"Продавец: {result.SellerName} (ID: {result.SellerId})";
                lblResultRetailLocation.Text = $"Торговая точка: {result.RetailLocationName} (ID: {result.RetailLocationId})";
                lblTotalSalesVolume.Text = $"Общий объем продаж: {result.TotalSalesVolume}";
                lblTotalRevenue.Text = $"Общая выручка: {result.TotalRevenue:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupAutoCompleteForSellerName()
        {
            var sellerNames = DataRepository.Instance.Data.Sellers
                                .Select(s => s.Name)
                                .Distinct()
                                .ToArray();
            AutoCompleteStringCollection autoCompleteSellerNames = new AutoCompleteStringCollection();
            autoCompleteSellerNames.AddRange(sellerNames);

            txtSellerName.Multiline = false;
            txtSellerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSellerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSellerName.AutoCompleteCustomSource = autoCompleteSellerNames;
        }

        private void SetupAutoCompleteForRetailLocationName()
        {
            var locationNames = DataRepository.Instance.Data.RetailLocations
                                .Select(r => r.Name)
                                .Distinct()
                                .ToArray();
            AutoCompleteStringCollection autoCompleteLocationNames = new AutoCompleteStringCollection();
            autoCompleteLocationNames.AddRange(locationNames);

            txtRetailLocationName.Multiline = false;
            txtRetailLocationName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationName.AutoCompleteCustomSource = autoCompleteLocationNames;
        }

        private void Query6Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForSellerName();
            SetupAutoCompleteForRetailLocationName();
        }
    }
}
