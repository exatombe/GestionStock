using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Produits : Form
    {
        MySqlConnection sql;
        public Produits(MySqlConnection sql)
        {
            InitializeComponent();
            this.sql = sql;
        }

        private void Produits_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        public void loadProducts()
        {
            productListView.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM products", sql);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // get name, id, type and mtbf
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
                string description = reader.GetString("description");
                string type = reader.GetString("type");
                int mtbf = reader.GetInt32("mtbf");

                Product product = new Product();
                product.id = id;
                product.name = name;
                product.description = description;
                product.type = type;
                product.mtbf = mtbf;

                ListViewItem item = new ListViewItem(product.name);
                item.SubItems.Add(type);
                item.SubItems.Add(mtbf.ToString());
                item.Tag = product;
                item.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                productListView.Items.Add(item);
            }
            reader.Close();
        }

        private void createProduct(object sender, EventArgs e)
        {
            Produit form = new Produit(sql);
            if(form.ShowDialog() == DialogResult.OK)
            {
                loadProducts();
            }
        }

        private void productListView_ItemActivate(object sender, EventArgs e)
        {
            if (productListView.SelectedItems.Count > 0)
            {
                ListViewItem item = productListView.SelectedItems[0];
                Produit form = new Produit(sql, (Product)item.Tag);
                form.type = "update";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    loadProducts();
                }
            }
        }
    }
}
