namespace LettreCooperation
{
    partial class AjoutModele
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutModele));
            this.Ajouter = new System.Windows.Forms.Button();
            this.Selectionner = new System.Windows.Forms.Button();
            this.adresseFichier = new System.Windows.Forms.TextBox();
            this.labelNomFichier = new System.Windows.Forms.Label();
            this.labelNomMission = new System.Windows.Forms.Label();
            this.labelTypeLettre = new System.Windows.Forms.Label();
            this.textBoxNomFichier = new System.Windows.Forms.TextBox();
            this.textBoxNomMision = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ajouter
            // 
            this.Ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ajouter.BackgroundImage")));
            this.Ajouter.Location = new System.Drawing.Point(549, 213);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(81, 23);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Selectionner
            // 
            this.Selectionner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Selectionner.BackgroundImage")));
            this.Selectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectionner.Location = new System.Drawing.Point(448, 13);
            this.Selectionner.Margin = new System.Windows.Forms.Padding(2);
            this.Selectionner.Name = "Selectionner";
            this.Selectionner.Size = new System.Drawing.Size(24, 26);
            this.Selectionner.TabIndex = 2;
            this.Selectionner.Text = "...";
            this.Selectionner.UseVisualStyleBackColor = true;
            this.Selectionner.Click += new System.EventHandler(this.Selectionner_Click);
            // 
            // adresseFichier
            // 
            this.adresseFichier.Location = new System.Drawing.Point(122, 18);
            this.adresseFichier.Margin = new System.Windows.Forms.Padding(2);
            this.adresseFichier.Name = "adresseFichier";
            this.adresseFichier.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.adresseFichier.Size = new System.Drawing.Size(308, 20);
            this.adresseFichier.TabIndex = 3;
            // 
            // labelNomFichier
            // 
            this.labelNomFichier.AutoSize = true;
            this.labelNomFichier.Location = new System.Drawing.Point(20, 58);
            this.labelNomFichier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomFichier.Name = "labelNomFichier";
            this.labelNomFichier.Size = new System.Drawing.Size(66, 13);
            this.labelNomFichier.TabIndex = 4;
            this.labelNomFichier.Text = "Nom fichier :";
            // 
            // labelNomMission
            // 
            this.labelNomMission.AutoSize = true;
            this.labelNomMission.Location = new System.Drawing.Point(20, 98);
            this.labelNomMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomMission.Name = "labelNomMission";
            this.labelNomMission.Size = new System.Drawing.Size(72, 13);
            this.labelNomMission.TabIndex = 5;
            this.labelNomMission.Text = "Nom mission :";
            // 
            // labelTypeLettre
            // 
            this.labelTypeLettre.AutoSize = true;
            this.labelTypeLettre.Location = new System.Drawing.Point(20, 143);
            this.labelTypeLettre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypeLettre.Name = "labelTypeLettre";
            this.labelTypeLettre.Size = new System.Drawing.Size(63, 13);
            this.labelTypeLettre.TabIndex = 6;
            this.labelTypeLettre.Text = "Type lettre :";
            // 
            // textBoxNomFichier
            // 
            this.textBoxNomFichier.Location = new System.Drawing.Point(122, 55);
            this.textBoxNomFichier.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomFichier.Name = "textBoxNomFichier";
            this.textBoxNomFichier.Size = new System.Drawing.Size(308, 20);
            this.textBoxNomFichier.TabIndex = 7;
            // 
            // textBoxNomMision
            // 
            this.textBoxNomMision.Location = new System.Drawing.Point(122, 95);
            this.textBoxNomMision.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomMision.Name = "textBoxNomMision";
            this.textBoxNomMision.Size = new System.Drawing.Size(308, 20);
            this.textBoxNomMision.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Coopération",
            "Mission"});
            this.comboBox1.Location = new System.Drawing.Point(122, 138);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Selectionner);
            this.groupBox1.Controls.Add(this.labelTypeLettre);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelNomMission);
            this.groupBox1.Controls.Add(this.adresseFichier);
            this.groupBox1.Controls.Add(this.labelNomFichier);
            this.groupBox1.Controls.Add(this.textBoxNomMision);
            this.groupBox1.Controls.Add(this.textBoxNomFichier);
            this.groupBox1.Location = new System.Drawing.Point(37, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 187);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chemin fichier :";
            // 
            // AjoutModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ajouter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AjoutModele";
            this.Text = "Ajout d\'un modèle de Lettre de Coopération";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Selectionner;
        private System.Windows.Forms.TextBox adresseFichier;
        private System.Windows.Forms.Label labelNomFichier;
        private System.Windows.Forms.Label labelNomMission;
        private System.Windows.Forms.Label labelTypeLettre;
        private System.Windows.Forms.TextBox textBoxNomFichier;
        private System.Windows.Forms.TextBox textBoxNomMision;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

