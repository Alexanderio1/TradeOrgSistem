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
    public partial class DeliveriesManagementForm : Form
    {
        private DeliveryManagementService _service;

        public DeliveriesManagementForm()
        {
            InitializeComponent();
            _service = new DeliveryManagementService();
        }

        private void RefreshDeliveryGrid()
        {
            dgvDeliveries.DataSource = null;
            dgvDeliveries.DataSource = _service.GetAllDeliveries();
        }

        private void SetNextDeliveryId()
        {
            if (string.IsNullOrWhiteSpace(txtNewDeliveryId.Text))
            {
                int nextId = _service.GetNextDeliveryId();
                txtNewDeliveryId.Text = nextId.ToString();
            }
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (string.IsNullOrWhiteSpace(txtNewDeliveryId.Text))
                    id = _service.GetNextDeliveryId();
                else if (!int.TryParse(txtNewDeliveryId.Text.Trim(), out id))
                {
                    MessageBox.Show("Неверный формат ID поставки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_service.GetAllDeliveries().Any(d => d.Id == id))
                {
                    MessageBox.Show("Поставка с таким ID уже существует. Выберите другой ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtNewSupplierId.Text.Trim(), out int supplierId))
                {
                    MessageBox.Show("Неверный формат Supplier ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtNewProductId.Text.Trim(), out int productId))
                {
                    MessageBox.Show("Неверный формат Product ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime date = dtpDeliveryDate.Value;
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
                string orderNumber = txtNewOrderNumber.Text.Trim();

                Delivery newDelivery = new Delivery
                {
                    Id = id,
                    SupplierId = supplierId,
                    ProductId = productId,
                    Date = date,
                    Volume = volume,
                    Price = price,
                    OrderNumber = orderNumber
                };

                _service.AddDelivery(newDelivery);
                MessageBox.Show("Поставка успешно добавлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDeliveryGrid();
                txtNewDeliveryId.Clear();
                txtNewSupplierId.Clear();
                txtNewProductId.Clear();
                txtNewOrderNumber.Clear();
                txtNewVolume.Clear();
                txtNewPrice.Clear();
                SetNextDeliveryId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления поставки:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDeliveries.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите поставку для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Delivery selectedDelivery = (Delivery)dgvDeliveries.SelectedRows[0].DataBoundItem;

                if (!int.TryParse(txtEditSupplierId.Text.Trim(), out int newSupplierId))
                {
                    MessageBox.Show("Неверный формат Supplier ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtEditProductId.Text.Trim(), out int newProductId))
                {
                    MessageBox.Show("Неверный формат Product ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime newDate = dtpEditDeliveryDate.Value;
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
                string newOrderNumber = txtEditOrderNumber.Text.Trim();

                selectedDelivery.SupplierId = newSupplierId;
                selectedDelivery.ProductId = newProductId;
                selectedDelivery.Date = newDate;
                selectedDelivery.Volume = newVolume;
                selectedDelivery.Price = newPrice;
                selectedDelivery.OrderNumber = newOrderNumber;

                _service.UpdateDelivery(selectedDelivery);
                MessageBox.Show("Поставка успешно обновлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDeliveryGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования поставки:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDeliveries.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите поставку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Delivery selectedDelivery = (Delivery)dgvDeliveries.SelectedRows[0].DataBoundItem;
                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить поставку с номером заказа \"{selectedDelivery.OrderNumber}\"?",
                                                     "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _service.DeleteDelivery(selectedDelivery.Id);
                    MessageBox.Show("Поставка успешно удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDeliveryGrid();
                    SetNextDeliveryId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления поставки:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeliveriesManagementForm_Load(object sender, EventArgs e)
        {
            RefreshDeliveryGrid();
            SetNextDeliveryId();
        }
    }
}
