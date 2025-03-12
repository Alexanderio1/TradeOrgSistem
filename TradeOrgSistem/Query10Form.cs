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
    public partial class Query10Form : Form
    {
        public Query10Form()
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

                if (cmbNormalizationFactor.SelectedItem == null)
                {
                    MessageBox.Show("Выберите тип нормализации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string normFactorStr = cmbNormalizationFactor.SelectedItem.ToString();
                if (!Enum.TryParse(normFactorStr, out NormalizationFactor normalizationFactor))
                {
                    MessageBox.Show("Неверный тип нормализации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SellerNormalizedPerformanceQueryService service = new SellerNormalizedPerformanceQueryService();
                var result = service.GetNormalizedPerformance(
                    sellerId, sellerName,
                    retailLocationId, retailLocationName,
                    startDate, endDate,
                    normalizationFactor
                );

                lblResultSeller.Text = $"Продавец: {result.SellerName} (ID: {result.SellerId})";
                lblResultRetailLocation.Text = $"Торговая точка: {result.RetailLocationName} (ID: {result.RetailLocationId})";
                lblResultRetailLocation.Text = $"Общий объем продаж: {result.TotalSalesVolume}";
                lblNormalizationValue.Text = $"Нормировочное значение: {result.NormalizationValue}";
                lblRatio.Text = $"Отношение (объем/нормировка): {result.Ratio}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query10Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForSellerName();
            SetupAutoCompleteForRetailLocationName();
            SetupNormalizationFactorCombo();
        }

        private void SetupAutoCompleteForSellerName()
        {
            var sellerNames = DataRepository.Instance.Data.Sellers
                                .Select(s => s.Name)
                                .Distinct()
                                .ToArray();
            AutoCompleteStringCollection acSellerNames = new AutoCompleteStringCollection();
            acSellerNames.AddRange(sellerNames);

            txtSellerName.Multiline = false;
            txtSellerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSellerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSellerName.AutoCompleteCustomSource = acSellerNames;
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

        private void SetupNormalizationFactorCombo()
        {
            cmbNormalizationFactor.Items.Clear();
            foreach (var factor in Enum.GetNames(typeof(NormalizationFactor)))
            {
                cmbNormalizationFactor.Items.Add(factor);
            }
            cmbNormalizationFactor.SelectedIndex = 0;
        }
    }
}
