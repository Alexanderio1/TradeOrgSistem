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
    public partial class SellersManagementForm : Form
    {
        private SellerManagementService _service;

        public SellersManagementForm()
        {
            InitializeComponent();
            _service = new SellerManagementService();
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (string.IsNullOrWhiteSpace(txtNewSellerId.Text))
                {
                    id = _service.GetNextSellerId();
                }
                else
                {
                    if (!int.TryParse(txtNewSellerId.Text.Trim(), out id))
                    {
                        MessageBox.Show("Неверный формат ID продавца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (_service.GetAllSellers().Any(s => s.Id == id))
                {
                    MessageBox.Show("Продавец с таким ID уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = txtNewSellerName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Введите имя продавца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtNewRetailLocationId.Text.Trim(), out int retailLocationId))
                {
                    MessageBox.Show("Неверный формат ID торговой точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtNewSellerSalary.Text.Trim(), out decimal salary))
                {
                    MessageBox.Show("Неверный формат зарплаты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Seller newSeller = new Seller
                {
                    Id = id,
                    Name = name,
                    RetailLocationId = retailLocationId,
                    Salary = salary
                };

                _service.AddSeller(newSeller);
                MessageBox.Show("Продавец успешно добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSellerGrid();
                txtNewSellerId.Clear();
                txtNewSellerName.Clear();
                txtNewRetailLocationId.Clear();
                txtNewSellerSalary.Clear();
                SetNextSellerId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления продавца:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSellers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите продавца для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Seller selectedSeller = (Seller)dgvSellers.SelectedRows[0].DataBoundItem;

                string newName = txtEditSellerName.Text.Trim();
                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Введите новое имя продавца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtEditRetailLocationId.Text.Trim(), out int newRetailLocationId))
                {
                    MessageBox.Show("Неверный формат ID торговой точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtEditSellerSalary.Text.Trim(), out decimal newSalary))
                {
                    MessageBox.Show("Неверный формат зарплаты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedSeller.Name = newName;
                selectedSeller.RetailLocationId = newRetailLocationId;
                selectedSeller.Salary = newSalary;

                _service.UpdateSeller(selectedSeller);
                MessageBox.Show("Продавец успешно обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSellerGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования продавца:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSellers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите продавца для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Seller selectedSeller = (Seller)dgvSellers.SelectedRows[0].DataBoundItem;
                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить продавца \"{selectedSeller.Name}\"?",
                                                     "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _service.DeleteSeller(selectedSeller.Id);
                    MessageBox.Show("Продавец успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSellerGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления продавца:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SellersManagementForm_Load(object sender, EventArgs e)
        {
            RefreshSellerGrid();
            SetupAutoCompleteForSellerName();
            SetNextSellerId();
        }

        /// <summary>
        /// Обновляет DataGridView, загружая список продавцов.
        /// </summary>
        private void RefreshSellerGrid()
        {
            dgvSellers.DataSource = null;
            dgvSellers.DataSource = _service.GetAllSellers();
        }

        /// <summary>
        /// Настраивает автодополнение для поля txtNewSellerName на основе уникальных имен продавцов.
        /// </summary>
        private void SetupAutoCompleteForSellerName()
        {
            var sellerNames = _service.GetAllSellers().Select(s => s.Name).Distinct().ToArray();
            AutoCompleteStringCollection acNames = new AutoCompleteStringCollection();
            acNames.AddRange(sellerNames);
            txtNewSellerName.Multiline = false;
            txtNewSellerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNewSellerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNewSellerName.AutoCompleteCustomSource = acNames;
        }

        /// <summary>
        /// Если поле для нового продавца ID пустое, устанавливает следующий доступный ID.
        /// </summary>
        private void SetNextSellerId()
        {
            if (string.IsNullOrWhiteSpace(txtNewSellerId.Text))
            {
                int nextId = _service.GetNextSellerId();
                txtNewSellerId.Text = nextId.ToString();
            }
        }
    }
}
