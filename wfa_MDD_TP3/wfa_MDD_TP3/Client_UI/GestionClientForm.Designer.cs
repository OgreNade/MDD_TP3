
namespace wfa_MDD_TP3.Client_Logic
{
    partial class GestionClientsFrm
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
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvResultat = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.cmbRecherchePar = new System.Windows.Forms.ComboBox();
            this.lblRecherchePar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(1091, 143);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(119, 27);
            this.btnRafraichir.TabIndex = 19;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(18, 144);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(112, 29);
            this.lblResultat.TabIndex = 18;
            this.lblResultat.Text = "Resultat :";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(1091, 468);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(119, 27);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dgvResultat
            // 
            this.dgvResultat.AllowDrop = true;
            this.dgvResultat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultat.Location = new System.Drawing.Point(12, 176);
            this.dgvResultat.Name = "dgvResultat";
            this.dgvResultat.ReadOnly = true;
            this.dgvResultat.RowHeadersWidth = 51;
            this.dgvResultat.RowTemplate.Height = 24;
            this.dgvResultat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultat.Size = new System.Drawing.Size(1198, 286);
            this.dgvResultat.TabIndex = 16;
            this.dgvResultat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultat_CellDoubleClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(524, 89);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(119, 35);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(1016, 19);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(119, 28);
            this.btnRechercher.TabIndex = 14;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(453, 18);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(542, 29);
            this.txtRecherche.TabIndex = 13;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // cmbRecherchePar
            // 
            this.cmbRecherchePar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecherchePar.FormattingEnabled = true;
            this.cmbRecherchePar.Location = new System.Drawing.Point(228, 21);
            this.cmbRecherchePar.Name = "cmbRecherchePar";
            this.cmbRecherchePar.Size = new System.Drawing.Size(192, 24);
            this.cmbRecherchePar.TabIndex = 12;
            // 
            // lblRecherchePar
            // 
            this.lblRecherchePar.AutoSize = true;
            this.lblRecherchePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherchePar.Location = new System.Drawing.Point(39, 17);
            this.lblRecherchePar.Name = "lblRecherchePar";
            this.lblRecherchePar.Size = new System.Drawing.Size(183, 29);
            this.lblRecherchePar.TabIndex = 11;
            this.lblRecherchePar.Text = "Recherche par :";
            // 
            // GestionClientsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 516);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dgvResultat);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.cmbRecherchePar);
            this.Controls.Add(this.lblRecherchePar);
            this.Name = "GestionClientsFrm";
            this.Text = "GestionClientForm";
            this.Load += new System.EventHandler(this.GestionClientsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView dgvResultat;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.ComboBox cmbRecherchePar;
        private System.Windows.Forms.Label lblRecherchePar;
    }
}