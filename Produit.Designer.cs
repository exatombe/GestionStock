namespace GestionStock
{
    partial class Produit
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
            this.label2 = new System.Windows.Forms.Label();
            this.mtbfInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MakeButton = new GestionStock.CustomButton();
            this.deleteButton = new GestionStock.CustomButton();
            this.TypeSelector = new GestionStock.Select();
            this.nameInput = new GestionStock.TextInput();
            this.descInput = new GestionStock.TextInput();
            ((System.ComponentModel.ISupportInitialize)(this.mtbfInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "MTBF";
            // 
            // mtbfInput
            // 
            this.mtbfInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbfInput.Location = new System.Drawing.Point(418, 59);
            this.mtbfInput.Name = "mtbfInput";
            this.mtbfInput.Size = new System.Drawing.Size(237, 35);
            this.mtbfInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // MakeButton
            // 
            this.MakeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.MakeButton.FlatAppearance.BorderSize = 0;
            this.MakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeButton.Location = new System.Drawing.Point(421, 197);
            this.MakeButton.Name = "MakeButton";
            this.MakeButton.Size = new System.Drawing.Size(234, 51);
            this.MakeButton.TabIndex = 8;
            this.MakeButton.Text = "Créer un produit";
            this.MakeButton.UseVisualStyleBackColor = false;
            this.MakeButton.Click += new System.EventHandler(this.MakeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Brown;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(96, 197);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(234, 51);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Supprimé un produit";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // TypeSelector
            // 
            this.TypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TypeSelector.FormattingEnabled = true;
            this.TypeSelector.Location = new System.Drawing.Point(790, 56);
            this.TypeSelector.Name = "TypeSelector";
            this.TypeSelector.Size = new System.Drawing.Size(229, 37);
            this.TypeSelector.TabIndex = 2;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nameInput.Location = new System.Drawing.Point(36, 58);
            this.nameInput.MaxLength = 65;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(229, 35);
            this.nameInput.TabIndex = 1;
            // 
            // descInput
            // 
            this.descInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.descInput.Location = new System.Drawing.Point(36, 146);
            this.descInput.MaxLength = 250;
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(983, 35);
            this.descInput.TabIndex = 0;
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MakeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.mtbfInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeSelector);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.descInput);
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mtbfInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextInput descInput;
        private TextInput nameInput;
        private Select TypeSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mtbfInput;
        private CustomButton deleteButton;
        private CustomButton MakeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}