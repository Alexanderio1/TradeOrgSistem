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
    public partial class RetailLocationsManagementForm : Form
    {
        private RetailLocationManagementService _service;

        public RetailLocationsManagementForm()
        {
            InitializeComponent();
            _service = new RetailLocationManagementService();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (string.IsNullOrWhiteSpace(txtNewLocationId.Text))
                {
                    id = _service.GetNextRetailLocationId();
                }
                else
                {
                    if (!int.TryParse(txtNewLocationId.Text.Trim(), out id))
                    {
                        MessageBox.Show("Неверный формат ID торговой точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (_service.GetAllRetailLocations().Any(l => l.Id == id))
                {
                    MessageBox.Show("Торговая точка с таким ID уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = txtNewLocationName.Text.Trim();
                string type = txtNewLocationType.Text.Trim();
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Введите название и тип торговой точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtNewLocationArea.Text.Trim(), out decimal area))
                {
                    MessageBox.Show("Неверный формат торговой площади.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtNewLocationHalls.Text.Trim(), out int halls))
                {
                    MessageBox.Show("Неверный формат числа торговых залов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtNewLocationCounters.Text.Trim(), out int counters))
                {
                    MessageBox.Show("Неверный формат числа прилавков.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtNewLocationRent.Text.Trim(), out decimal rent))
                {
                    MessageBox.Show("Неверный формат аренды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtNewLocationUtilities.Text.Trim(), out decimal utilities))
                {
                    MessageBox.Show("Неверный формат коммунальных платежей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RetailLocation newLocation = new RetailLocation
                {
                    Id = id,
                    Name = name,
                    Type = type,
                    Area = area,
                    NumberOfHalls = halls,
                    NumberOfCounters = counters,
                    Rent = rent,
                    Utilities = utilities
                };

                _service.AddRetailLocation(newLocation);
                MessageBox.Show("Торговая точка успешно добавлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLocationsGrid();
                txtNewLocationId.Clear();
                txtNewLocationName.Clear();
                txtNewLocationType.Clear();
                txtNewLocationArea.Clear();
                txtNewLocationHalls.Clear();
                txtNewLocationCounters.Clear();
                txtNewLocationRent.Clear();
                txtNewLocationUtilities.Clear();
                SetNextLocationId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления торговой точки:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLocations.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите торговую точку для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                RetailLocation selectedLocation = (RetailLocation)dgvLocations.SelectedRows[0].DataBoundItem;

                string newName = txtEditLocationName.Text.Trim();
                string newType = txtEditLocationType.Text.Trim();
                if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newType))
                {
                    MessageBox.Show("Введите новое название и тип торговой точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtEditLocationArea.Text.Trim(), out decimal newArea))
                {
                    MessageBox.Show("Неверный формат торговой площади.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtEditLocationHalls.Text.Trim(), out int newHalls))
                {
                    MessageBox.Show("Неверный формат числа торговых залов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtEditLocationCounters.Text.Trim(), out int newCounters))
                {
                    MessageBox.Show("Неверный формат числа прилавков.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtEditLocationRent.Text.Trim(), out decimal newRent))
                {
                    MessageBox.Show("Неверный формат аренды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtEditLocationUtilities.Text.Trim(), out decimal newUtilities))
                {
                    MessageBox.Show("Неверный формат коммунальных платежей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedLocation.Name = newName;
                selectedLocation.Type = newType;
                selectedLocation.Area = newArea;
                selectedLocation.NumberOfHalls = newHalls;
                selectedLocation.NumberOfCounters = newCounters;
                selectedLocation.Rent = newRent;
                selectedLocation.Utilities = newUtilities;

                _service.UpdateRetailLocation(selectedLocation);
                MessageBox.Show("Торговая точка успешно обновлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLocationsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования торговой точки:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLocations.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите торговую точку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                RetailLocation selectedLocation = (RetailLocation)dgvLocations.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить торговую точку \"{selectedLocation.Name}\"?",
                                                     "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _service.DeleteRetailLocation(selectedLocation.Id);
                    MessageBox.Show("Торговая точка успешно удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshLocationsGrid();
                    SetNextLocationId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления торговой точки:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetailLocationsManagementForm_Load(object sender, EventArgs e)
        {
            RefreshLocationsGrid();
            SetupAutoComplete();
            SetNextLocationId();
        }

        private void RefreshLocationsGrid()
        {
            dgvLocations.DataSource = null;
            dgvLocations.DataSource = _service.GetAllRetailLocations();
        }
        private void SetupAutoComplete()
        {
            var locationNames = _service.GetAllRetailLocations().Select(l => l.Name).Distinct().ToArray();
            AutoCompleteStringCollection acNames = new AutoCompleteStringCollection();
            acNames.AddRange(locationNames);
            txtNewLocationName.Multiline = false;
            txtNewLocationName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNewLocationName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNewLocationName.AutoCompleteCustomSource = acNames;

            var locationTypes = _service.GetAllRetailLocations().Select(l => l.Type).Distinct().ToArray();
            AutoCompleteStringCollection acTypes = new AutoCompleteStringCollection();
            acTypes.AddRange(locationTypes);
            txtNewLocationType.Multiline = false;
            txtNewLocationType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNewLocationType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNewLocationType.AutoCompleteCustomSource = acTypes;
        }

        private void SetNextLocationId()
        {
            if (string.IsNullOrWhiteSpace(txtNewLocationId.Text))
            {
                int nextId = _service.GetNextRetailLocationId();
                txtNewLocationId.Text = nextId.ToString();
            }
        }
    }
}
