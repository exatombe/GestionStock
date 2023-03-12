using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using Microsoft.Win32;

namespace GestionStock
{
    public partial class Login : Form
    {
        
        MySqlConnection sql;
        string connectType = "login";
        private Form activeForm = null;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                    sql = new MySqlConnection("server=localhost;user id=root;database=gestionstock");
                    sql.Open();
                    Console.WriteLine("Connected");
                // Check if the user has already logged in, if so, skip the login form
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\GestionStock");
                if (key != null)
                {
                    string username = key.GetValue("username").ToString();
                    string password = key.GetValue("password").ToString();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", sql);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();          
                        this.Size = new Size(1300, 720);
                        this.MaximumSize = new Size(1300, 720);
                        this.MinimumSize = new Size(1300, 720);
                        Form form2 = new Dashboard(sql);
                        OpenDefaultForm(form2);
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Identifiants invalides");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }

        }

        private void loginOrRegister(object sender, EventArgs e)
        {
            string password = passwordprompt.Text;
            string username = userprompt.Text;
            SHA256 pass = SHA256.Create();
            byte[] hash = pass.ComputeHash(Encoding.UTF8.GetBytes(password));
            string passHashed = Convert.ToBase64String(hash);
            if (connectType == "login")
            {
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", sql);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", passHashed);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            reader.Close();
                            this.Size = new Size(1300, 720);
                            this.MaximumSize = new Size(1300, 720);
                            this.MinimumSize = new Size(1300, 720);
                            Form form2 = new Dashboard(sql);
                            OpenDefaultForm(form2);
                            passwordprompt.Text = "";
                            userprompt.Text = "";
                            loginerr.Visible = true;
                            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GestionStock");
                            key.SetValue("username", username);
                            key.SetValue("password", passHashed);
                        }
                        else
                        {
                            reader.Close();
                            loginerr.Text = "Echec de connexion, mot de passe invalide.";
                            loginerr.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        loginerr.Text = "Echec de connexion, erreur inconnue.";
                        loginerr.Visible = true;
                        MessageBox.Show("Erreur de connexion : " + ex.Message);
                    }
                }
            }
            else if (connectType == "register")
            {
                { 
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", sql);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", passHashed);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            this.Size = new Size(1300, 720);
                            this.MaximumSize = new Size(1300, 720);
                            this.MinimumSize = new Size(1300, 720);
                            Form form2 = new Dashboard(sql);
                            OpenDefaultForm(form2);
                            passwordprompt.Text = "";
                            userprompt.Text = "";
                            loginerr.Visible = false;
                            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GestionStock");
                            key.SetValue("username", username);
                            key.SetValue("password", passHashed);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Erreur: " + ex.Message);
                        }
                  
                    }
                catch (Exception ex)
                {
                        loginerr.Text = "Erreur d'inscription d'origine inconnue";
                        loginerr.Visible = true;
                    MessageBox.Show("Erreur d'inscription : " + ex.Message);
                }
            }
                
            }
        }

      

        private void loginOrRegisterChoice(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(connectType == "login")

            {
                connectType = "register";
                linkLabel1.Text = "Vous avez déja un compte ?";
                button1.Text = "S'enregistrer";
                labelTitle.Text = "Inscription";
            }
            else
            {
                connectType = "login";
                linkLabel1.Text = "Pas de compte ?";
                button1.Text = "Se connecter";
                labelTitle.Text = "Connexion";
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
                panel1.Controls.Add(childform);
                panel1.Tag = childform;
                childform.BringToFront();
                childform.Show();
                childform.FormClosed += new FormClosedEventHandler(delegate (object senders, FormClosedEventArgs args)
                {
                    activeForm = null;
                });
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
