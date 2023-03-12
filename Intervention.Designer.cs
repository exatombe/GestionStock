namespace GestionStock
{
    partial class Intervention
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
            this.productSelector = new GestionStock.Select();
            this.dateSelector = new System.Windows.Forms.DateTimePicker();
            this.agentSelector = new GestionStock.Select();
            this.commentaireInput = new GestionStock.TextInput();
            this.makeButton = new GestionStock.CustomButton();
            this.deleteInter = new GestionStock.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productSelector
            // 
            this.productSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.productSelector.FormattingEnabled = true;
            this.productSelector.Location = new System.Drawing.Point(450, 79);
            this.productSelector.Name = "productSelector";
            this.productSelector.Size = new System.Drawing.Size(229, 37);
            this.productSelector.TabIndex = 1;
            // 
            // dateSelector
            // 
            this.dateSelector.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelector.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSelector.Location = new System.Drawing.Point(839, 79);
            this.dateSelector.Name = "dateSelector";
            this.dateSelector.Size = new System.Drawing.Size(155, 35);
            this.dateSelector.TabIndex = 6;
            // 
            // agentSelector
            // 
            this.agentSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.agentSelector.FormattingEnabled = true;
            this.agentSelector.Location = new System.Drawing.Point(64, 79);
            this.agentSelector.Name = "agentSelector";
            this.agentSelector.Size = new System.Drawing.Size(229, 37);
            this.agentSelector.TabIndex = 7;
            // 
            // commentaireInput
            // 
            this.commentaireInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.commentaireInput.Location = new System.Drawing.Point(64, 168);
            this.commentaireInput.Multiline = true;
            this.commentaireInput.Name = "commentaireInput";
            this.commentaireInput.Size = new System.Drawing.Size(974, 117);
            this.commentaireInput.TabIndex = 8;
            // 
            // makeButton
            // 
            this.makeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.makeButton.FlatAppearance.BorderSize = 0;
            this.makeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeButton.Location = new System.Drawing.Point(494, 304);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(234, 51);
            this.makeButton.TabIndex = 9;
            this.makeButton.Text = "Créer une intervention";
            this.makeButton.UseVisualStyleBackColor = false;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // deleteInter
            // 
            this.deleteInter.BackColor = System.Drawing.Color.Brown;
            this.deleteInter.FlatAppearance.BorderSize = 0;
            this.deleteInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInter.Location = new System.Drawing.Point(202, 304);
            this.deleteInter.Name = "deleteInter";
            this.deleteInter.Size = new System.Drawing.Size(234, 51);
            this.deleteInter.TabIndex = 10;
            this.deleteInter.Text = "Supprimer";
            this.deleteInter.UseVisualStyleBackColor = false;
            this.deleteInter.Click += new System.EventHandler(this.deleteInter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(834, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date d\'intervention";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Commentaire";
            // 
            // Intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 367);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteInter);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.commentaireInput);
            this.Controls.Add(this.agentSelector);
            this.Controls.Add(this.dateSelector);
            this.Controls.Add(this.productSelector);
            this.Name = "Intervention";
            this.Text = "Intervention";
            this.Load += new System.EventHandler(this.Intervention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Select productSelector;
        private System.Windows.Forms.DateTimePicker dateSelector;
        private Select agentSelector;
        private TextInput commentaireInput;
        private CustomButton makeButton;
        private CustomButton deleteInter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}