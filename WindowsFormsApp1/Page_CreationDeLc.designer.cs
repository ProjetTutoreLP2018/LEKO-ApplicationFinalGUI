namespace LettreCooperation
{
	partial class Page_CreationDeLc
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_CreationDeLc));
            this.BoutonParcourirFichierValoHonoraires = new System.Windows.Forms.Button();
            this.FichierValoHonoraires = new System.Windows.Forms.TextBox();
            this.ListeDeroulanteChoixClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ouvrirFichierValoHonoraires = new System.Windows.Forms.OpenFileDialog();
            this.sauvegarderFichier = new System.Windows.Forms.SaveFileDialog();
            this.ouvrirFichierModele = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeExercice_fin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeExercice_debut = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMission = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonGenerer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoutonParcourirFichierValoHonoraires
            // 
            this.BoutonParcourirFichierValoHonoraires.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoutonParcourirFichierValoHonoraires.BackgroundImage")));
            this.BoutonParcourirFichierValoHonoraires.Location = new System.Drawing.Point(526, 68);
            this.BoutonParcourirFichierValoHonoraires.Name = "BoutonParcourirFichierValoHonoraires";
            this.BoutonParcourirFichierValoHonoraires.Size = new System.Drawing.Size(86, 23);
            this.BoutonParcourirFichierValoHonoraires.TabIndex = 2;
            this.BoutonParcourirFichierValoHonoraires.Text = "Parcourir";
            this.BoutonParcourirFichierValoHonoraires.UseVisualStyleBackColor = true;
            this.BoutonParcourirFichierValoHonoraires.Click += new System.EventHandler(this.BoutonParcourirFichierValoHonoraires_Click);
            // 
            // FichierValoHonoraires
            // 
            this.FichierValoHonoraires.Enabled = false;
            this.FichierValoHonoraires.Location = new System.Drawing.Point(239, 70);
            this.FichierValoHonoraires.Name = "FichierValoHonoraires";
            this.FichierValoHonoraires.Size = new System.Drawing.Size(264, 20);
            this.FichierValoHonoraires.TabIndex = 3;
            // 
            // ListeDeroulanteChoixClient
            // 
            this.ListeDeroulanteChoixClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListeDeroulanteChoixClient.FormattingEnabled = true;
            this.ListeDeroulanteChoixClient.Location = new System.Drawing.Point(239, 21);
            this.ListeDeroulanteChoixClient.Name = "ListeDeroulanteChoixClient";
            this.ListeDeroulanteChoixClient.Size = new System.Drawing.Size(373, 21);
            this.ListeDeroulanteChoixClient.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choix du modèle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fichier de valorisation d\'honoraires : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Client : ";
            // 
            // ouvrirFichierValoHonoraires
            // 
            this.ouvrirFichierValoHonoraires.Filter = "Document Excel (*.xlsx)|*.xlsx";
            // 
            // sauvegarderFichier
            // 
            this.sauvegarderFichier.Filter = "Document Word (*.docx)|*.docx";
            // 
            // ouvrirFichierModele
            // 
            this.ouvrirFichierModele.Filter = "Documents Word (*.docx)|*.docx";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeExercice_fin);
            this.groupBox1.Controls.Add(this.dateTimeExercice_debut);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxMission);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListeDeroulanteChoixClient);
            this.groupBox1.Controls.Add(this.FichierValoHonoraires);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BoutonParcourirFichierValoHonoraires);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(93, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 291);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // dateTimeExercice_fin
            // 
            this.dateTimeExercice_fin.Location = new System.Drawing.Point(239, 247);
            this.dateTimeExercice_fin.Name = "dateTimeExercice_fin";
            this.dateTimeExercice_fin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeExercice_fin.TabIndex = 61;
            // 
            // dateTimeExercice_debut
            // 
            this.dateTimeExercice_debut.Location = new System.Drawing.Point(239, 221);
            this.dateTimeExercice_debut.Name = "dateTimeExercice_debut";
            this.dateTimeExercice_debut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeExercice_debut.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Exercice Social : ";
            // 
            // textBoxMission
            // 
            this.textBoxMission.Location = new System.Drawing.Point(239, 175);
            this.textBoxMission.Name = "textBoxMission";
            this.textBoxMission.Size = new System.Drawing.Size(373, 20);
            this.textBoxMission.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mission : ";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(239, 121);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(373, 21);
            this.comboBoxModel.TabIndex = 4;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // buttonGenerer
            // 
            this.buttonGenerer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGenerer.BackgroundImage")));
            this.buttonGenerer.Location = new System.Drawing.Point(679, 382);
            this.buttonGenerer.Name = "buttonGenerer";
            this.buttonGenerer.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerer.TabIndex = 6;
            this.buttonGenerer.Text = "Générer";
            this.buttonGenerer.UseVisualStyleBackColor = true;
            this.buttonGenerer.Click += new System.EventHandler(this.BoutonGenerer_Click);
            // 
            // Page_CreationDeLc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonGenerer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Page_CreationDeLc";
            this.Size = new System.Drawing.Size(859, 514);
            this.Load += new System.EventHandler(this.FenGenerationLC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button BoutonParcourirFichierValoHonoraires;
		private System.Windows.Forms.TextBox FichierValoHonoraires;
		private System.Windows.Forms.ComboBox ListeDeroulanteChoixClient;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog ouvrirFichierValoHonoraires;
		private System.Windows.Forms.SaveFileDialog sauvegarderFichier;
		private System.Windows.Forms.OpenFileDialog ouvrirFichierModele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGenerer;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMission;
        private System.Windows.Forms.DateTimePicker dateTimeExercice_fin;
        private System.Windows.Forms.DateTimePicker dateTimeExercice_debut;
        private System.Windows.Forms.Label label15;
    }
}
