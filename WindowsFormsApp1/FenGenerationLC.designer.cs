namespace lot1
{
    partial class FenGenerationLC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenGenerationLC));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionModele = new System.Windows.Forms.TextBox();
            this.ParcourirModele = new System.Windows.Forms.Button();
            this.BoutonAnnuler = new System.Windows.Forms.Button();
            this.BoutonGenerer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OuvrirModele = new System.Windows.Forms.OpenFileDialog();
            this.OuvrirDestination = new System.Windows.Forms.SaveFileDialog();
            this.AffichageErreurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AffichageErreurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modèle : ";
            // 
            // SelectionModele
            // 
            this.SelectionModele.Location = new System.Drawing.Point(82, 23);
            this.SelectionModele.Name = "SelectionModele";
            this.SelectionModele.Size = new System.Drawing.Size(338, 20);
            this.SelectionModele.TabIndex = 1;
            this.SelectionModele.TextChanged += new System.EventHandler(this.SelectionModele_TextChanged);
            this.SelectionModele.Validating += new System.ComponentModel.CancelEventHandler(this.SelectionModele_Validating);
            // 
            // ParcourirModele
            // 
            this.ParcourirModele.BackColor = System.Drawing.Color.YellowGreen;
            this.ParcourirModele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ParcourirModele.BackgroundImage")));
            this.ParcourirModele.ForeColor = System.Drawing.Color.Black;
            this.ParcourirModele.Location = new System.Drawing.Point(440, 23);
            this.ParcourirModele.Name = "ParcourirModele";
            this.ParcourirModele.Size = new System.Drawing.Size(93, 20);
            this.ParcourirModele.TabIndex = 2;
            this.ParcourirModele.Text = "Parcourir";
            this.ParcourirModele.UseVisualStyleBackColor = false;
            this.ParcourirModele.Click += new System.EventHandler(this.ParcourirModele_Click);
            // 
            // BoutonAnnuler
            // 
            this.BoutonAnnuler.BackColor = System.Drawing.Color.Red;
            this.BoutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BoutonAnnuler.Location = new System.Drawing.Point(367, 150);
            this.BoutonAnnuler.Name = "BoutonAnnuler";
            this.BoutonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BoutonAnnuler.TabIndex = 3;
            this.BoutonAnnuler.Text = "Annuler";
            this.BoutonAnnuler.UseVisualStyleBackColor = false;
            // 
            // BoutonGenerer
            // 
            this.BoutonGenerer.BackColor = System.Drawing.Color.YellowGreen;
            this.BoutonGenerer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoutonGenerer.BackgroundImage")));
            this.BoutonGenerer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BoutonGenerer.Location = new System.Drawing.Point(464, 150);
            this.BoutonGenerer.Name = "BoutonGenerer";
            this.BoutonGenerer.Size = new System.Drawing.Size(75, 23);
            this.BoutonGenerer.TabIndex = 4;
            this.BoutonGenerer.Text = "OK";
            this.BoutonGenerer.UseVisualStyleBackColor = false;
            this.BoutonGenerer.Click += new System.EventHandler(this.BoutonGenerer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectionModele);
            this.groupBox2.Controls.Add(this.ParcourirModele);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 56);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sélection du modèle";
            // 
            // OuvrirModele
            // 
            this.OuvrirModele.Filter = "Documents Word|*.docx";
            this.OuvrirModele.Title = "Sélectionner un modèle";
            // 
            // OuvrirDestination
            // 
            this.OuvrirDestination.Filter = "Documents Word|*.docx";
            this.OuvrirDestination.Title = "Sélectionner une destination";
            // 
            // AffichageErreurs
            // 
            this.AffichageErreurs.ContainerControl = this;
            // 
            // FenGenerationLC
            // 
            this.AcceptButton = this.BoutonGenerer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BoutonAnnuler;
            this.ClientSize = new System.Drawing.Size(566, 192);
            this.Controls.Add(this.BoutonGenerer);
            this.Controls.Add(this.BoutonAnnuler);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FenGenerationLC";
            this.ShowIcon = false;
            this.Text = "Nouvelle lettre de coopération";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AffichageErreurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectionModele;
        private System.Windows.Forms.Button ParcourirModele;
        private System.Windows.Forms.Button BoutonAnnuler;
        private System.Windows.Forms.Button BoutonGenerer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog OuvrirModele;
        private System.Windows.Forms.SaveFileDialog OuvrirDestination;
        private System.Windows.Forms.ErrorProvider AffichageErreurs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}