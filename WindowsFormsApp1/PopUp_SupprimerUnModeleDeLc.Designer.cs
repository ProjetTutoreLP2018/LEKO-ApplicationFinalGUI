namespace LettreCooperation
{
    partial class PopUp_SupprimerUnModeleDeLc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp_SupprimerUnModeleDeLc));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modeleLc = new System.Windows.Forms.Label();
            this.supprimerModele = new System.Windows.Forms.Button();
            this.labelNomMission = new System.Windows.Forms.Label();
            this.labelTypeLettre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTypeLettre = new System.Windows.Forms.Label();
            this.textNomMission = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // modeleLc
            // 
            this.modeleLc.AutoSize = true;
            this.modeleLc.Location = new System.Drawing.Point(36, 33);
            this.modeleLc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeleLc.Name = "modeleLc";
            this.modeleLc.Size = new System.Drawing.Size(73, 13);
            this.modeleLc.TabIndex = 1;
            this.modeleLc.Text = "Modèle de LC";
            // 
            // supprimerModele
            // 
            this.supprimerModele.BackColor = System.Drawing.Color.Red;
            this.supprimerModele.Location = new System.Drawing.Point(511, 211);
            this.supprimerModele.Margin = new System.Windows.Forms.Padding(2);
            this.supprimerModele.Name = "supprimerModele";
            this.supprimerModele.Size = new System.Drawing.Size(77, 25);
            this.supprimerModele.TabIndex = 2;
            this.supprimerModele.Text = "Supprimer";
            this.supprimerModele.UseVisualStyleBackColor = false;
            this.supprimerModele.Click += new System.EventHandler(this.SupprimerModel_Click);
            // 
            // labelNomMission
            // 
            this.labelNomMission.AutoSize = true;
            this.labelNomMission.Location = new System.Drawing.Point(36, 89);
            this.labelNomMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomMission.Name = "labelNomMission";
            this.labelNomMission.Size = new System.Drawing.Size(66, 13);
            this.labelNomMission.TabIndex = 5;
            this.labelNomMission.Text = "Nom mission";
            // 
            // labelTypeLettre
            // 
            this.labelTypeLettre.AutoSize = true;
            this.labelTypeLettre.Location = new System.Drawing.Point(36, 140);
            this.labelTypeLettre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypeLettre.Name = "labelTypeLettre";
            this.labelTypeLettre.Size = new System.Drawing.Size(57, 13);
            this.labelTypeLettre.TabIndex = 6;
            this.labelTypeLettre.Text = "Type lettre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTypeLettre);
            this.groupBox1.Controls.Add(this.textNomMission);
            this.groupBox1.Controls.Add(this.modeleLc);
            this.groupBox1.Controls.Add(this.labelTypeLettre);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelNomMission);
            this.groupBox1.Location = new System.Drawing.Point(77, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textTypeLettre
            // 
            this.textTypeLettre.AutoSize = true;
            this.textTypeLettre.Location = new System.Drawing.Point(125, 140);
            this.textTypeLettre.Name = "textTypeLettre";
            this.textTypeLettre.Size = new System.Drawing.Size(0, 13);
            this.textTypeLettre.TabIndex = 8;
            // 
            // textNomMission
            // 
            this.textNomMission.AutoSize = true;
            this.textNomMission.Location = new System.Drawing.Point(125, 88);
            this.textNomMission.Name = "textNomMission";
            this.textNomMission.Size = new System.Drawing.Size(0, 13);
            this.textNomMission.TabIndex = 7;
            // 
            // PopUp_SupprimerUnModeleDeLc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.supprimerModele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopUp_SupprimerUnModeleDeLc";
            this.Text = "Supprimer un modèle de LC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label modeleLc;
        private System.Windows.Forms.Button supprimerModele;
        private System.Windows.Forms.Label labelNomMission;
        private System.Windows.Forms.Label labelTypeLettre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label textNomMission;
        private System.Windows.Forms.Label textTypeLettre;
    }
}

