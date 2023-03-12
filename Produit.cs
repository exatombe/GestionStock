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
    public partial class Produit : Form
    {
        private MySqlConnection sql;
        public Product product = new Product();
        public string type = "add";
        public Produit(MySqlConnection sql, Product product = null)
        {
            this.sql = sql;
            if(product != null)
            {
                this.product = product;
            }
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE id=@id", sql);
            cmd.Parameters.AddWithValue("@id", this.product.id);
            try
            {
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vous ne pouvez pas créer/modifié cet utilisateur car ce nom d'utilisateur est déja pris");
            }

        }

        private void Produit_Load(object sender, EventArgs e)
        {
            if(this.type != "add")
            {
                nameInput.Text = this.product.name;
                mtbfInput.Value = this.product.mtbf;
                descInput.Text = this.product.description;
                MakeButton.Text = "Modifier le produit";
            }
            else
            {
                deleteButton.Visible = false;
            }
            List<string> typeToSelect = new List<string>();
            typeToSelect.Add("ordinateur");
            typeToSelect.Add("souris");
            typeToSelect.Add("imprimante");
            typeToSelect.Add("cartouche");
            typeToSelect.Add("clavier");
            foreach(string t in typeToSelect)
            {
                TypeSelector.Items.Add(t);
              if (this.type != "add")
            {
                    if (this.product.type == t)
                    TypeSelector.SelectedItem = t;
            }  
            }

            
            
        }

        private void MakeButton_Click(object sender, EventArgs e)
        {
            string sqlStatement = "INSERT INTO products (name, description, type, mtbf) VALUES (@name, @description, @type, @mtbf)";
            if (this.type != "add")
            {
                sqlStatement = "UPDATE products SET name=@name, description=@description, type=@type, mtbf=@mtbf WHERE id=@id";
            }
            MySqlCommand cmd = new MySqlCommand(sqlStatement, sql);
            cmd.Parameters.AddWithValue("@name", nameInput.Text);
            cmd.Parameters.AddWithValue("@description", descInput.Text);
            cmd.Parameters.AddWithValue("@type", TypeSelector.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@mtbf", mtbfInput.Value);
            if (this.type != "add")
            {
                cmd.Parameters.AddWithValue("@id", this.product.id);
            }
            try
            {
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vous ne pouvez pas créer/modifié ce produit, car il existe déja");
            }
        }
        
        
    }
}