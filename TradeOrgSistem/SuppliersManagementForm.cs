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
    public partial class SuppliersManagementForm : Form
    {
        private SupplierManagementService _service;

        public SuppliersManagementForm()
        {
            InitializeComponent();
            _service = new SupplierManagementService();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (string.IsNullOrWhiteSpace(txtNewSupplierId.Text))
                {
                    id = _service.GetNextSupplierId();
                }
                else
                {
                    if (!int.TryParse(txtNewSupplierId.Text.Trim(), out id))
                    {
                        MessageBox.Show("Неверный формат ID поставщика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Проверяем, не занят ли уже этот ID
                if (_service.GetAllSuppliers().Any(s => s.Id == id))
                {
                    MessageBox.Show("Поставщик с таким ID уже существует. Выберите другой ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = txtNewSupplierName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Введите имя поставщика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Supplier newSupplier = new Supplier
                {
                    Id = id,
                    Name = name
                };

                _service.AddSupplier(newSupplier);
                MessageBox.Show("Поставщик успешно добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSupplierGrid();
                // После добавления – сбрасываем поля, назначаем следующий ID
                txtNewSupplierId.Clear();
                txtNewSupplierName.Clear();
                SetNextSupplierId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления поставщика:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSuppliers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите поставщика для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Supplier selectedSupplier = (Supplier)dgvSuppliers.SelectedRows[0].DataBoundItem;

                // Считываем новое имя из поля txtEditSupplierName
                string newName = txtEditSupplierName.Text.Trim();
                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Введите новое имя поставщика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                selectedSupplier.Name = newName;

                _service.UpdateSupplier(selectedSupplier);
                MessageBox.Show("Поставщик успешно обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSupplierGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования поставщика:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSuppliers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите поставщика для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Supplier selectedSupplier = (Supplier)dgvSuppliers.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить поставщика \"{selectedSupplier.Name}\"?",
                                                     "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _service.DeleteSupplier(selectedSupplier.Id);
                    MessageBox.Show("Поставщик успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSupplierGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления поставщика:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuppliersManagementForm_Load(object sender, EventArgs e)
        {
            RefreshSupplierGrid();
            SetupAutoComplete();
            SetNextSupplierId();
        }

        /// <summary>
        /// Загружает список поставщиков в DataGridView.
        /// </summary>
        private void RefreshSupplierGrid()
        {
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = _service.GetAllSuppliers();
        }

        /// <summary>
        /// Настраивает автодополнение для txtNewSupplierName на основе уже существующих имён поставщиков.
        /// </summary>
        private void SetupAutoComplete()
        {
            var supplierNames = _service.GetAllSuppliers().Select(s => s.Name).Distinct().ToArray();
            AutoCompleteStringCollection acNames = new AutoCompleteStringCollection();
            acNames.AddRange(supplierNames);

            txtNewSupplierName.Multiline = false;
            txtNewSupplierName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNewSupplierName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNewSupplierName.AutoCompleteCustomSource = acNames;
        }

        /// <summary>
        /// Если поле для ID нового поставщика пустое, назначаем следующий доступный ID.
        /// </summary>
        private void SetNextSupplierId()
        {
            if (string.IsNullOrWhiteSpace(txtNewSupplierId.Text))
            {
                int nextId = _service.GetNextSupplierId();
                txtNewSupplierId.Text = nextId.ToString();
            }
        }
    }
}
