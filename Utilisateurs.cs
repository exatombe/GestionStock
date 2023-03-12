using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    public partial class Agents : Form
    {
        MySqlConnection sql;
        public Agents(MySqlConnection sql)
        {
            InitializeComponent();
            this.sql = sql;

        }


        private void Utilisateurs_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void userListItemIndexChange(object sender, EventArgs e)
        {
            if (userListview.SelectedItems.Count > 0)
            {
                ListViewItem item = userListview.SelectedItems[0];
                string id = item.SubItems[0].Text;
                string username = item.SubItems[1].Text;
            }
        }
        private void loadUsers()
        {
            userListview.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT username, id, isAdmin FROM users", sql);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString("username");
                int isAdmin = reader.GetInt32("isAdmin");
                int id = reader.GetInt32("id");

                Agent agent = new Agent();
                agent.id = id;
                agent.username = username;
                agent.isAdmin = Convert.ToBoolean(isAdmin);
                ListViewItem item = new ListViewItem(agent.ToString());
                item.Tag = agent;
                item.SubItems.Add(agent.isAdmin ? "Oui" : "Non");
                Font font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                item.Font = font;
                userListview.Items.Add(item);
            }
            reader.Close();

        }
        

        private void Create_Click(object sender, EventArgs e)
        {
            Utilisateur form = new Utilisateur(sql);
            DialogResult dr = form.ShowDialog();
            if(dr == DialogResult.OK)
            {
                loadUsers();
            }
        }

        private void userListview_ItemActivate(object sender, EventArgs e)
        {
            if (userListview.SelectedItems.Count > 0)
            {
                ListViewItem item = userListview.SelectedItems[0];
                Utilisateur form = new Utilisateur(sql, (Agent)item.Tag);
                form.type = "edit";
                
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    loadUsers();
                }
            }
        }
    }
}
