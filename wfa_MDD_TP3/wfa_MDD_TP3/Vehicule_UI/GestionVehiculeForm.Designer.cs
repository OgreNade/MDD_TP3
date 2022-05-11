
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
            this.btnAjouterVehicule = new System.Windows.Forms.Button();
            this.btnModifierVehicule = new System.Windows.Forms.Button();
            this.btnSupprimerVehicule = new System.Windows.Forms.Button();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRevenirAuMenu = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouterVehicule
            // 
            this.btnAjouterVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterVehicule.Location = new System.Drawing.Point(1077, 75);
            this.btnAjouterVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterVehicule.Name = "btnAjouterVehicule";
            this.btnAjouterVehicule.Size = new System.Drawing.Size(301, 86);
            this.btnAjouterVehicule.TabIndex = 1;
            this.btnAjouterVehicule.Text = "Ajouter un Véhicule";
            this.btnAjouterVehicule.UseVisualStyleBackColor = true;
            this.btnAjouterVehicule.Click += new System.EventHandler(this.btnAjouterVehicule_Click);
            // 
            // btnModifierVehicule
            // 
            this.btnModifierVehicule.Enabled = false;
            this.btnModifierVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierVehicule.Location = new System.Drawing.Point(1077, 169);
            this.btnModifierVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierVehicule.Name = "btnModifierVehicule";
            this.btnModifierVehicule.Size = new System.Drawing.Size(301, 86);
            this.btnModifierVehicule.TabIndex = 2;
            this.btnModifierVehicule.Text = "Modifier un Véhicule";
            this.btnModifierVehicule.UseVisualStyleBackColor = true;
            this.btnModifierVehicule.Click += new System.EventHandler(this.btnModifierVehicule_Click);
            // 
            // btnSupprimerVehicule
            // 
            this.btnSupprimerVehicule.Enabled = false;
            this.btnSupprimerVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerVehicule.Location = new System.Drawing.Point(1077, 262);
            this.btnSupprimerVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerVehicule.Name = "btnSupprimerVehicule";
            this.btnSupprimerVehicule.Size = new System.Drawing.Size(301, 86);
            this.btnSupprimerVehicule.TabIndex = 3;
            this.btnSupprimerVehicule.Text = "Supprimer un Véhicule";
            this.btnSupprimerVehicule.UseVisualStyleBackColor = true;
            this.btnSupprimerVehicule.Click += new System.EventHandler(this.btnSupprimerVehicule_Click);
            // 
            // txtFiltre
            // 
            this.txtFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltre.Location = new System.Drawing.Point(316, 41);
            this.txtFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(316, 26);
            this.txtFiltre.TabIndex = 4;
            this.txtFiltre.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtre pour la liste de véhicule :";
            // 
            // btnRevenirAuMenu
            // 
            this.btnRevenirAuMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenirAuMenu.Location = new System.Drawing.Point(1077, 356);
            this.btnRevenirAuMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevenirAuMenu.Name = "btnRevenirAuMenu";
            this.btnRevenirAuMenu.Size = new System.Drawing.Size(301, 86);
            this.btnRevenirAuMenu.TabIndex = 8;
            this.btnRevenirAuMenu.Text = "Revenir au menu principal";
            this.btnRevenirAuMenu.UseVisualStyleBackColor = true;
            this.btnRevenirAuMenu.Click += new System.EventHandler(this.btnRevenirAuMenu_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(64, 75);
            this.DGV.Margin = new System.Windows.Forms.Padding(4);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(989, 367);
            this.DGV.TabIndex = 9;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // GestionVehiculeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 482);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnRevenirAuMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltre);
            this.Controls.Add(this.btnSupprimerVehicule);
            this.Controls.Add(this.btnModifierVehicule);
            this.Controls.Add(this.btnAjouterVehicule);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionVehiculeForm";
            this.Text = "GestionVehiculeForm";
            this.Load += new System.EventHandler(this.GestionVehiculeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjouterVehicule;
        private System.Windows.Forms.Button btnModifierVehicule;
        private System.Windows.Forms.Button btnSupprimerVehicule;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRevenirAuMenu;
        private System.Windows.Forms.DataGridView DGV;
    }
}