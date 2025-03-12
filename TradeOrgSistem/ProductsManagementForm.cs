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
    public partial class ProductsManagementForm : Form
    {
        private ProductManagementService _service;

        public ProductsManagementForm()
        {
            InitializeComponent();
            _service = new ProductManagementService();
        }

        private void RefreshProductGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = _service.GetAllProducts();
        }

        private void SetupAutoComplete()
        {
            var productNames = _service.GetAllProducts().Select(p => p.Name).Distinct().ToArray();
            AutoCompleteStringCollection acNames = new AutoCompleteStringCollection();
            acNames.AddRange(productNames);
            txtNewProductName.Multiline = false;
            txtNewProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNewProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNewProductName.AutoCompleteCustomSource = acNames;

            var productTypes = _service.GetAllProducts().Select(p => p.Type).Distinct().ToArray();
            AutoCompleteStringCollection acTypes = new AutoCompleteStringCollection();
            acTypes.AddRange(productTypes);
            txtNewProductType.Multiline = false;
            txtNewProductType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNewProductType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNewProductType.AutoCompleteCustomSource = acTypes;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (string.IsNullOrWhiteSpace(txtNewProductId.Text))
                {
                    id = _service.GetNextProductId();
                }
                else
                {
                    if (!int.TryParse(txtNewProductId.Text.Trim(), out id))
                    {
                        MessageBox.Show("Неверный формат ID товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (_service.GetAllProducts().Any(p => p.Id == id))
                {
                    MessageBox.Show("Товар с таким ID уже существует. Пожалуйста, выберите другой ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = txtNewProductName.Text.Trim();
                string type = txtNewProductType.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Пожалуйста, введите название и тип товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Product newProduct = new Product
                {
                    Id = id,
                    Name = name,
                    Type = type
                };

                _service.AddProduct(newProduct);
                MessageBox.Show("Товар успешно добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshProductGrid();
                if (string.IsNullOrWhiteSpace(txtNewProductId.Text))
                    SetNextProductId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления товара:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetNextProductId()
        {
            if (string.IsNullOrWhiteSpace(txtNewProductId.Text))
            {
                int nextId = _service.GetNextProductId();
                txtNewProductId.Text = nextId.ToString();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите товар для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Product selectedProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

                selectedProduct.Name = txtEditProductName.Text.Trim();
                selectedProduct.Type = txtEditProductType.Text.Trim();

                _service.UpdateProduct(selectedProduct);
                MessageBox.Show("Товар успешно обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования товара:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите товар для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Product selectedProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить товар \"{selectedProduct.Name}\"?",
                                                     "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _service.DeleteProduct(selectedProduct.Id);
                    MessageBox.Show("Товар успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshProductGrid();
                    SetNextProductId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления товара:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductsManagementForm_Load(object sender, EventArgs e)
        {
            RefreshProductGrid();
            SetupAutoComplete();
            SetNextProductId();
        }
    }
}
