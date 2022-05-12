
namespace wfa_MDD_TP3.Client_Logic
{
    partial class AjouterClientForm
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.grpInfoClient = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreerPar = new System.Windows.Forms.TextBox();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.txtDateCreationDossier = new System.Windows.Forms.TextBox();
            this.lblNumPermit = new System.Windows.Forms.Label();
            this.txtNoPermitConduire = new System.Windows.Forms.TextBox();
            this.cmbStatue = new System.Windows.Forms.ComboBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.dtpDateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtCellulaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblCellulaire = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grpInfoClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(541, 286);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(107, 29);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(654, 286);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(107, 29);
            this.btnSauvegarder.TabIndex = 4;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // grpInfoClient
            // 
            this.grpInfoClient.Controls.Add(this.label1);
            this.grpInfoClient.Controls.Add(this.txtCreerPar);
            this.grpInfoClient.Controls.Add(this.lblDateCreation);
            this.grpInfoClient.Controls.Add(this.txtDateCreationDossier);
            this.grpInfoClient.Controls.Add(this.lblNumPermit);
            this.grpInfoClient.Controls.Add(this.txtNoPermitConduire);
            this.grpInfoClient.Controls.Add(this.cmbStatue);
            this.grpInfoClient.Controls.Add(this.cmbGenre);
            this.grpInfoClient.Controls.Add(this.dtpDateDeNaissance);
            this.grpInfoClient.Controls.Add(this.txtTelephone);
            this.grpInfoClient.Controls.Add(this.txtCourriel);
            this.grpInfoClient.Controls.Add(this.txtPrenom);
            this.grpInfoClient.Controls.Add(this.txtCellulaire);
            this.grpInfoClient.Controls.Add(this.label8);
            this.grpInfoClient.Controls.Add(this.lblDateDeNaissance);
            this.grpInfoClient.Controls.Add(this.lblTelephone);
            this.grpInfoClient.Controls.Add(this.lblCourriel);
            this.grpInfoClient.Controls.Add(this.lblPrenom);
            this.grpInfoClient.Controls.Add(this.lblGenre);
            this.grpInfoClient.Controls.Add(this.lblCellulaire);
            this.grpInfoClient.Controls.Add(this.lblNom);
            this.grpInfoClient.Controls.Add(this.txtNom);
            this.grpInfoClient.Location = new System.Drawing.Point(12, 12);
            this.grpInfoClient.Name = "grpInfoClient";
            this.grpInfoClient.Size = new System.Drawing.Size(749, 268);
            this.grpInfoClient.TabIndex = 3;
            this.grpInfoClient.TabStop = false;
            this.grpInfoClient.Text = "Info Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Créer par :";
            // 
            // txtCreerPar
            // 
            this.txtCreerPar.Location = new System.Drawing.Point(490, 232);
            this.txtCreerPar.Name = "txtCreerPar";
            this.txtCreerPar.ReadOnly = true;
            this.txtCreerPar.Size = new System.Drawing.Size(209, 22);
            this.txtCreerPar.TabIndex = 21;
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.Location = new System.Drawing.Point(6, 232);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(171, 17);
            this.lblDateCreation.TabIndex = 20;
            this.lblDateCreation.Text = "Date création du dossier :";
            // 
            // txtDateCreationDossier
            // 
            this.txtDateCreationDossier.Location = new System.Drawing.Point(177, 229);
            this.txtDateCreationDossier.Name = "txtDateCreationDossier";
            this.txtDateCreationDossier.ReadOnly = true;
            this.txtDateCreationDossier.Size = new System.Drawing.Size(209, 22);
            this.txtDateCreationDossier.TabIndex = 19;
            // 
            // lblNumPermit
            // 
            this.lblNumPermit.AutoSize = true;
            this.lblNumPermit.Location = new System.Drawing.Point(121, 19);
            this.lblNumPermit.Name = "lblNumPermit";
            this.lblNumPermit.Size = new System.Drawing.Size(188, 17);
            this.lblNumPermit.TabIndex = 18;
            this.lblNumPermit.Text = "Numéro permit de conduire :";
            // 
            // txtNoPermitConduire
            // 
            this.txtNoPermitConduire.Location = new System.Drawing.Point(324, 16);
            this.txtNoPermitConduire.Name = "txtNoPermitConduire";
            this.txtNoPermitConduire.Size = new System.Drawing.Size(301, 22);
            this.txtNoPermitConduire.TabIndex = 17;
            // 
            // cmbStatue
            // 
            this.cmbStatue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatue.FormattingEnabled = true;
            this.cmbStatue.Location = new System.Drawing.Point(490, 196);
            this.cmbStatue.Name = "cmbStatue";
            this.cmbStatue.Size = new System.Drawing.Size(163, 24);
            this.cmbStatue.TabIndex = 16;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(490, 100);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(135, 24);
            this.cmbGenre.TabIndex = 15;
            // 
            // dtpDateDeNaissance
            // 
            this.dtpDateDeNaissance.Location = new System.Drawing.Point(177, 107);
            this.dtpDateDeNaissance.Name = "dtpDateDeNaissance";
            this.dtpDateDeNaissance.Size = new System.Drawing.Size(167, 22);
            this.dtpDateDeNaissance.TabIndex = 14;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(177, 152);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(192, 22);
            this.txtTelephone.TabIndex = 13;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(177, 198);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(192, 22);
            this.txtCourriel.TabIndex = 12;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(490, 62);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(221, 22);
            this.txtPrenom.TabIndex = 11;
            // 
            // txtCellulaire
            // 
            this.txtCellulaire.Location = new System.Drawing.Point(490, 151);
            this.txtCellulaire.Name = "txtCellulaire";
            this.txtCellulaire.Size = new System.Drawing.Size(185, 22);
            this.txtCellulaire.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Statue :";
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(35, 107);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(136, 17);
            this.lblDateDeNaissance.TabIndex = 7;
            this.lblDateDeNaissance.Text = "Date de Naissance :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(86, 155);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 17);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(105, 200);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(65, 17);
            this.lblCourriel.TabIndex = 5;
            this.lblCourriel.Text = "Courriel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(419, 65);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(428, 107);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(56, 17);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre :";
            // 
            // lblCellulaire
            // 
            this.lblCellulaire.AutoSize = true;
            this.lblCellulaire.Location = new System.Drawing.Point(418, 151);
            this.lblCellulaire.Name = "lblCellulaire";
            this.lblCellulaire.Size = new System.Drawing.Size(74, 17);
            this.lblCellulaire.TabIndex = 2;
            this.lblCellulaire.Text = "Cellulaire :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(126, 67);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(177, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(209, 22);
            this.txtNom.TabIndex = 0;
            // 
            // AjouterClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.grpInfoClient);
            this.Name = "AjouterClientForm";
            this.Text = "AjouterClientForm";
            this.Load += new System.EventHandler(this.AjouterClientForm_Load);
            this.grpInfoClient.ResumeLayout(false);
            this.grpInfoClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.GroupBox grpInfoClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreerPar;
        private System.Windows.Forms.Label lblDateCreation;
        private System.Windows.Forms.TextBox txtDateCreationDossier;
        private System.Windows.Forms.Label lblNumPermit;
        private System.Windows.Forms.TextBox txtNoPermitConduire;
        private System.Windows.Forms.ComboBox cmbStatue;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DateTimePicker dtpDateDeNaissance;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCellulaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblCellulaire;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
    }
}