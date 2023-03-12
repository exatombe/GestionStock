using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionStock
{
    public partial class ProduitClient : Form
    {
        private MySqlConnection sql;
        public Customer client;
        public Product product = new Product();
        public string type = "add";
        public bool deleted = false;
        public bool error = false;
        public ProduitClient(MySqlConnection sql, Customer client, Product product = null)
        {
            this.sql = sql;
            this.client = client;
            if (product != null)
            {
                this.product = product;
            }
            InitializeComponent();
        }

        private void ProduitClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ProduitClient_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM products", sql);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
                string description = reader.GetString("description");
                string type = reader.GetString("type");
                int mtbf = reader.GetInt32("mtbf");

                Product productToSelect = new Product();
                productToSelect.id = id;
                productToSelect.name = name;
                productToSelect.description = description;
                productToSelect.type = type;
                productToSelect.mtbf = mtbf;

                productSelects.Items.Add(productToSelect);
                if(productToSelect.id == product.id)
                {
                    productSelects.SelectedItem = productToSelect;
                }
            }
            reader.Close();
            if(type != "add")
            {
                // get index of the current Product based on the id
                serialInput.Text = product.serial;
                productButtonAdd.Text = "Modifié le produit";
            }
            else
            {
                productButtonRemove.Visible = false;
            }
        }

        private void productButtonAdd_Click(object sender, EventArgs e)
        {
            if (serialInput.Text != "" && productSelects.SelectedIndex != -1)
            {
                Product productSelected = (Product)productSelects.SelectedItem;
                string sqlStatement = "INSERT INTO product_customer (product_id, customer_id, n_serie) VALUES (@product_id, @customer_id, @n_serie)";
                if (type != "add")
                {
                    sqlStatement = "UPDATE product_customer SET product_id=@product_id, n_serie=@n_serie WHERE n_serie=@old_serial";
                }
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, sql);
                cmd.Parameters.AddWithValue("@product_id", productSelected.id);
                cmd.Parameters.AddWithValue("@customer_id", client.id);
                cmd.Parameters.AddWithValue("@n_serie", serialInput.Text);
                cmd.Parameters.AddWithValue("@old_serial", product.serial);
                product = productSelected;
                product.serial = serialInput.Text;
                try
                {
                   cmd.ExecuteNonQuery();
                }catch(MySqlException err)
                {
                    this.error = true;
                    MessageBox.Show("Ce numéro de série existe déja dans le système");
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void productButtonRemove_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd= new MySqlCommand("DELETE FROM product_customer WHERE n_serie=@n_serie", sql);
            cmd.Parameters.AddWithValue("@n_serie", product.serial);
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            this.deleted = true;
            this.Close();

        }
    }
}