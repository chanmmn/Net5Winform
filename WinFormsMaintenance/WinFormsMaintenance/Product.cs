using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMaintenance.Model;

namespace WinFormsMaintenance
{
    public partial class Product : Form
    {
        public List<Products> list = new List<Products>();
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            list = productList.GetAllProducts();

            var bindingList = new BindingList<Products>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = from r in list where r.ProductID == int.Parse(txtProductID.Text) select r;
            result.First().ProductName = txtProductName.Text;
            var bindingList = new BindingList<Products>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                int pid = int.Parse(txtProductID.Text);
                var result = from r in list where r.ProductID == pid select r;
                list.Remove(result.First());
                var bindingList = new BindingList<Products>(list);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ProductID = int.Parse(txtProductID.Text);
            product.ProductName = txtProductName.Text;
            list.Add(product);

            var bindingList = new BindingList<Products>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
