namespace GestionStock
{
    partial class Interventions
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
            this.createIntervention = new GestionStock.CustomButton();
            this.customListView1 = new GestionStock.CustomListView();
            this.Agent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // createIntervention
            // 
            this.createIntervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.createIntervention.FlatAppearance.BorderSize = 0;
            this.createIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createIntervention.Location = new System.Drawing.Point(776, 83);
            this.createIntervention.Name = "createIntervention";
            this.createIntervention.Size = new System.Drawing.Size(229, 51);
            this.createIntervention.TabIndex = 1;
            this.createIntervention.Text = "Créer une intervention";
            this.createIntervention.UseVisualStyleBackColor = false;
            this.createIntervention.Click += new System.EventHandler(this.createIntervention_Click);
            // 
            // customListView1
            // 
            this.customListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.customListView1.AllowColumnReorder = true;
            this.customListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customListView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.customListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Agent,
            this.Date,
            this.columnHeader3,
            this.columnHeader1});
            this.customListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customListView1.FullRowSelect = true;
            this.customListView1.GridLines = true;
            this.customListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.customListView1.HideSelection = false;
            this.customListView1.HoverSelection = true;
            this.customListView1.Location = new System.Drawing.Point(74, 154);
            this.customListView1.MultiSelect = false;
            this.customListView1.Name = "customListView1";
            this.customListView1.OwnerDraw = true;
            this.customListView1.Size = new System.Drawing.Size(969, 387);
            this.customListView1.TabIndex = 0;
            this.customListView1.UseCompatibleStateImageBehavior = false;
            this.customListView1.View = System.Windows.Forms.View.Details;
            this.customListView1.ItemActivate += new System.EventHandler(this.customListView1_ItemActivate);
            // 
            // Agent
            // 
            this.Agent.Text = "Agent";
            this.Agent.Width = 242;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 242;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Produit(Serial)";
            this.columnHeader3.Width = 242;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client";
            this.columnHeader1.Width = 242;
            // 
            // Interventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 601);
            this.Controls.Add(this.customListView1);
            this.Controls.Add(this.createIntervention);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interventions";
            this.Text = "Interventions";
            this.Load += new System.EventHandler(this.Interventions_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton createIntervention;
        private CustomListView customListView1;
        private System.Windows.Forms.ColumnHeader Agent;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}