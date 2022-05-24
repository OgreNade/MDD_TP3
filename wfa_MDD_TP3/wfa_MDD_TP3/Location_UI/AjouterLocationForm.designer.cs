
namespace wfa_MDD_TP3.Location_UI
{
    partial class AjouterLocationForm
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
            this.grb_client = new System.Windows.Forms.GroupBox();
            this.btnChercheClient = new System.Windows.Forms.Button();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChercheVoiture = new System.Windows.Forms.Button();
            this.txt_annee = new System.Windows.Forms.TextBox();
            this.lbl_annee = new System.Windows.Forms.Label();
            this.txt_modele = new System.Windows.Forms.TextBox();
            this.lbl_modele = new System.Windows.Forms.Label();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.lbl_marque = new System.Windows.Forms.Label();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.lbl_retour = new System.Windows.Forms.Label();
            this.lbl_emprunt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_creerReservation = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAnnulerLocation = new System.Windows.Forms.Button();
            this.DGVClient = new System.Windows.Forms.DataGridView();
            this.DGVVoiture = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grb_client.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_client
            // 
            this.grb_client.Controls.Add(this.btnChercheClient);
            this.grb_client.Controls.Add(this.txt_prenom);
            this.grb_client.Controls.Add(this.txt_nom);
            this.grb_client.Controls.Add(this.txt_id);
            this.grb_client.Controls.Add(this.lbl_prenom);
            this.grb_client.Controls.Add(this.lbl_nom);
            this.grb_client.Controls.Add(this.lbl_id);
            this.grb_client.Location = new System.Drawing.Point(11, 154);
            this.grb_client.Margin = new System.Windows.Forms.Padding(2);
            this.grb_client.Name = "grb_client";
            this.grb_client.Padding = new System.Windows.Forms.Padding(2);
            this.grb_client.Size = new System.Drawing.Size(224, 146);
            this.grb_client.TabIndex = 0;
            this.grb_client.TabStop = false;
            this.grb_client.Text = "Information client";
            // 
            // btnChercheClient
            // 
            this.btnChercheClient.Location = new System.Drawing.Point(85, 118);
            this.btnChercheClient.Name = "btnChercheClient";
            this.btnChercheClient.Size = new System.Drawing.Size(134, 23);
            this.btnChercheClient.TabIndex = 6;
            this.btnChercheClient.Text = "Rechercher le client";
            this.btnChercheClient.UseVisualStyleBackColor = true;
            this.btnChercheClient.Click += new System.EventHandler(this.btnChercheClient_Click);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(85, 93);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(134, 20);
            this.txt_prenom.TabIndex = 5;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(85, 60);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(134, 20);
            this.txt_nom.TabIndex = 4;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(85, 24);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 20);
            this.txt_id.TabIndex = 3;
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(4, 96);
            this.lbl_prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 2;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(4, 60);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(75, 13);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nom complet :";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(4, 24);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChercheVoiture);
            this.groupBox1.Controls.Add(this.txt_annee);
            this.groupBox1.Controls.Add(this.lbl_annee);
            this.groupBox1.Controls.Add(this.txt_modele);
            this.groupBox1.Controls.Add(this.lbl_modele);
            this.groupBox1.Controls.Add(this.txt_marque);
            this.groupBox1.Controls.Add(this.lbl_marque);
            this.groupBox1.Controls.Add(this.txt_serie);
            this.groupBox1.Controls.Add(this.lbl_serie);
            this.groupBox1.Location = new System.Drawing.Point(11, 340);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(224, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information véhicule";
            // 
            // btnChercheVoiture
            // 
            this.btnChercheVoiture.Location = new System.Drawing.Point(19, 132);
            this.btnChercheVoiture.Name = "btnChercheVoiture";
            this.btnChercheVoiture.Size = new System.Drawing.Size(200, 23);
            this.btnChercheVoiture.TabIndex = 7;
            this.btnChercheVoiture.Text = "Sélectionner le véhicule sélectionné";
            this.btnChercheVoiture.UseVisualStyleBackColor = true;
            this.btnChercheVoiture.Click += new System.EventHandler(this.btnChercheVoiture_Click);
            // 
            // txt_annee
            // 
            this.txt_annee.Location = new System.Drawing.Point(108, 106);
            this.txt_annee.Name = "txt_annee";
            this.txt_annee.Size = new System.Drawing.Size(111, 20);
            this.txt_annee.TabIndex = 15;
            // 
            // lbl_annee
            // 
            this.lbl_annee.AutoSize = true;
            this.lbl_annee.Location = new System.Drawing.Point(16, 110);
            this.lbl_annee.Name = "lbl_annee";
            this.lbl_annee.Size = new System.Drawing.Size(44, 13);
            this.lbl_annee.TabIndex = 14;
            this.lbl_annee.Text = "Année :";
            // 
            // txt_modele
            // 
            this.txt_modele.Location = new System.Drawing.Point(108, 78);
            this.txt_modele.Name = "txt_modele";
            this.txt_modele.Size = new System.Drawing.Size(111, 20);
            this.txt_modele.TabIndex = 13;
            // 
            // lbl_modele
            // 
            this.lbl_modele.AutoSize = true;
            this.lbl_modele.Location = new System.Drawing.Point(16, 81);
            this.lbl_modele.Name = "lbl_modele";
            this.lbl_modele.Size = new System.Drawing.Size(48, 13);
            this.lbl_modele.TabIndex = 12;
            this.lbl_modele.Text = "Modèle :";
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(108, 50);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(111, 20);
            this.txt_marque.TabIndex = 11;
            // 
            // lbl_marque
            // 
            this.lbl_marque.AutoSize = true;
            this.lbl_marque.Location = new System.Drawing.Point(16, 54);
            this.lbl_marque.Name = "lbl_marque";
            this.lbl_marque.Size = new System.Drawing.Size(49, 13);
            this.lbl_marque.TabIndex = 10;
            this.lbl_marque.Text = "Marque :";
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(108, 22);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(111, 20);
            this.txt_serie.TabIndex = 9;
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.Location = new System.Drawing.Point(16, 25);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(69, 13);
            this.lbl_serie.TabIndex = 8;
            this.lbl_serie.Text = "No de Série :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDateEnd);
            this.groupBox2.Controls.Add(this.dtpDateStart);
            this.groupBox2.Controls.Add(this.lbl_retour);
            this.groupBox2.Controls.Add(this.lbl_emprunt);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(224, 102);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durée location";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(94, 67);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(126, 20);
            this.dtpDateEnd.TabIndex = 3;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(94, 27);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(126, 20);
            this.dtpDateStart.TabIndex = 2;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // lbl_retour
            // 
            this.lbl_retour.AutoSize = true;
            this.lbl_retour.Location = new System.Drawing.Point(5, 67);
            this.lbl_retour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_retour.Name = "lbl_retour";
            this.lbl_retour.Size = new System.Drawing.Size(81, 13);
            this.lbl_retour.TabIndex = 1;
            this.lbl_retour.Text = "Date de retour :";
            // 
            // lbl_emprunt
            // 
            this.lbl_emprunt.AutoSize = true;
            this.lbl_emprunt.Location = new System.Drawing.Point(5, 27);
            this.lbl_emprunt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_emprunt.Name = "lbl_emprunt";
            this.lbl_emprunt.Size = new System.Drawing.Size(85, 13);
            this.lbl_emprunt.TabIndex = 0;
            this.lbl_emprunt.Text = "Date d\'emprunt :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.txt_km);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(11, 526);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(224, 93);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Facturation";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(85, 57);
            this.txt_km.Margin = new System.Windows.Forms.Padding(2);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(134, 20);
            this.txt_km.TabIndex = 11;
            this.txt_km.TextChanged += new System.EventHandler(this.txt_km_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montant payer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Methode de paiment";
            // 
            // btn_creerReservation
            // 
            this.btn_creerReservation.Location = new System.Drawing.Point(4, 27);
            this.btn_creerReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_creerReservation.Name = "btn_creerReservation";
            this.btn_creerReservation.Size = new System.Drawing.Size(732, 48);
            this.btn_creerReservation.TabIndex = 4;
            this.btn_creerReservation.Text = "Créer la réservation";
            this.btn_creerReservation.UseVisualStyleBackColor = true;
            this.btn_creerReservation.Click += new System.EventHandler(this.btn_creerReservation_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAnnulerLocation);
            this.groupBox4.Controls.Add(this.btn_creerReservation);
            this.groupBox4.Location = new System.Drawing.Point(264, 480);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(740, 168);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // btnAnnulerLocation
            // 
            this.btnAnnulerLocation.Location = new System.Drawing.Point(4, 91);
            this.btnAnnulerLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulerLocation.Name = "btnAnnulerLocation";
            this.btnAnnulerLocation.Size = new System.Drawing.Size(732, 48);
            this.btnAnnulerLocation.TabIndex = 5;
            this.btnAnnulerLocation.Text = "Annuler la réservation";
            this.btnAnnulerLocation.UseVisualStyleBackColor = true;
            this.btnAnnulerLocation.Click += new System.EventHandler(this.btnAnnulerLocation_Click);
            // 
            // DGVClient
            // 
            this.DGVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClient.Location = new System.Drawing.Point(264, 27);
            this.DGVClient.Name = "DGVClient";
            this.DGVClient.Size = new System.Drawing.Size(740, 214);
            this.DGVClient.TabIndex = 7;
            this.DGVClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClient_CellContentClick);
            // 
            // DGVVoiture
            // 
            this.DGVVoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVoiture.Location = new System.Drawing.Point(264, 260);
            this.DGVVoiture.Name = "DGVVoiture";
            this.DGVVoiture.Size = new System.Drawing.Size(740, 215);
            this.DGVVoiture.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Information sur le client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Information sur la voiture";
            // 
            // AjouterLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 683);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGVVoiture);
            this.Controls.Add(this.DGVClient);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_client);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AjouterLocationForm";
            this.Text = "LocationInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjouterLocationForm_FormClosing);
            this.Load += new System.EventHandler(this.LocationInterface_Load);
            this.grb_client.ResumeLayout(false);
            this.grb_client.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_client;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_annee;
        private System.Windows.Forms.Label lbl_annee;
        private System.Windows.Forms.TextBox txt_modele;
        private System.Windows.Forms.Label lbl_modele;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.Label lbl_marque;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label lbl_retour;
        private System.Windows.Forms.Label lbl_emprunt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_creerReservation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAnnulerLocation;
        private System.Windows.Forms.Button btnChercheClient;
        private System.Windows.Forms.Button btnChercheVoiture;
        private System.Windows.Forms.DataGridView DGVClient;
        private System.Windows.Forms.DataGridView DGVVoiture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}