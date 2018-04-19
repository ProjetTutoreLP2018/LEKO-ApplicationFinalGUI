namespace Lot2_PartieLC
{
	partial class FenGenerationLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenGenerationLC));
            this.BoutonParcourirFichierValoHonoraires = new System.Windows.Forms.Button();
            this.FichierValoHonoraires = new System.Windows.Forms.TextBox();
            this.ListeDeroulanteChoixClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BoutonGenerer = new System.Windows.Forms.ToolStripButton();
            this.ouvrirFichierValoHonoraires = new System.Windows.Forms.OpenFileDialog();
            this.sauvegarderFichier = new System.Windows.Forms.SaveFileDialog();
            this.ouvrirFichierModele = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGenerer = new System.Windows.Forms.Button();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoutonParcourirFichierValoHonoraires
            // 
            this.BoutonParcourirFichierValoHonoraires.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoutonParcourirFichierValoHonoraires.BackgroundImage")));
            this.BoutonParcourirFichierValoHonoraires.Location = new System.Drawing.Point(526, 116);
            this.BoutonParcourirFichierValoHonoraires.Name = "BoutonParcourirFichierValoHonoraires";
            this.BoutonParcourirFichierValoHonoraires.Size = new System.Drawing.Size(86, 23);
            this.BoutonParcourirFichierValoHonoraires.TabIndex = 22;
            this.BoutonParcourirFichierValoHonoraires.Text = "Parcourir";
            this.BoutonParcourirFichierValoHonoraires.UseVisualStyleBackColor = true;
            this.BoutonParcourirFichierValoHonoraires.Click += new System.EventHandler(this.BoutonParcourirFichierValoHonoraires_Click);
            // 
            // FichierValoHonoraires
            // 
            this.FichierValoHonoraires.Location = new System.Drawing.Point(286, 118);
            this.FichierValoHonoraires.Name = "FichierValoHonoraires";
            this.FichierValoHonoraires.Size = new System.Drawing.Size(217, 20);
            this.FichierValoHonoraires.TabIndex = 20;
            // 
            // ListeDeroulanteChoixClient
            // 
            this.ListeDeroulanteChoixClient.FormattingEnabled = true;
            this.ListeDeroulanteChoixClient.Location = new System.Drawing.Point(286, 30);
            this.ListeDeroulanteChoixClient.Name = "ListeDeroulanteChoixClient";
            this.ListeDeroulanteChoixClient.Size = new System.Drawing.Size(217, 21);
            this.ListeDeroulanteChoixClient.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choix du modèle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fichier de valorisation d\'honoraires : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Client : ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoutonGenerer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BoutonGenerer
            // 
            this.BoutonGenerer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutonGenerer.Name = "BoutonGenerer";
            this.BoutonGenerer.Size = new System.Drawing.Size(52, 22);
            this.BoutonGenerer.Text = "Générer";
            this.BoutonGenerer.ToolTipText = "Générer la lettre de coopération";
            this.BoutonGenerer.Click += new System.EventHandler(this.BoutonGenerer_Click);
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
            this.groupBox1.Controls.Add(this.comboBoxModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListeDeroulanteChoixClient);
            this.groupBox1.Controls.Add(this.FichierValoHonoraires);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BoutonParcourirFichierValoHonoraires);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(76, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 232);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // buttonGenerer
            // 
            this.buttonGenerer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGenerer.BackgroundImage")));
            this.buttonGenerer.Location = new System.Drawing.Point(661, 328);
            this.buttonGenerer.Name = "buttonGenerer";
            this.buttonGenerer.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerer.TabIndex = 28;
            this.buttonGenerer.Text = "Générer";
            this.buttonGenerer.UseVisualStyleBackColor = true;
            this.buttonGenerer.Click += new System.EventHandler(this.BoutonGenerer_Click);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(286, 172);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(217, 21);
            this.comboBoxModel.TabIndex = 23;
            // 
            // FenGenerationLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonGenerer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FenGenerationLC";
            this.Size = new System.Drawing.Size(829, 461);
            this.Load += new System.EventHandler(this.FenGenerationLC_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BoutonParcourirFichierValoHonoraires;
		private System.Windows.Forms.TextBox FichierValoHonoraires;
		private System.Windows.Forms.ComboBox ListeDeroulanteChoixClient;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton BoutonGenerer;
		private System.Windows.Forms.OpenFileDialog ouvrirFichierValoHonoraires;
		private System.Windows.Forms.SaveFileDialog sauvegarderFichier;
		private System.Windows.Forms.OpenFileDialog ouvrirFichierModele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGenerer;
        private System.Windows.Forms.ComboBox comboBoxModel;
    }
}
