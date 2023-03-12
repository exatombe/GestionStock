using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace GestionStock
{
    public partial class Intervention : Form
    {
        private MySqlConnection sql;
        public Procedure inter = new Procedure();
        public string type = "add";
        public bool deleted = false;
        public Intervention(MySqlConnection sql,Procedure procedure = null)
        {
            this.sql = sql;
            if(procedure != null)
            {
                this.inter = procedure;
            }
            InitializeComponent();
        }

        internal class Status
        {
            public string name { get; set; }
            public int type { get; set; }

            public override string ToString()
            {
                return this.name;
            }
        }

        private void Intervention_Load(object sender, EventArgs e)
        {
            MySqlCommand agents = new MySqlCommand("SELECT * FROM users", sql);
            MySqlDataReader reader = agents.ExecuteReader();
            MySqlCommand products = new MySqlCommand("SELECT pc.n_serie as serial, p.name as name, pc.product_id as id, p.type as type, p.mtbf as mtbf FROM product_customer AS pc JOIN products AS p ON pc.product_id = p.id;\r\n", sql);
            while (reader.Read())
            {
                Agent agent = new Agent();
                agent.id = reader.GetInt32("id");
                agent.username = reader.GetString("username");
                agent.isAdmin = Convert.ToBoolean(reader.GetInt32("isAdmin"));
                agentSelector.Items.Add(agent);
                if(this.type != "add")
                {
                     if (this.inter.agent.id == agent.id)
                {
                    agentSelector.SelectedItem = agent;
                }
                }
               
            }
            reader.Close();

            reader = products.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.mtbf = reader.GetInt32("mtbf");
                product.id = reader.GetInt32("id");
                product.type = reader.GetString("type");
                product.name = reader.GetString("name");
                product.serial = reader.GetString("serial");
                productSelector.Items.Add(product);
                if (this.type != "add")
                {
                    if (this.inter.produit.serial == product.serial)
                    {
                        productSelector.SelectedItem = product;
                    }
                }

            }
            reader.Close();

            if(this.type != "add")
            {
                 dateSelector.Value = this.inter.date;
                commentaireInput.Text = this.inter.commentaire;
                makeButton.Text = "Modifié une intervention";
            }
            else
            {
               deleteInter.Visible = false;
            }
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            if (productSelector.SelectedItem != null && agentSelector.SelectedItem != null)
            {
                string sqlStatement = "INSERT INTO intervention (product_id, agent_id, date, commentaire) VALUES (@product_id, @agent_id, @date, @commentaire)";
                if (this.type != "add")
                {
                    sqlStatement = "UPDATE intervention SET product_id=@product_id, agent_id=@agent_id, date=@date, status=@status WHERE id=@id";
                }
                MySqlCommand cmd = new MySqlCommand(sqlStatement, sql);
                cmd.Parameters.AddWithValue("@product_id", ((Product)productSelector.SelectedItem).serial);
                cmd.Parameters.AddWithValue("@agent_id", ((Agent)agentSelector.SelectedItem).id);
                cmd.Parameters.AddWithValue("@date", dateSelector.Value);
                cmd.Parameters.AddWithValue("@commentaire", commentaireInput.Text.Length > 0 ? commentaireInput.Text : "");
                this.inter.produit = (Product)productSelector.SelectedItem;
                this.inter.agent = (Agent)agentSelector.SelectedItem;
                this.inter.commentaire = commentaireInput.Text.Length > 0 ? commentaireInput.Text : "";
                this.inter.date = dateSelector.Value;
                if (this.type != "add")
                {
                    cmd.Parameters.AddWithValue("@id", this.inter.id);
                }
                try
                {
                                cmd.ExecuteNonQuery();
                    if (this.type == "add")
                    {
                        this.inter.id = int.Parse(cmd.LastInsertedId.ToString());
                    }
                 this.DialogResult = DialogResult.OK;
            this.Close();
                }catch(MySqlException err)
                {
                    MessageBox.Show("Une erreur inatendu c'est produite : " + err.Message);

                }

            }
            else
            {
                MessageBox.Show("Vous devez selectionnez un agent et un produit au minimum pour pouvoir le créer/modifié");
            }
        }

        private void deleteInter_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM intervention WHERE id=@id", sql);
            cmd.Parameters.AddWithValue("@id", this.inter.id);
            try
            {
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Une erreur inatendu c'est produite : " + err.Message);

            }
        }
    }
}
