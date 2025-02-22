using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgSistem
{
    public partial class DataManagementForm : Form
    {
        public DataManagementForm()
        {
            InitializeComponent();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ProductsManagementForm productsForm = new ProductsManagementForm();
            productsForm.Show();
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersManagementForm suppliersForm = new SuppliersManagementForm();
            suppliersForm.Show();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomersManagementForm customersForm = new CustomersManagementForm();
            customersForm.Show();
        }

        private void btnManageRetailLocations_Click(object sender, EventArgs e)
        {
            RetailLocationsManagementForm retailLocationsForm = new RetailLocationsManagementForm();
            retailLocationsForm.Show();
        }

        private void btnManageDeliveries_Click(object sender, EventArgs e)
        {
            DeliveriesManagementForm deliveriesForm = new DeliveriesManagementForm();
            deliveriesForm.Show();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            SalesManagementForm salesForm = new SalesManagementForm();
            salesForm.Show();
        }

        private void btnManageSellers_Click(object sender, EventArgs e)
        {
            SellersManagementForm sellersForm = new SellersManagementForm();
            sellersForm.Show();
        }
    }
}
