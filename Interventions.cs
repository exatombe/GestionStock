using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Interventions : Form
    {
        MySqlConnection sql;
        public Interventions(MySqlConnection sql)
        {
            this.sql = sql;
            InitializeComponent();
        }
        
        private void Interventions_Load(object sender, EventArgs e)
        {
            this.loadInterventions();
        }

        private void createIntervention_Click(object sender, EventArgs e)
        {
            Intervention intervention = new Intervention(sql);
            DialogResult dr = intervention.ShowDialog();
            if(dr == DialogResult.OK)
            {
                customListView1.Items.Clear();
                this.loadInterventions();
            }
        }

        public void loadInterventions()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM interventions;\r\n;\r\n;\r\n", sql);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                DateTime date = reader.GetDateTime("date");
                string serial = reader.GetString("serial");
                string name = reader.GetString("name");
                int mtbf = reader.GetInt32("mtbf");
                int agent_id = reader.GetInt32("agent_id");
                string agent_name = reader.GetString("agent_name");
                string customer = reader.GetString("customer");
                string commentaire;
                if (reader.IsDBNull(1))
                {
                    commentaire = "Pas de commentaire";
                }
                else
                {
                    commentaire = reader.GetString("commentaire");
                }

                Agent agent = new Agent();
                agent.id = agent_id;
                agent.username = agent_name;
                Customer client = new Customer();
                client.society = customer;
                Product produit = new Product();
                produit.mtbf = mtbf;
                produit.serial = serial;
                produit.name = name;
                Procedure intervention = new Procedure();
                intervention.agent = agent;
                intervention.client = client;
                intervention.commentaire = commentaire;
                intervention.produit = produit;
                intervention.date = date;
                intervention.id = id;

                ListViewItem item = new ListViewItem(intervention.agent.username);
                item.SubItems.Add(intervention.date.ToShortDateString());
                item.SubItems.Add(intervention.produit.ToString());
                item.SubItems.Add(intervention.client.society);
                item.Tag = intervention;
                item.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                customListView1.Items.Add(item);
            }
            reader.Close();
        }

        private void customListView1_ItemActivate(object sender, EventArgs e)
        {
            if(customListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = customListView1.SelectedItems[0];
                Intervention intervention = new Intervention(sql, (Procedure)item.Tag);
                intervention.type = "edit";
            DialogResult dr = intervention.ShowDialog();
            if (dr == DialogResult.OK)
            {
                customListView1.Items.Clear();
                this.loadInterventions();
            }
            }
           
        }
    }
}
