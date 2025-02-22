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
    public partial class CustomersManagementForm : Form
    {
        private CustomerManagementService _service;

        public CustomersManagementForm()
        {
            InitializeComponent();
            _service = new CustomerManagementService();
        }

        /// <summary>
        /// Обновляет DataGridView, загружая список покупателей.
        /// </summary>
        private void RefreshCustomerGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _service.GetAllCustomers();
        }

        /// <summary>
        /// Настраивает автодополнение для txtNewCustomerName на основе уже существующих имен покупателей.
        /// </summary>
        private void SetupAutoCompleteForCustomerName()
        {
            var customerNames = _service.GetAllCustomers().Select(c => c.Name).Distinct().ToArray();
            AutoCompleteStringCollection acNames = new AutoCompleteStringCollection();
            acNames.AddRange(customerNames);
            txtNewCustomerName.Multiline = false;
            txtNewCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNewCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNewCustomerName.AutoCompleteCustomSource = acNames;
        }

        /// <summary>
        /// Если поле txtNewCustomerId пустое, автоматически подставляет следующий доступный ID.
        /// </summary>
        private void SetNextCustomerId()
        {
            if (string.IsNullOrWhiteSpace(txtNewCustomerId.Text))
            {
                int nextId = _service.GetNextCustomerId();
                txtNewCustomerId.Text = nextId.ToString();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (string.IsNullOrWhiteSpace(txtNewCustomerId.Text))
                {
                    id = _service.GetNextCustomerId();
                }
                else
                {
                    if (!int.TryParse(txtNewCustomerId.Text.Trim(), out id))
                    {
                        MessageBox.Show("Неверный формат ID покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Проверяем, что покупатель с таким ID не существует
                if (_service.GetAllCustomers().Any(c => c.Id == id))
                {
                    MessageBox.Show("Покупатель с таким ID уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = txtNewCustomerName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Введите имя покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Customer newCustomer = new Customer
                {
                    Id = id,
                    Name = name
                };

                _service.AddCustomer(newCustomer);
                MessageBox.Show("Покупатель успешно добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCustomerGrid();
                txtNewCustomerId.Clear();
                txtNewCustomerName.Clear();
                SetNextCustomerId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления покупателя:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите покупателя для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Customer selectedCustomer = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;
                string newName = txtEditCustomerName.Text.Trim();
                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Введите новое имя покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                selectedCustomer.Name = newName;
                _service.UpdateCustomer(selectedCustomer);
                MessageBox.Show("Покупатель успешно обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCustomerGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования покупателя:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите покупателя для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Customer selectedCustomer = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить покупателя \"{selectedCustomer.Name}\"?",
                                                     "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _service.DeleteCustomer(selectedCustomer.Id);
                    MessageBox.Show("Покупатель успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshCustomerGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления покупателя:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomersManagementForm_Load(object sender, EventArgs e)
        {
            RefreshCustomerGrid();
            SetupAutoCompleteForCustomerName();
            SetNextCustomerId();
        }
    }
}
