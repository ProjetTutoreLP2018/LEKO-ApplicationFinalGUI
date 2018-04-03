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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionModele = new System.Windows.Forms.TextBox();
            this.ParcourirModele = new System.Windows.Forms.Button();
            this.BoutonAnnuler = new System.Windows.Forms.Button();
            this.BoutonGenerer = new System.Windows.Forms.Button();
            this.ParcourirDestination = new System.Windows.Forms.Button();
            this.SelectionDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OuvrirModele = new System.Windows.Forms.OpenFileDialog();
            this.OuvrirDestination = new System.Windows.Forms.SaveFileDialog();
            this.AffichageErreurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
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
            this.ParcourirModele.Location = new System.Drawing.Point(440, 23);
            this.ParcourirModele.Name = "ParcourirModele";
            this.ParcourirModele.Size = new System.Drawing.Size(93, 20);
            this.ParcourirModele.TabIndex = 2;
            this.ParcourirModele.Text = "Parcourir";
            this.ParcourirModele.UseVisualStyleBackColor = true;
            this.ParcourirModele.Click += new System.EventHandler(this.ParcourirModele_Click);
            // 
            // BoutonAnnuler
            // 
            this.BoutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BoutonAnnuler.Location = new System.Drawing.Point(369, 181);
            this.BoutonAnnuler.Name = "BoutonAnnuler";
            this.BoutonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BoutonAnnuler.TabIndex = 3;
            this.BoutonAnnuler.Text = "Annuler";
            this.BoutonAnnuler.UseVisualStyleBackColor = true;
            // 
            // BoutonGenerer
            // 
            this.BoutonGenerer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BoutonGenerer.Location = new System.Drawing.Point(464, 181);
            this.BoutonGenerer.Name = "BoutonGenerer";
            this.BoutonGenerer.Size = new System.Drawing.Size(75, 23);
            this.BoutonGenerer.TabIndex = 4;
            this.BoutonGenerer.Text = "OK";
            this.BoutonGenerer.UseVisualStyleBackColor = true;
            this.BoutonGenerer.Click += new System.EventHandler(this.BoutonGenerer_Click);
            // 
            // ParcourirDestination
            // 
            this.ParcourirDestination.Location = new System.Drawing.Point(440, 23);
            this.ParcourirDestination.Name = "ParcourirDestination";
            this.ParcourirDestination.Size = new System.Drawing.Size(93, 20);
            this.ParcourirDestination.TabIndex = 7;
            this.ParcourirDestination.Text = "Parcourir";
            this.ParcourirDestination.UseVisualStyleBackColor = true;
            this.ParcourirDestination.Click += new System.EventHandler(this.ParcourirDestination_Click);
            // 
            // SelectionDestination
            // 
            this.SelectionDestination.Location = new System.Drawing.Point(88, 114);
            this.SelectionDestination.Name = "SelectionDestination";
            this.SelectionDestination.Size = new System.Drawing.Size(338, 20);
            this.SelectionDestination.TabIndex = 6;
            this.SelectionDestination.TextChanged += new System.EventHandler(this.SelectionDestination_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParcourirDestination);
            this.groupBox1.Location = new System.Drawing.Point(6, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sélection de la destination";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectionModele);
            this.groupBox2.Controls.Add(this.ParcourirModele);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
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
            this.CancelButton = this.BoutonAnnuler;
            this.ClientSize = new System.Drawing.Size(566, 218);
            this.Controls.Add(this.SelectionDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoutonGenerer);
            this.Controls.Add(this.BoutonAnnuler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FenGenerationLC";
            this.ShowIcon = false;
            this.Text = "Nouvelle lettre de coopération";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AffichageErreurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectionModele;
        private System.Windows.Forms.Button ParcourirModele;
        private System.Windows.Forms.Button BoutonAnnuler;
        private System.Windows.Forms.Button BoutonGenerer;
        private System.Windows.Forms.Button ParcourirDestination;
        private System.Windows.Forms.TextBox SelectionDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog OuvrirModele;
        private System.Windows.Forms.SaveFileDialog OuvrirDestination;
        private System.Windows.Forms.ErrorProvider AffichageErreurs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}