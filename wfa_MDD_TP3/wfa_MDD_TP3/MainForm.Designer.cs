
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
            this.btn_GestionClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionVehicule
            // 
            this.btnGestionVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVehicule.Location = new System.Drawing.Point(604, 162);
            this.btnGestionVehicule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionVehicule.Name = "btnGestionVehicule";
            this.btnGestionVehicule.Size = new System.Drawing.Size(181, 124);
            this.btnGestionVehicule.TabIndex = 0;
            this.btnGestionVehicule.Text = "Gestion Véhicule";
            this.btnGestionVehicule.UseVisualStyleBackColor = true;
            this.btnGestionVehicule.Click += new System.EventHandler(this.btnGestionVehicule_Click);
            // 
            // btn_GestionClient
            // 
            this.btn_GestionClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionClient.Location = new System.Drawing.Point(323, 162);
            this.btn_GestionClient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GestionClient.Name = "btn_GestionClient";
            this.btn_GestionClient.Size = new System.Drawing.Size(181, 124);
            this.btn_GestionClient.TabIndex = 1;
            this.btn_GestionClient.Text = "Gestion Client";
            this.btn_GestionClient.UseVisualStyleBackColor = true;
            this.btn_GestionClient.Click += new System.EventHandler(this.btn_GestionClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_GestionClient);
            this.Controls.Add(this.btnGestionVehicule);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionVehicule;
        private System.Windows.Forms.Button btn_GestionClient;
    }
}

