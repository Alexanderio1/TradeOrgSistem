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
    public partial class Query3Form : Form
    {
        public Query3Form()
        {
            InitializeComponent();
        }


        private void SetupAutoCompleteForRetailLocationName()
        {
            var names = DataRepository.Instance.Data.RetailLocations.Select(r => r.Name).ToArray();

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(names);

            txtRetailLocationName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRetailLocationName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRetailLocationName.AutoCompleteCustomSource = autoCompleteCollection;
        }


        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                int? retailLocationId = null;
                if (!string.IsNullOrWhiteSpace(txtRetailLocationID.Text))
                {
                    if (int.TryParse(txtRetailLocationID.Text, out int id))
                        retailLocationId = id;
                    else
                    {
                        MessageBox.Show("Неверный формат Retail Location ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string retailLocationName = txtRetailLocationName.Text.Trim();

                RetailLocationQueryService service = new RetailLocationQueryService();
                var result = service.GetInventoryForRetailLocation(retailLocationId, retailLocationName);


                dgvResults.DataSource = result.InventoryItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query3Form_Load(object sender, EventArgs e)
        {
            SetupAutoCompleteForRetailLocationName();
        }
    }
}
