using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionStock
{
    public partial class Client : Form
    {
        private MySqlConnection sql;
        public Customer customer = new Customer();
        public string type = "add";
        public bool error = false;
        public bool deleted = false;
        public Client(MySqlConnection sql, Customer client= null)
        {
            this.sql = sql;
            if (client != null)
            {
                this.customer = client;
            }
            InitializeComponent();
           
        }

        private void Client_Load(object sender, EventArgs e)
        {
           if (type != "add")
            {
                label1.Text = "Modifier un client";
                societyInput.Text = this.customer.society;
                emailInput.Text = this.customer.email;
                clientButton.Text = "Mettre à jour le client";
                MySqlCommand cmd = new MySqlCommand("CALL `productCustomer`(@id);\r\n", sql);
                cmd.Parameters.AddWithValue("@id", customer.id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bool defaut = reader.GetBoolean("defaut");
                    string serial = reader.GetString("serial");
                    string type = reader.GetString("type");
                    int id = reader.GetInt32("id");
                    int mtbf = reader.GetInt32("mtbf");
                    string name = reader.GetString("name");
                    Product product = new Product();
                    product.mtbf = mtbf;
                    product.id = id;
                    product.type = type;
                    product.serial = serial;
                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(product.type);
                    item.SubItems.Add(product.serial);
                    item.SubItems.Add(defaut ? "Oui" : "Non");
                    item.Tag = product;
                    item.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                    customListView1.Items.Add(item);
                }
                reader.Close();
            }
            else
            {
                productList.Visible = false;
                deleteCustomer.Visible = false;
            }
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            ProduitClient form = new ProduitClient(sql, customer);
            DialogResult dr = form.ShowDialog();
            if(dr == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.product.name);
                item.SubItems.Add(form.product.type);
                item.SubItems.Add(form.product.serial);
                item.SubItems.Add("Non");
                item.Tag = form.product;
                item.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                customListView1.Items.Add(item);
            }
        }

        private void customListView1_ItemActivate(object sender, EventArgs e)
        {
            if (customListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = customListView1.SelectedItems[0];
                ProduitClient form = new ProduitClient(sql, customer, (Product)item.Tag);
                form.type = "update";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.deleted)
                    {
                        customListView1.Items.Remove(item);
                    }
                    else
                    {
                        if (form.error) return;
                        item.Text = form.product.name;
                        item.SubItems[1].Text = form.product.type;
                        item.SubItems[2].Text = form.product.serial;
                        customListView1.Items[item.Index] = item;
                    }
                    
                }
            }
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
              if(societyInput.Text != "" && emailInput.Text != "")
              {
                string sqlStatement = "INSERT INTO customers (society, email) VALUES (@society, @email)";
                    customer.society = societyInput.Text;
                    customer.email = emailInput.Text;
                        if(type != "add")
                        {
                    sqlStatement = "UPDATE customers SET society=@society, email=@email WHERE id=@id";
                        }               
               MySqlCommand cmd = new MySqlCommand(sqlStatement, sql);
                cmd.Parameters.AddWithValue("@society", customer.society);
                cmd.Parameters.AddWithValue("@email", customer.email);
                cmd.Parameters.AddWithValue("@id", customer.id);
                try
                {
                    cmd.ExecuteNonQuery();
                }catch(MySqlException err)
                {
                    MessageBox.Show("Impossible de modifié l'email, il existe déja");
                    this.error = true;
                    this.Close();
                }
                if(type == "add")
                {
                    this.customer.id = int.Parse(cmd.LastInsertedId.ToString());
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM customers WHERE id=@id", sql);
            cmd.Parameters.AddWithValue("@id", customer.id);
            cmd.ExecuteNonQuery();
            this.deleted = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
