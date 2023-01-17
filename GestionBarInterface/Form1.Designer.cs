namespace GestionBarInterface
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChoixTable = new System.Windows.Forms.Label();
            this.gpbCreationCommande = new System.Windows.Forms.GroupBox();
            this.txbPrixTotal = new System.Windows.Forms.TextBox();
            this.cmbSelectionBiere = new System.Windows.Forms.ComboBox();
            this.btnValiderCommande = new System.Windows.Forms.Button();
            this.cmbSelectionTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.Consommation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChoixCocktail = new System.Windows.Forms.Label();
            this.cmbSelectionCocktail = new System.Windows.Forms.ComboBox();
            this.gpbCreationCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoixTable
            // 
            this.lblChoixTable.AutoSize = true;
            this.lblChoixTable.Location = new System.Drawing.Point(19, 42);
            this.lblChoixTable.Name = "lblChoixTable";
            this.lblChoixTable.Size = new System.Drawing.Size(87, 20);
            this.lblChoixTable.TabIndex = 3;
            this.lblChoixTable.Text = "Votre table";
            // 
            // gpbCreationCommande
            // 
            this.gpbCreationCommande.Controls.Add(this.cmbSelectionCocktail);
            this.gpbCreationCommande.Controls.Add(this.lblChoixCocktail);
            this.gpbCreationCommande.Controls.Add(this.dgvCommande);
            this.gpbCreationCommande.Controls.Add(this.label1);
            this.gpbCreationCommande.Controls.Add(this.txbPrixTotal);
            this.gpbCreationCommande.Controls.Add(this.cmbSelectionBiere);
            this.gpbCreationCommande.Controls.Add(this.btnValiderCommande);
            this.gpbCreationCommande.Controls.Add(this.cmbSelectionTable);
            this.gpbCreationCommande.Controls.Add(this.lblChoixTable);
            this.gpbCreationCommande.Location = new System.Drawing.Point(24, 15);
            this.gpbCreationCommande.Name = "gpbCreationCommande";
            this.gpbCreationCommande.Size = new System.Drawing.Size(740, 363);
            this.gpbCreationCommande.TabIndex = 8;
            this.gpbCreationCommande.TabStop = false;
            this.gpbCreationCommande.Text = "Commander";
            // 
            // txbPrixTotal
            // 
            this.txbPrixTotal.Location = new System.Drawing.Point(559, 61);
            this.txbPrixTotal.Name = "txbPrixTotal";
            this.txbPrixTotal.Size = new System.Drawing.Size(100, 26);
            this.txbPrixTotal.TabIndex = 12;
            // 
            // cmbSelectionBiere
            // 
            this.cmbSelectionBiere.FormattingEnabled = true;
            this.cmbSelectionBiere.Location = new System.Drawing.Point(141, 121);
            this.cmbSelectionBiere.Name = "cmbSelectionBiere";
            this.cmbSelectionBiere.Size = new System.Drawing.Size(171, 28);
            this.cmbSelectionBiere.TabIndex = 11;
            // 
            // btnValiderCommande
            // 
            this.btnValiderCommande.Location = new System.Drawing.Point(97, 261);
            this.btnValiderCommande.Name = "btnValiderCommande";
            this.btnValiderCommande.Size = new System.Drawing.Size(115, 42);
            this.btnValiderCommande.TabIndex = 10;
            this.btnValiderCommande.Text = "Valider commande";
            this.btnValiderCommande.UseVisualStyleBackColor = true;
            this.btnValiderCommande.Click += new System.EventHandler(this.btnValiderCommande_Click);
            // 
            // cmbSelectionTable
            // 
            this.cmbSelectionTable.FormattingEnabled = true;
            this.cmbSelectionTable.Location = new System.Drawing.Point(141, 39);
            this.cmbSelectionTable.Name = "cmbSelectionTable";
            this.cmbSelectionTable.Size = new System.Drawing.Size(151, 28);
            this.cmbSelectionTable.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nos bières";
            // 
            // dgvCommande
            // 
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consommation,
            this.Prix});
            this.dgvCommande.Location = new System.Drawing.Point(451, 93);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.RowHeadersWidth = 62;
            this.dgvCommande.RowTemplate.Height = 28;
            this.dgvCommande.Size = new System.Drawing.Size(283, 178);
            this.dgvCommande.TabIndex = 14;
            // 
            // Consommation
            // 
            this.Consommation.HeaderText = "Consommation";
            this.Consommation.MinimumWidth = 8;
            this.Consommation.Name = "Consommation";
            this.Consommation.Width = 150;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 8;
            this.Prix.Name = "Prix";
            this.Prix.Width = 150;
            // 
            // lblChoixCocktail
            // 
            this.lblChoixCocktail.AutoSize = true;
            this.lblChoixCocktail.Location = new System.Drawing.Point(19, 193);
            this.lblChoixCocktail.Name = "lblChoixCocktail";
            this.lblChoixCocktail.Size = new System.Drawing.Size(94, 20);
            this.lblChoixCocktail.TabIndex = 15;
            this.lblChoixCocktail.Text = "Nos cocktail";
            // 
            // cmbSelectionCocktail
            // 
            this.cmbSelectionCocktail.FormattingEnabled = true;
            this.cmbSelectionCocktail.Location = new System.Drawing.Point(141, 193);
            this.cmbSelectionCocktail.Name = "cmbSelectionCocktail";
            this.cmbSelectionCocktail.Size = new System.Drawing.Size(171, 28);
            this.cmbSelectionCocktail.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbCreationCommande);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbCreationCommande.ResumeLayout(false);
            this.gpbCreationCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblChoixTable;
        private System.Windows.Forms.GroupBox gpbCreationCommande;
        private System.Windows.Forms.ComboBox cmbSelectionTable;
        private System.Windows.Forms.ComboBox cmbSelectionBiere;
        private System.Windows.Forms.Button btnValiderCommande;
        private System.Windows.Forms.TextBox txbPrixTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consommation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.ComboBox cmbSelectionCocktail;
        private System.Windows.Forms.Label lblChoixCocktail;
    }
}

