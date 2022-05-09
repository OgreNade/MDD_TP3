
namespace wfa_MDD_TP3
{
    partial class MainForm
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
            this.btnGestionVehicule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionVehicule
            // 
            this.btnGestionVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVehicule.Location = new System.Drawing.Point(453, 132);
            this.btnGestionVehicule.Name = "btnGestionVehicule";
            this.btnGestionVehicule.Size = new System.Drawing.Size(136, 101);
            this.btnGestionVehicule.TabIndex = 0;
            this.btnGestionVehicule.Text = "Gestion Véhicule";
            this.btnGestionVehicule.UseVisualStyleBackColor = true;
            this.btnGestionVehicule.Click += new System.EventHandler(this.btnGestionVehicule_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionVehicule);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionVehicule;
    }
}

