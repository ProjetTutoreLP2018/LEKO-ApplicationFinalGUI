﻿namespace LettreCooperation
{
    partial class Page_ManagerLc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_ManagerLc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSignataire = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCreateur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStatut = new System.Windows.Forms.Label();
            this.labelDateCrea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboLC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonAttSignExp = new System.Windows.Forms.RadioButton();
            this.radioButtonSignerExp = new System.Windows.Forms.RadioButton();
            this.radioButtonEnvoiCli = new System.Windows.Forms.RadioButton();
            this.radioButtonArchive = new System.Windows.Forms.RadioButton();
            this.radioButtonRefus = new System.Windows.Forms.RadioButton();
            this.groupBoxEtat = new System.Windows.Forms.GroupBox();
            this.labelNbrRefus = new System.Windows.Forms.Label();
            this.labelNbrArchive = new System.Windows.Forms.Label();
            this.labelNbrEnvoieCli = new System.Windows.Forms.Label();
            this.labelNbrSigneExp = new System.Windows.Forms.Label();
            this.labelNbrAttenteSigne = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxEtat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // comboClient
            // 
            this.comboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(234, 32);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(234, 21);
            this.comboClient.TabIndex = 1;
            this.comboClient.SelectedIndexChanged += new System.EventHandler(this.ComboClient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un client : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSignataire);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelCreateur);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelStatut);
            this.groupBox2.Controls.Add(this.labelDateCrea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboLC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(53, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lettre de coopération";
            // 
            // labelSignataire
            // 
            this.labelSignataire.AutoSize = true;
            this.labelSignataire.Location = new System.Drawing.Point(269, 149);
            this.labelSignataire.Name = "labelSignataire";
            this.labelSignataire.Size = new System.Drawing.Size(16, 13);
            this.labelSignataire.TabIndex = 9;
            this.labelSignataire.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Signataire :";
            // 
            // labelCreateur
            // 
            this.labelCreateur.AutoSize = true;
            this.labelCreateur.Location = new System.Drawing.Point(269, 124);
            this.labelCreateur.Name = "labelCreateur";
            this.labelCreateur.Size = new System.Drawing.Size(16, 13);
            this.labelCreateur.TabIndex = 7;
            this.labelCreateur.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Déchiffreuse : ";
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Location = new System.Drawing.Point(269, 99);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(16, 13);
            this.labelStatut.TabIndex = 5;
            this.labelStatut.Text = "...";
            // 
            // labelDateCrea
            // 
            this.labelDateCrea.AutoSize = true;
            this.labelDateCrea.Location = new System.Drawing.Point(269, 73);
            this.labelDateCrea.Name = "labelDateCrea";
            this.labelDateCrea.Size = new System.Drawing.Size(16, 13);
            this.labelDateCrea.TabIndex = 4;
            this.labelDateCrea.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Statut : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de création : ";
            // 
            // comboLC
            // 
            this.comboLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLC.FormattingEnabled = true;
            this.comboLC.Location = new System.Drawing.Point(42, 36);
            this.comboLC.Name = "comboLC";
            this.comboLC.Size = new System.Drawing.Size(426, 21);
            this.comboLC.TabIndex = 2;
            this.comboLC.SelectedIndexChanged += new System.EventHandler(this.ComboLC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choisir une lettre de coopération : ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(549, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAfficher_Click);
            // 
            // radioButtonAttSignExp
            // 
            this.radioButtonAttSignExp.AutoSize = true;
            this.radioButtonAttSignExp.Location = new System.Drawing.Point(16, 26);
            this.radioButtonAttSignExp.Name = "radioButtonAttSignExp";
            this.radioButtonAttSignExp.Size = new System.Drawing.Size(168, 17);
            this.radioButtonAttSignExp.TabIndex = 3;
            this.radioButtonAttSignExp.TabStop = true;
            this.radioButtonAttSignExp.Text = "En attente de signature Expert";
            this.radioButtonAttSignExp.UseVisualStyleBackColor = true;
            this.radioButtonAttSignExp.CheckedChanged += new System.EventHandler(this.RadioButtonAttSignExp_CheckedChanged);
            // 
            // radioButtonSignerExp
            // 
            this.radioButtonSignerExp.AutoSize = true;
            this.radioButtonSignerExp.Location = new System.Drawing.Point(16, 52);
            this.radioButtonSignerExp.Name = "radioButtonSignerExp";
            this.radioButtonSignerExp.Size = new System.Drawing.Size(168, 17);
            this.radioButtonSignerExp.TabIndex = 4;
            this.radioButtonSignerExp.TabStop = true;
            this.radioButtonSignerExp.Text = "Signées et validées par Expert";
            this.radioButtonSignerExp.UseVisualStyleBackColor = true;
            this.radioButtonSignerExp.CheckedChanged += new System.EventHandler(this.RadioButtonSignerExp_CheckedChanged);
            // 
            // radioButtonEnvoiCli
            // 
            this.radioButtonEnvoiCli.AutoSize = true;
            this.radioButtonEnvoiCli.Location = new System.Drawing.Point(16, 79);
            this.radioButtonEnvoiCli.Name = "radioButtonEnvoiCli";
            this.radioButtonEnvoiCli.Size = new System.Drawing.Size(115, 17);
            this.radioButtonEnvoiCli.TabIndex = 5;
            this.radioButtonEnvoiCli.TabStop = true;
            this.radioButtonEnvoiCli.Text = "Envoyées au client";
            this.radioButtonEnvoiCli.UseVisualStyleBackColor = true;
            this.radioButtonEnvoiCli.CheckedChanged += new System.EventHandler(this.RadioButtonEnvoiCli_CheckedChanged);
            // 
            // radioButtonArchive
            // 
            this.radioButtonArchive.AutoSize = true;
            this.radioButtonArchive.Location = new System.Drawing.Point(16, 106);
            this.radioButtonArchive.Name = "radioButtonArchive";
            this.radioButtonArchive.Size = new System.Drawing.Size(72, 17);
            this.radioButtonArchive.TabIndex = 6;
            this.radioButtonArchive.TabStop = true;
            this.radioButtonArchive.Text = "Archivées";
            this.radioButtonArchive.UseVisualStyleBackColor = true;
            this.radioButtonArchive.CheckedChanged += new System.EventHandler(this.RadioButtonArchive_CheckedChanged);
            // 
            // radioButtonRefus
            // 
            this.radioButtonRefus.AutoSize = true;
            this.radioButtonRefus.Location = new System.Drawing.Point(16, 134);
            this.radioButtonRefus.Name = "radioButtonRefus";
            this.radioButtonRefus.Size = new System.Drawing.Size(117, 17);
            this.radioButtonRefus.TabIndex = 7;
            this.radioButtonRefus.TabStop = true;
            this.radioButtonRefus.Text = "Refusées par Client";
            this.radioButtonRefus.UseVisualStyleBackColor = true;
            this.radioButtonRefus.CheckedChanged += new System.EventHandler(this.RadioButtonRefus_CheckedChanged);
            // 
            // groupBoxEtat
            // 
            this.groupBoxEtat.Controls.Add(this.labelNbrRefus);
            this.groupBoxEtat.Controls.Add(this.labelNbrArchive);
            this.groupBoxEtat.Controls.Add(this.labelNbrEnvoieCli);
            this.groupBoxEtat.Controls.Add(this.labelNbrSigneExp);
            this.groupBoxEtat.Controls.Add(this.labelNbrAttenteSigne);
            this.groupBoxEtat.Controls.Add(this.radioButtonRefus);
            this.groupBoxEtat.Controls.Add(this.radioButtonAttSignExp);
            this.groupBoxEtat.Controls.Add(this.radioButtonArchive);
            this.groupBoxEtat.Controls.Add(this.radioButtonSignerExp);
            this.groupBoxEtat.Controls.Add(this.radioButtonEnvoiCli);
            this.groupBoxEtat.Location = new System.Drawing.Point(546, 206);
            this.groupBoxEtat.Name = "groupBoxEtat";
            this.groupBoxEtat.Size = new System.Drawing.Size(262, 185);
            this.groupBoxEtat.TabIndex = 9;
            this.groupBoxEtat.TabStop = false;
            this.groupBoxEtat.Text = "Filtre Etats";
            // 
            // labelNbrRefus
            // 
            this.labelNbrRefus.AutoSize = true;
            this.labelNbrRefus.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelNbrRefus.Location = new System.Drawing.Point(204, 134);
            this.labelNbrRefus.Name = "labelNbrRefus";
            this.labelNbrRefus.Size = new System.Drawing.Size(0, 13);
            this.labelNbrRefus.TabIndex = 13;
            // 
            // labelNbrArchive
            // 
            this.labelNbrArchive.AutoSize = true;
            this.labelNbrArchive.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelNbrArchive.Location = new System.Drawing.Point(204, 108);
            this.labelNbrArchive.Name = "labelNbrArchive";
            this.labelNbrArchive.Size = new System.Drawing.Size(0, 13);
            this.labelNbrArchive.TabIndex = 12;
            // 
            // labelNbrEnvoieCli
            // 
            this.labelNbrEnvoieCli.AutoSize = true;
            this.labelNbrEnvoieCli.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelNbrEnvoieCli.Location = new System.Drawing.Point(204, 80);
            this.labelNbrEnvoieCli.Name = "labelNbrEnvoieCli";
            this.labelNbrEnvoieCli.Size = new System.Drawing.Size(0, 13);
            this.labelNbrEnvoieCli.TabIndex = 11;
            // 
            // labelNbrSigneExp
            // 
            this.labelNbrSigneExp.AutoSize = true;
            this.labelNbrSigneExp.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelNbrSigneExp.Location = new System.Drawing.Point(204, 54);
            this.labelNbrSigneExp.Name = "labelNbrSigneExp";
            this.labelNbrSigneExp.Size = new System.Drawing.Size(0, 13);
            this.labelNbrSigneExp.TabIndex = 10;
            // 
            // labelNbrAttenteSigne
            // 
            this.labelNbrAttenteSigne.AutoSize = true;
            this.labelNbrAttenteSigne.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelNbrAttenteSigne.Location = new System.Drawing.Point(204, 26);
            this.labelNbrAttenteSigne.Name = "labelNbrAttenteSigne";
            this.labelNbrAttenteSigne.Size = new System.Drawing.Size(0, 13);
            this.labelNbrAttenteSigne.TabIndex = 9;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Silver;
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.Location = new System.Drawing.Point(456, 397);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 9;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.ButtonSupprimer_Click);
            // 
            // Page_ManagerLc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.groupBoxEtat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Page_ManagerLc";
            this.Size = new System.Drawing.Size(859, 514);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxEtat.ResumeLayout(false);
            this.groupBoxEtat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboLC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.Label labelDateCrea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCreateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonAttSignExp;
        private System.Windows.Forms.RadioButton radioButtonSignerExp;
        private System.Windows.Forms.RadioButton radioButtonEnvoiCli;
        private System.Windows.Forms.RadioButton radioButtonArchive;
        private System.Windows.Forms.RadioButton radioButtonRefus;
        private System.Windows.Forms.GroupBox groupBoxEtat;
        private System.Windows.Forms.Label labelSignataire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelNbrRefus;
        private System.Windows.Forms.Label labelNbrArchive;
        private System.Windows.Forms.Label labelNbrEnvoieCli;
        private System.Windows.Forms.Label labelNbrSigneExp;
        private System.Windows.Forms.Label labelNbrAttenteSigne;
    }
}
