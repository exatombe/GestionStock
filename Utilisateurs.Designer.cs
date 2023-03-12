namespace GestionStock
{
    partial class Agents
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
            this.userListview = new GestionStock.CustomListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Create = new GestionStock.CustomButton();
            this.SuspendLayout();
            // 
            // userListview
            // 
            this.userListview.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.userListview.AllowColumnReorder = true;
            this.userListview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userListview.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.userListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListview.FullRowSelect = true;
            this.userListview.GridLines = true;
            this.userListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.userListview.HideSelection = false;
            this.userListview.HoverSelection = true;
            this.userListview.Location = new System.Drawing.Point(74, 161);
            this.userListview.MultiSelect = false;
            this.userListview.Name = "userListview";
            this.userListview.OwnerDraw = true;
            this.userListview.Size = new System.Drawing.Size(969, 420);
            this.userListview.TabIndex = 0;
            this.userListview.UseCompatibleStateImageBehavior = false;
            this.userListview.View = System.Windows.Forms.View.Details;
            this.userListview.ItemActivate += new System.EventHandler(this.userListview_ItemActivate);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom d\'utilisateur";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 484;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Est admin ?";
            this.columnHeader3.Width = 484;
            // 
            // Create
            // 
            this.Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.Create.FlatAppearance.BorderSize = 0;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(809, 64);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(234, 51);
            this.Create.TabIndex = 9;
            this.Create.Text = "Créer";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 690);
            this.Controls.Add(this.userListview);
            this.Controls.Add(this.Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agents";
            this.Text = "Agents";
            this.Load += new System.EventHandler(this.Utilisateurs_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton Create;
        private CustomListView userListview;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}