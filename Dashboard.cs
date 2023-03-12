using Microsoft.Win32;
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
    public partial class Dashboard : Form
    {
        private Form activeForm = null;
        public MySqlConnection sql;
        public Dashboard(MySqlConnection sql)
        {
            this.sql = sql;
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(128, Color.Snow);
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\GestionStock");
            if(registryKey != null)
            {
                string userCurrent = registryKey.GetValue("username").ToString();
                loggedUser.Text = "Logged as " + userCurrent;
            }
            ToolTip logoutToolTip = new ToolTip();
            logoutToolTip.SetToolTip(logout, "Déconnexion");

        }

        private void logoutButton(object sender, EventArgs e)
        {
            Registry.CurrentUser.DeleteSubKey("SOFTWARE\\GestionStock");
            this.Close();
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        public void OpenDefaultForm(Form childform)
        {
            {
                if (activeForm != null)
                    activeForm.Close();
                activeForm = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                formPanel.Controls.Add(childform);
                formPanel.Tag = childform;
                panelTitle.Text = childform.Text;
                childform.BringToFront();
                childform.Show();
            }
        }

        private void menuProducts(object sender, EventArgs e)
        {
            Form productForm = new Produits(sql);

            OpenDefaultForm(productForm);
        }

        private void menuUsers(object sender, EventArgs e)
        {
            // Utilisateurs
            Form userForm = new Agents(sql);
            OpenDefaultForm(userForm);
        }

        private void menuClients(object sender, EventArgs e)
        {
            // Clients
            Form clientForm = new Clients(sql);
            OpenDefaultForm(clientForm);
        }

        private void menuInterventions(object sender, EventArgs e)
        {
            // Interventions
            Form interventionForm = new Interventions(sql);
            OpenDefaultForm(interventionForm);
        }


    }
}
