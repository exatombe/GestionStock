using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Clients : Form
    {
        MySqlConnection sql;
        public Clients(MySqlConnection sql)
        {
            this.sql = sql;
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers", sql);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string society = reader.GetString("society");
                string email = reader.GetString("email");
                Customer client = new Customer();

                client.id = id;
                client.society = society;
                client.email = email;

                ListViewItem item = new ListViewItem(client.society);
                item.SubItems.Add(client.email);
                item.Tag = client;
                item.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                customerListView.Items.Add(item);
            }
            reader.Close();
        }

        private void button_client_add(object sender, EventArgs e)
        {
            Client client = new Client(sql);
            if (client.ShowDialog() == DialogResult.OK)
            {
                Customer customer = client.customer;
                ListViewItem item = new ListViewItem(customer.society);
                item.SubItems.Add(customer.email);
                item.Tag = customer;
                item.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                customerListView.Items.Add(item);

            }
        }

        private void customerListView_ItemActivate(object sender, EventArgs e)
        {
            if(customerListView.SelectedItems.Count > 0)
            {
                ListViewItem item = customerListView.SelectedItems[0];
                Client client = new Client(sql, (Customer)item.Tag);
                client.type = "update";
                if(client.ShowDialog() == DialogResult.OK)
                {
                    if (!client.error)
                    {
                        if (client.deleted)
                        {
                            customerListView.Items.Remove(item);
                        }
                        else
                        {
                             item.Text = client.customer.society;
                    item.SubItems[1].Text = client.customer.email;
                    customerListView.Items[item.Index] = item;
                        }
                       
                    }
                    client.Dispose();
                }
            }
        }
    }
}
