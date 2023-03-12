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
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace GestionStock
{
    public partial class Utilisateur : Form
    {
        private MySqlConnection sql;
        public Agent agent = new Agent();
        public string type = "add";
        public Utilisateur(MySqlConnection sql, Agent agent = null)
        {
            this.sql = sql;
            if(agent != null)
            {
                this.agent = agent;
            }
            InitializeComponent();
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {
            if(this.type != "add")
            {
                userInput.Text = this.agent.username;
                addAgent.Text = "Modifié l'agent";
            }
            else
            {
                deleteUser.Visible = false;  
            }
        }
        
        private string passwordCrypted(string password)
        {
            SHA256 pass = SHA256.Create();
            byte[] hash = pass.ComputeHash(Encoding.UTF8.GetBytes(password));
            string passHashed = Convert.ToBase64String(hash);
            return passHashed;
        }

        private void addAgent_Click(object sender, EventArgs e)
        {
            if (userInput.Text.Length > 1)
            {
                string sqlStatement = "INSERT INTO users (username, password) VALUES (@username,@password)";
                if (this.type != "add")
                {
                    sqlStatement = "UPDATE users SET username=@username WHERE id=@id";
                    if (passwordInput.Text.Length > 1)
                    {
                        if (this.type != "add")
                        {
                            sqlStatement = "UPDATE users SET username=@username, password=@password WHERE id=@id";
                        }
                    }
                    
                }                    
               
                MySqlCommand cmd = new MySqlCommand(sqlStatement, sql);
                cmd.Parameters.AddWithValue("@username", userInput.Text);                
                cmd.Parameters.AddWithValue("@password", passwordCrypted(passwordInput.Text));
                if(this.type != "add")
                {
                    cmd.Parameters.AddWithValue("@id", this.agent.id);
                }
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
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id=@id",sql);
            cmd.Parameters.AddWithValue("@id", this.agent.id);
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\GestionStock");
            string username = key.GetValue("username").ToString();
            if(this.agent.username == username)
            {
                MessageBox.Show("Impossible de vous auto-supprimé");
                return;
            }

            if (this.agent.isAdmin)
            {
                MessageBox.Show("Impossible de supprimé un administrateur");
                return;
            }

           try
            {
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(MySqlException err)
            {
                MessageBox.Show("Une erreur innatendu c'est produite:\n\r" + err.Message);
            }
        }
    }
}
