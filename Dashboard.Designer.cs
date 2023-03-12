namespace GestionStock
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.clients = new System.Windows.Forms.Button();
            this.interventions = new System.Windows.Forms.Button();
            this.loggedUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produits = new System.Windows.Forms.Button();
            this.agents = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clients);
            this.panel1.Controls.Add(this.interventions);
            this.panel1.Controls.Add(this.loggedUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.produits);
            this.panel1.Controls.Add(this.agents);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 601);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 14;
            // 
            // clients
            // 
            this.clients.BackColor = System.Drawing.Color.Transparent;
            this.clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clients.FlatAppearance.BorderSize = 0;
            this.clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients.Image = ((System.Drawing.Image)(resources.GetObject("clients.Image")));
            this.clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clients.Location = new System.Drawing.Point(0, 221);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(200, 50);
            this.clients.TabIndex = 8;
            this.clients.Text = "Clients";
            this.clients.UseVisualStyleBackColor = false;
            this.clients.Click += new System.EventHandler(this.menuClients);
            // 
            // interventions
            // 
            this.interventions.BackColor = System.Drawing.Color.Transparent;
            this.interventions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.interventions.FlatAppearance.BorderSize = 0;
            this.interventions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interventions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interventions.Image = ((System.Drawing.Image)(resources.GetObject("interventions.Image")));
            this.interventions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.interventions.Location = new System.Drawing.Point(0, 175);
            this.interventions.Name = "interventions";
            this.interventions.Size = new System.Drawing.Size(200, 50);
            this.interventions.TabIndex = 7;
            this.interventions.Text = "Interventions";
            this.interventions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.interventions.UseVisualStyleBackColor = false;
            this.interventions.Click += new System.EventHandler(this.menuInterventions);
            // 
            // loggedUser
            // 
            this.loggedUser.AutoSize = true;
            this.loggedUser.Location = new System.Drawing.Point(58, 96);
            this.loggedUser.Name = "loggedUser";
            this.loggedUser.Size = new System.Drawing.Size(54, 13);
            this.loggedUser.TabIndex = 6;
            this.loggedUser.Text = "Logged-in";
            this.loggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // produits
            // 
            this.produits.BackColor = System.Drawing.Color.Transparent;
            this.produits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produits.FlatAppearance.BorderSize = 0;
            this.produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.produits.Image = ((System.Drawing.Image)(resources.GetObject("produits.Image")));
            this.produits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produits.Location = new System.Drawing.Point(0, 128);
            this.produits.Name = "produits";
            this.produits.Size = new System.Drawing.Size(200, 50);
            this.produits.TabIndex = 2;
            this.produits.Text = "Produits";
            this.produits.UseVisualStyleBackColor = false;
            this.produits.Click += new System.EventHandler(this.menuProducts);
            // 
            // agents
            // 
            this.agents.BackColor = System.Drawing.Color.Transparent;
            this.agents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agents.FlatAppearance.BorderSize = 0;
            this.agents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agents.Image = ((System.Drawing.Image)(resources.GetObject("agents.Image")));
            this.agents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agents.Location = new System.Drawing.Point(0, 268);
            this.agents.Name = "agents";
            this.agents.Size = new System.Drawing.Size(200, 50);
            this.agents.TabIndex = 4;
            this.agents.Text = "Agents";
            this.agents.UseVisualStyleBackColor = false;
            this.agents.Click += new System.EventHandler(this.menuUsers);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Plum;
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(0, 567);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(200, 34);
            this.logout.TabIndex = 0;
            this.logout.Text = "Deconnexion";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logoutButton);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelTitle);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(919, 70);
            this.panel2.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelTitle.AutoSize = true;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(387, 9);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(181, 54);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Text = "Accueil";
            this.panelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formPanel
            // 
            this.formPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formPanel.AutoScroll = true;
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(199, 66);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(919, 535);
            this.formPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 601);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button produits;
        private System.Windows.Forms.Button agents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label panelTitle;
        private System.Windows.Forms.Label loggedUser;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button interventions;
        private System.Windows.Forms.Label label2;
    }
}