namespace GestionStock
{
    partial class Clients
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
            this.customerListView = new GestionStock.CustomListView();
            this.society = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customButton1 = new GestionStock.CustomButton();
            this.SuspendLayout();
            // 
            // customerListView
            // 
            this.customerListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.customerListView.AllowColumnReorder = true;
            this.customerListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.customerListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.society,
            this.columnHeader1});
            this.customerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListView.FullRowSelect = true;
            this.customerListView.GridLines = true;
            this.customerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.customerListView.HideSelection = false;
            this.customerListView.HoverSelection = true;
            this.customerListView.Location = new System.Drawing.Point(74, 115);
            this.customerListView.MultiSelect = false;
            this.customerListView.Name = "customerListView";
            this.customerListView.OwnerDraw = true;
            this.customerListView.Size = new System.Drawing.Size(969, 420);
            this.customerListView.TabIndex = 0;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            this.customerListView.ItemActivate += new System.EventHandler(this.customerListView_ItemActivate);
            // 
            // society
            // 
            this.society.Text = "Société";
            this.society.Width = 484;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Email";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 484;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.Location = new System.Drawing.Point(809, 47);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(234, 51);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Ajouter un client";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.button_client_add);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1102, 562);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.customButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clients";
            this.ShowIcon = false;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton customButton1;
        private CustomListView customerListView;
        private System.Windows.Forms.ColumnHeader society;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}