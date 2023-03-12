namespace GestionStock
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.GroupBox();
            this.productButton = new GestionStock.CustomButton();
            this.customListView1 = new GestionStock.CustomListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteCustomer = new GestionStock.CustomButton();
            this.clientButton = new GestionStock.CustomButton();
            this.societyInput = new GestionStock.TextInput();
            this.emailInput = new GestionStock.TextInput();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.productList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Créer un client";
            // 
            // productList
            // 
            this.productList.Controls.Add(this.productButton);
            this.productList.Controls.Add(this.customListView1);
            this.productList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productList.Location = new System.Drawing.Point(0, 277);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(1221, 550);
            this.productList.TabIndex = 3;
            this.productList.TabStop = false;
            this.productList.Text = "Produits";
            // 
            // productButton
            // 
            this.productButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.productButton.FlatAppearance.BorderSize = 0;
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton.Location = new System.Drawing.Point(920, 28);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(255, 54);
            this.productButton.TabIndex = 11;
            this.productButton.Text = "Ajouté un produit";
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // customListView1
            // 
            this.customListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.customListView1.AllowColumnReorder = true;
            this.customListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customListView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.customListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.customListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customListView1.FullRowSelect = true;
            this.customListView1.GridLines = true;
            this.customListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.customListView1.HideSelection = false;
            this.customListView1.HoverSelection = true;
            this.customListView1.Location = new System.Drawing.Point(29, 97);
            this.customListView1.MultiSelect = false;
            this.customListView1.Name = "customListView1";
            this.customListView1.OwnerDraw = true;
            this.customListView1.Size = new System.Drawing.Size(1180, 420);
            this.customListView1.TabIndex = 0;
            this.customListView1.UseCompatibleStateImageBehavior = false;
            this.customListView1.View = System.Windows.Forms.View.Details;
            this.customListView1.ItemActivate += new System.EventHandler(this.customListView1_ItemActivate);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nom";
            this.columnHeader5.Width = 295;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 295;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "N°série";
            this.columnHeader7.Width = 295;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Défaut";
            this.columnHeader8.Width = 295;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Societé";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 228;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 228;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "N° Série";
            this.columnHeader3.Width = 228;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "défault ?";
            this.columnHeader4.Width = 228;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.deleteCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clientButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.societyInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 277);
            this.panel1.TabIndex = 8;
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteCustomer.BackColor = System.Drawing.Color.Brown;
            this.deleteCustomer.FlatAppearance.BorderSize = 0;
            this.deleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomer.Location = new System.Drawing.Point(234, 196);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(217, 65);
            this.deleteCustomer.TabIndex = 8;
            this.deleteCustomer.Text = "Supprimé le client";
            this.deleteCustomer.UseVisualStyleBackColor = false;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // clientButton
            // 
            this.clientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.clientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.clientButton.FlatAppearance.BorderSize = 0;
            this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(527, 196);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(217, 65);
            this.clientButton.TabIndex = 2;
            this.clientButton.Text = "Créer le client";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // societyInput
            // 
            this.societyInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.societyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.societyInput.Location = new System.Drawing.Point(234, 136);
            this.societyInput.MaxLength = 250;
            this.societyInput.Name = "societyInput";
            this.societyInput.Size = new System.Drawing.Size(378, 35);
            this.societyInput.TabIndex = 4;
            // 
            // emailInput
            // 
            this.emailInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.emailInput.Location = new System.Drawing.Point(683, 136);
            this.emailInput.MaxLength = 250;
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(325, 35);
            this.emailInput.TabIndex = 5;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1238, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productList);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.productList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomButton clientButton;
        private System.Windows.Forms.GroupBox productList;
        private TextInput societyInput;
        private TextInput emailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private CustomButton productButton;
        private CustomListView customListView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel1;
        private CustomButton deleteCustomer;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}