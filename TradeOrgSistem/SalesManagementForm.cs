using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradeOrgSistem.Models;
using TradeOrgSistem.Services;

namespace TradeOrgSistem
{
    public partial class SalesManagementForm : Form
    {
        private SaleManagementService _service;

        public SalesManagementForm()
        {
            InitializeComponent();
            _service = new SaleManagementService();
        }

        private void RefreshSalesGrid()
        {
            dgvSales.DataSource = null;
            dgvSales.DataSource = _service.GetAllSales();
        }

        private void SetNextSaleId()
        {
            if (string.IsNullOrWhiteSpace(txtNewSaleId.Text))
            {
                int nextId = _service.GetNextSaleId();
                txtNewSaleId.Text = nextId.ToString();
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (string.IsNullOrWhiteSpace(txtNewSaleId.Text))
                    id = _service.GetNextSaleId();
                else if (!int.TryParse(txtNewSaleId.Text.Trim(), out id))
                {
                    MessageBox.Show("Неверный формат ID продажи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_service.GetAllSales().Any(s => s.Id == id))
                {
                    MessageBox.Show("Продажа с таким ID уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtNewCustomerId.Text.Trim(), out int customerId))
                {
                    MessageBox.Show("Неверный формат Customer ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtNewRetailLocationId.Text.Trim(), out int retailLocationId))
                {
                    MessageBox.Show("Неверный формат Retail Location ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtNewSellerId.Text.Trim(), out int sellerId))
                {
                    MessageBox.Show("Неверный формат Seller ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtNewProductId.Text.Trim(), out int productId))
                {
                    MessageBox.Show("Неверный формат Product ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime saleDate = dtpNewSaleDate.Value;
                if (!int.TryParse(txtNewVolume.Text.Trim(), out int volume))
                {
                    MessageBox.Show("Неверный формат объёма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtNewPrice.Text.Trim(), out decimal price))
                {
                    MessageBox.Show("Неверный формат цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Sale newSale = new Sale
                {
                    Id = id,
                    CustomerId = customerId,
                    RetailLocationId = retailLocationId,
                    SellerId = sellerId,
                    ProductId = productId,
                    Date = saleDate,
                    Volume = volume,
                    Price = price
                };

                _service.AddSale(newSale);
                MessageBox.Show("Продажа успешно добавлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSalesGrid();
                txtNewSaleId.Clear();
                txtNewCustomerId.Clear();
                txtNewRetailLocationId.Clear();
                txtNewSellerId.Clear();
                txtNewProductId.Clear();
                txtNewVolume.Clear();
                txtNewPrice.Clear();
                SetNextSaleId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления продажи:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSales.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите продажу для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Sale selectedSale = (Sale)dgvSales.SelectedRows[0].DataBoundItem;

                if (!int.TryParse(txtEditCustomerId.Text.Trim(), out int newCustomerId))
                {
                    MessageBox.Show("Неверный формат Customer ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtEditRetailLocationId.Text.Trim(), out int newRetailLocationId))
                {
                    MessageBox.Show("Неверный формат Retail Location ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtEditSellerId.Text.Trim(), out int newSellerId))
                {
                    MessageBox.Show("Неверный формат Seller ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtEditProductId.Text.Trim(), out int newProductId))
                {
                    MessageBox.Show("Неверный формат Product ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime newSaleDate = dtpEditSaleDate.Value;
                if (!int.TryParse(txtEditVolume.Text.Trim(), out int newVolume))
                {
                    MessageBox.Show("Неверный формат объёма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtEditPrice.Text.Trim(), out decimal newPrice))
                {
                    MessageBox.Show("Неверный формат цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedSale.CustomerId = newCustomerId;
                selectedSale.RetailLocationId = newRetailLocationId;
                selectedSale.SellerId = newSellerId;
                selectedSale.ProductId = newProductId;
                selectedSale.Date = newSaleDate;
                selectedSale.Volume = newVolume;
                selectedSale.Price = newPrice;

                _service.UpdateSale(selectedSale);
                MessageBox.Show("Продажа успешно обновлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSalesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования продажи:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSales.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите продажу для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Sale selectedSale = (Sale)dgvSales.SelectedRows[0].DataBoundItem;
                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить продажу с ID {selectedSale.Id}?",
                                                     "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _service.DeleteSale(selectedSale.Id);
                    MessageBox.Show("Продажа успешно удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSalesGrid();
                    SetNextSaleId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления продажи:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalesManagementForm_Load(object sender, EventArgs e)
        {
            RefreshSalesGrid();
            SetNextSaleId();
        }
    }
}
