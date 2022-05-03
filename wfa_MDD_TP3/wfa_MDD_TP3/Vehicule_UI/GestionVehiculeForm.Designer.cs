
namespace wfa_MDD_TP3
{
    partial class GestionVehiculeForm
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
            this.lstAffichageVehicule = new System.Windows.Forms.ListBox();
            this.btnAjouterVehicule = new System.Windows.Forms.Button();
            this.btnModifierVehicule = new System.Windows.Forms.Button();
            this.btnSupprimerVehicule = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRevenirAuMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAffichageVehicule
            // 
            this.lstAffichageVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAffichageVehicule.FormattingEnabled = true;
            this.lstAffichageVehicule.ItemHeight = 20;
            this.lstAffichageVehicule.Location = new System.Drawing.Point(48, 61);
            this.lstAffichageVehicule.Name = "lstAffichageVehicule";
            this.lstAffichageVehicule.Size = new System.Drawing.Size(427, 304);
            this.lstAffichageVehicule.TabIndex = 0;
            // 
            // btnAjouterVehicule
            // 
            this.btnAjouterVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterVehicule.Location = new System.Drawing.Point(523, 61);
            this.btnAjouterVehicule.Name = "btnAjouterVehicule";
            this.btnAjouterVehicule.Size = new System.Drawing.Size(226, 70);
            this.btnAjouterVehicule.TabIndex = 1;
            this.btnAjouterVehicule.Text = "Ajouter un Véhicule";
            this.btnAjouterVehicule.UseVisualStyleBackColor = true;
            this.btnAjouterVehicule.Click += new System.EventHandler(this.btnAjouterVehicule_Click);
            // 
            // btnModifierVehicule
            // 
            this.btnModifierVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierVehicule.Location = new System.Drawing.Point(523, 137);
            this.btnModifierVehicule.Name = "btnModifierVehicule";
            this.btnModifierVehicule.Size = new System.Drawing.Size(226, 70);
            this.btnModifierVehicule.TabIndex = 2;
            this.btnModifierVehicule.Text = "Modifier un Véhicule";
            this.btnModifierVehicule.UseVisualStyleBackColor = true;
            this.btnModifierVehicule.Click += new System.EventHandler(this.btnModifierVehicule_Click);
            // 
            // btnSupprimerVehicule
            // 
            this.btnSupprimerVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerVehicule.Location = new System.Drawing.Point(523, 213);
            this.btnSupprimerVehicule.Name = "btnSupprimerVehicule";
            this.btnSupprimerVehicule.Size = new System.Drawing.Size(226, 70);
            this.btnSupprimerVehicule.TabIndex = 3;
            this.btnSupprimerVehicule.Text = "Supprimer un Véhicule";
            this.btnSupprimerVehicule.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtre pour la liste de véhicule :";
            // 
            // btnRevenirAuMenu
            // 
            this.btnRevenirAuMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenirAuMenu.Location = new System.Drawing.Point(523, 289);
            this.btnRevenirAuMenu.Name = "btnRevenirAuMenu";
            this.btnRevenirAuMenu.Size = new System.Drawing.Size(226, 70);
            this.btnRevenirAuMenu.TabIndex = 8;
            this.btnRevenirAuMenu.Text = "Revenir au menu principal";
            this.btnRevenirAuMenu.UseVisualStyleBackColor = true;
            this.btnRevenirAuMenu.Click += new System.EventHandler(this.btnRevenirAuMenu_Click);
            // 
            // GestionVehiculeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.btnRevenirAuMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSupprimerVehicule);
            this.Controls.Add(this.btnModifierVehicule);
            this.Controls.Add(this.btnAjouterVehicule);
            this.Controls.Add(this.lstAffichageVehicule);
            this.Name = "GestionVehiculeForm";
            this.Text = "GestionVehiculeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAffichageVehicule;
        private System.Windows.Forms.Button btnAjouterVehicule;
        private System.Windows.Forms.Button btnModifierVehicule;
        private System.Windows.Forms.Button btnSupprimerVehicule;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRevenirAuMenu;
    }
}