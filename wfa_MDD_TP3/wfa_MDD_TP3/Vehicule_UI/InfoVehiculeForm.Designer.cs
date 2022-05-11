
namespace wfa_MDD_TP3
{
    partial class InfoVehiculeForm
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
            this.grbInfoPermanente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbInfoNonPermanente = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.cmbModele = new System.Windows.Forms.ComboBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.cmbEtat = new System.Windows.Forms.ComboBox();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.nudKilometrage = new System.Windows.Forms.NumericUpDown();
            this.cmbCouleur = new System.Windows.Forms.ComboBox();
            this.grbInfoPermanente.SuspendLayout();
            this.grbInfoNonPermanente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometrage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoPermanente
            // 
            this.grbInfoPermanente.Controls.Add(this.txtAnnee);
            this.grbInfoPermanente.Controls.Add(this.cmbModele);
            this.grbInfoPermanente.Controls.Add(this.cmbMarque);
            this.grbInfoPermanente.Controls.Add(this.label4);
            this.grbInfoPermanente.Controls.Add(this.label3);
            this.grbInfoPermanente.Controls.Add(this.label2);
            this.grbInfoPermanente.Controls.Add(this.txtNoSerie);
            this.grbInfoPermanente.Controls.Add(this.label1);
            this.grbInfoPermanente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoPermanente.Location = new System.Drawing.Point(17, 16);
            this.grbInfoPermanente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfoPermanente.Name = "grbInfoPermanente";
            this.grbInfoPermanente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfoPermanente.Size = new System.Drawing.Size(495, 186);
            this.grbInfoPermanente.TabIndex = 0;
            this.grbInfoPermanente.TabStop = false;
            this.grbInfoPermanente.Text = "Info permanente du véhicule :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = " - Année :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " - Modèle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " - Marque :";
            // 
            // txtNoSerie
            // 
            this.txtNoSerie.Location = new System.Drawing.Point(164, 31);
            this.txtNoSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoSerie.Name = "txtNoSerie";
            this.txtNoSerie.Size = new System.Drawing.Size(301, 26);
            this.txtNoSerie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " - No de Série :";
            // 
            // grbInfoNonPermanente
            // 
            this.grbInfoNonPermanente.Controls.Add(this.cmbCouleur);
            this.grbInfoNonPermanente.Controls.Add(this.nudKilometrage);
            this.grbInfoNonPermanente.Controls.Add(this.nudPrix);
            this.grbInfoNonPermanente.Controls.Add(this.cmbEtat);
            this.grbInfoNonPermanente.Controls.Add(this.label5);
            this.grbInfoNonPermanente.Controls.Add(this.label6);
            this.grbInfoNonPermanente.Controls.Add(this.label7);
            this.grbInfoNonPermanente.Controls.Add(this.label8);
            this.grbInfoNonPermanente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoNonPermanente.Location = new System.Drawing.Point(520, 16);
            this.grbInfoNonPermanente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfoNonPermanente.Name = "grbInfoNonPermanente";
            this.grbInfoNonPermanente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfoNonPermanente.Size = new System.Drawing.Size(495, 186);
            this.grbInfoNonPermanente.TabIndex = 8;
            this.grbInfoNonPermanente.TabStop = false;
            this.grbInfoNonPermanente.Text = "Info non-permanente du véhicule :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = " - État :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = " - Kilométrage :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = " - Couleur :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = " - Prix :";
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.Location = new System.Drawing.Point(17, 209);
            this.btnConfirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(495, 76);
            this.btnConfirmation.TabIndex = 9;
            this.btnConfirmation.Text = "Confirmation";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(520, 209);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(495, 76);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cmbMarque
            // 
            this.cmbMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(164, 63);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(301, 28);
            this.cmbMarque.TabIndex = 7;
            // 
            // cmbModele
            // 
            this.cmbModele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModele.FormattingEnabled = true;
            this.cmbModele.Location = new System.Drawing.Point(164, 98);
            this.cmbModele.Name = "cmbModele";
            this.cmbModele.Size = new System.Drawing.Size(301, 28);
            this.cmbModele.TabIndex = 8;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(164, 134);
            this.txtAnnee.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(301, 26);
            this.txtAnnee.TabIndex = 9;
            // 
            // cmbEtat
            // 
            this.cmbEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtat.FormattingEnabled = true;
            this.cmbEtat.Location = new System.Drawing.Point(164, 135);
            this.cmbEtat.Name = "cmbEtat";
            this.cmbEtat.Size = new System.Drawing.Size(301, 28);
            this.cmbEtat.TabIndex = 10;
            // 
            // nudPrix
            // 
            this.nudPrix.DecimalPlaces = 2;
            this.nudPrix.Location = new System.Drawing.Point(164, 31);
            this.nudPrix.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(301, 26);
            this.nudPrix.TabIndex = 11;
            // 
            // nudKilometrage
            // 
            this.nudKilometrage.Location = new System.Drawing.Point(164, 99);
            this.nudKilometrage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilometrage.Name = "nudKilometrage";
            this.nudKilometrage.Size = new System.Drawing.Size(301, 26);
            this.nudKilometrage.TabIndex = 12;
            // 
            // cmbCouleur
            // 
            this.cmbCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCouleur.FormattingEnabled = true;
            this.cmbCouleur.Location = new System.Drawing.Point(164, 63);
            this.cmbCouleur.Name = "cmbCouleur";
            this.cmbCouleur.Size = new System.Drawing.Size(301, 28);
            this.cmbCouleur.TabIndex = 13;
            // 
            // InfoVehiculeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 305);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.grbInfoNonPermanente);
            this.Controls.Add(this.grbInfoPermanente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InfoVehiculeForm";
            this.Text = "InfoVehiculeForm";
            this.Load += new System.EventHandler(this.InfoVehiculeForm_Load);
            this.grbInfoPermanente.ResumeLayout(false);
            this.grbInfoPermanente.PerformLayout();
            this.grbInfoNonPermanente.ResumeLayout(false);
            this.grbInfoNonPermanente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometrage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoPermanente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbInfoNonPermanente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cmbModele;
        private System.Windows.Forms.ComboBox cmbMarque;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.ComboBox cmbEtat;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.NumericUpDown nudKilometrage;
        private System.Windows.Forms.ComboBox cmbCouleur;
    }
}