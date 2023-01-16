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
            this.txbNomEmploye = new System.Windows.Forms.TextBox();
            this.lblEmployeNom = new System.Windows.Forms.Label();
            this.lblCreaEmploye = new System.Windows.Forms.Label();
            this.lblPrenomEmploye = new System.Windows.Forms.Label();
            this.lblSalaireEmploye = new System.Windows.Forms.Label();
            this.txbPrenomEmploye = new System.Windows.Forms.TextBox();
            this.txbSalaireEmploye = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNomEmploye
            // 
            this.txbNomEmploye.Location = new System.Drawing.Point(426, 56);
            this.txbNomEmploye.Name = "txbNomEmploye";
            this.txbNomEmploye.Size = new System.Drawing.Size(167, 26);
            this.txbNomEmploye.TabIndex = 0;
            this.txbNomEmploye.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEmployeNom
            // 
            this.lblEmployeNom.AutoSize = true;
            this.lblEmployeNom.Location = new System.Drawing.Point(358, 59);
            this.lblEmployeNom.Name = "lblEmployeNom";
            this.lblEmployeNom.Size = new System.Drawing.Size(42, 20);
            this.lblEmployeNom.TabIndex = 1;
            this.lblEmployeNom.Text = "Nom";
            this.lblEmployeNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCreaEmploye
            // 
            this.lblCreaEmploye.AutoSize = true;
            this.lblCreaEmploye.Location = new System.Drawing.Point(440, 16);
            this.lblCreaEmploye.Name = "lblCreaEmploye";
            this.lblCreaEmploye.Size = new System.Drawing.Size(168, 20);
            this.lblCreaEmploye.TabIndex = 2;
            this.lblCreaEmploye.Text = "Création d\'un Employé";
            // 
            // lblPrenomEmploye
            // 
            this.lblPrenomEmploye.AutoSize = true;
            this.lblPrenomEmploye.Location = new System.Drawing.Point(336, 92);
            this.lblPrenomEmploye.Name = "lblPrenomEmploye";
            this.lblPrenomEmploye.Size = new System.Drawing.Size(64, 20);
            this.lblPrenomEmploye.TabIndex = 3;
            this.lblPrenomEmploye.Text = "Prenom";
            // 
            // lblSalaireEmploye
            // 
            this.lblSalaireEmploye.AutoSize = true;
            this.lblSalaireEmploye.Location = new System.Drawing.Point(342, 135);
            this.lblSalaireEmploye.Name = "lblSalaireEmploye";
            this.lblSalaireEmploye.Size = new System.Drawing.Size(58, 20);
            this.lblSalaireEmploye.TabIndex = 4;
            this.lblSalaireEmploye.Text = "Salaire";
            // 
            // txbPrenomEmploye
            // 
            this.txbPrenomEmploye.Location = new System.Drawing.Point(426, 89);
            this.txbPrenomEmploye.Name = "txbPrenomEmploye";
            this.txbPrenomEmploye.Size = new System.Drawing.Size(167, 26);
            this.txbPrenomEmploye.TabIndex = 5;
            // 
            // txbSalaireEmploye
            // 
            this.txbSalaireEmploye.Location = new System.Drawing.Point(426, 132);
            this.txbSalaireEmploye.Name = "txbSalaireEmploye";
            this.txbSalaireEmploye.Size = new System.Drawing.Size(167, 26);
            this.txbSalaireEmploye.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSalaireEmploye);
            this.Controls.Add(this.txbPrenomEmploye);
            this.Controls.Add(this.lblSalaireEmploye);
            this.Controls.Add(this.lblPrenomEmploye);
            this.Controls.Add(this.lblCreaEmploye);
            this.Controls.Add(this.lblEmployeNom);
            this.Controls.Add(this.txbNomEmploye);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomEmploye;
        private System.Windows.Forms.Label lblEmployeNom;
        private System.Windows.Forms.Label lblCreaEmploye;
        private System.Windows.Forms.Label lblPrenomEmploye;
        private System.Windows.Forms.Label lblSalaireEmploye;
        private System.Windows.Forms.TextBox txbPrenomEmploye;
        private System.Windows.Forms.TextBox txbSalaireEmploye;
    }
}

