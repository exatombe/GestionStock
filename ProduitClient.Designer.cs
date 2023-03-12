namespace GestionStock
{
    partial class ProduitClient
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
            this.productButtonAdd = new GestionStock.CustomButton();
            this.productButtonRemove = new GestionStock.CustomButton();
            this.serialInput = new GestionStock.TextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.productSelects = new GestionStock.Select();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productButtonAdd
            // 
            this.productButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.productButtonAdd.FlatAppearance.BorderSize = 0;
            this.productButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButtonAdd.Location = new System.Drawing.Point(413, 164);
            this.productButtonAdd.Name = "productButtonAdd";
            this.productButtonAdd.Size = new System.Drawing.Size(228, 51);
            this.productButtonAdd.TabIndex = 0;
            this.productButtonAdd.Text = "Ajouté un produit";
            this.productButtonAdd.UseVisualStyleBackColor = false;
            this.productButtonAdd.Click += new System.EventHandler(this.productButtonAdd_Click);
            // 
            // productButtonRemove
            // 
            this.productButtonRemove.BackColor = System.Drawing.Color.Brown;
            this.productButtonRemove.FlatAppearance.BorderSize = 0;
            this.productButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButtonRemove.Location = new System.Drawing.Point(104, 164);
            this.productButtonRemove.Name = "productButtonRemove";
            this.productButtonRemove.Size = new System.Drawing.Size(229, 53);
            this.productButtonRemove.TabIndex = 9;
            this.productButtonRemove.Text = "Supprimé le Produit";
            this.productButtonRemove.UseVisualStyleBackColor = false;
            this.productButtonRemove.Click += new System.EventHandler(this.productButtonRemove_Click);
            // 
            // serialInput
            // 
            this.serialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.serialInput.Location = new System.Drawing.Point(412, 110);
            this.serialInput.Name = "serialInput";
            this.serialInput.Size = new System.Drawing.Size(229, 35);
            this.serialInput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "N° Série";
            // 
            // productSelects
            // 
            this.productSelects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productSelects.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.productSelects.FormattingEnabled = true;
            this.productSelects.Location = new System.Drawing.Point(104, 110);
            this.productSelects.Name = "productSelects";
            this.productSelects.Size = new System.Drawing.Size(229, 37);
            this.productSelects.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produit";
            // 
            // ProduitClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productSelects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialInput);
            this.Controls.Add(this.productButtonRemove);
            this.Controls.Add(this.productButtonAdd);
            this.Name = "ProduitClient";
            this.Text = "ProduitClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProduitClient_FormClosed);
            this.Load += new System.EventHandler(this.ProduitClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton productButtonAdd;
        private CustomButton productButtonRemove;
        private TextInput serialInput;
        private System.Windows.Forms.Label label1;
        private Select productSelects;
        private System.Windows.Forms.Label label2;
    }
}