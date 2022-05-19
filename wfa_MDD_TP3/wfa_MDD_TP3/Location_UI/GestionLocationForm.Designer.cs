
namespace wfa_MDD_TP3.Location_UI
{
    partial class GestionLocationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechercheLocation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAfficherTouteLocation = new System.Windows.Forms.Button();
            this.btnAjouterLocation = new System.Windows.Forms.Button();
            this.btnModifierLocation = new System.Windows.Forms.Button();
            this.btnSupprimerLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche de location";
            // 
            // btnRechercheLocation
            // 
            this.btnRechercheLocation.Location = new System.Drawing.Point(243, 25);
            this.btnRechercheLocation.Name = "btnRechercheLocation";
            this.btnRechercheLocation.Size = new System.Drawing.Size(133, 20);
            this.btnRechercheLocation.TabIndex = 2;
            this.btnRechercheLocation.Text = "Rechercher location";
            this.btnRechercheLocation.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 298);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAfficherTouteLocation
            // 
            this.btnAfficherTouteLocation.Location = new System.Drawing.Point(382, 51);
            this.btnAfficherTouteLocation.Name = "btnAfficherTouteLocation";
            this.btnAfficherTouteLocation.Size = new System.Drawing.Size(366, 70);
            this.btnAfficherTouteLocation.TabIndex = 4;
            this.btnAfficherTouteLocation.Text = "Afficher toute les locations";
            this.btnAfficherTouteLocation.UseVisualStyleBackColor = true;
            // 
            // btnAjouterLocation
            // 
            this.btnAjouterLocation.Location = new System.Drawing.Point(382, 127);
            this.btnAjouterLocation.Name = "btnAjouterLocation";
            this.btnAjouterLocation.Size = new System.Drawing.Size(366, 70);
            this.btnAjouterLocation.TabIndex = 5;
            this.btnAjouterLocation.Text = "Ajouter une location";
            this.btnAjouterLocation.UseVisualStyleBackColor = true;
            // 
            // btnModifierLocation
            // 
            this.btnModifierLocation.Location = new System.Drawing.Point(382, 203);
            this.btnModifierLocation.Name = "btnModifierLocation";
            this.btnModifierLocation.Size = new System.Drawing.Size(366, 70);
            this.btnModifierLocation.TabIndex = 6;
            this.btnModifierLocation.Text = "Modifier la location sélectionnée";
            this.btnModifierLocation.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerLocation
            // 
            this.btnSupprimerLocation.Location = new System.Drawing.Point(382, 279);
            this.btnSupprimerLocation.Name = "btnSupprimerLocation";
            this.btnSupprimerLocation.Size = new System.Drawing.Size(366, 70);
            this.btnSupprimerLocation.TabIndex = 7;
            this.btnSupprimerLocation.Text = "Supprimer la location sélectionnée";
            this.btnSupprimerLocation.UseVisualStyleBackColor = true;
            // 
            // GestionLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 367);
            this.Controls.Add(this.btnSupprimerLocation);
            this.Controls.Add(this.btnModifierLocation);
            this.Controls.Add(this.btnAjouterLocation);
            this.Controls.Add(this.btnAfficherTouteLocation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRechercheLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "GestionLocationForm";
            this.Text = "GestionLocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRechercheLocation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAfficherTouteLocation;
        private System.Windows.Forms.Button btnAjouterLocation;
        private System.Windows.Forms.Button btnModifierLocation;
        private System.Windows.Forms.Button btnSupprimerLocation;
    }
}