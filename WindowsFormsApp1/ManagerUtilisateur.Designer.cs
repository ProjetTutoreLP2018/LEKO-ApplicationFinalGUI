namespace LettreCooperation
{
    partial class ManagerUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerUtilisateur));
            this.labelNomUtilisateur = new System.Windows.Forms.Label();
            this.comboNomUtilisateur = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textPassConfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDroit = new System.Windows.Forms.ComboBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adresseMailMess = new System.Windows.Forms.Label();
            this.mdpConfMess = new System.Windows.Forms.Label();
            this.messageErr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomUtilisateur
            // 
            this.labelNomUtilisateur.AutoSize = true;
            this.labelNomUtilisateur.Location = new System.Drawing.Point(32, 40);
            this.labelNomUtilisateur.Name = "labelNomUtilisateur";
            this.labelNomUtilisateur.Size = new System.Drawing.Size(89, 13);
            this.labelNomUtilisateur.TabIndex = 0;
            this.labelNomUtilisateur.Text = "Choisir l\'utilisateur";
            // 
            // comboNomUtilisateur
            // 
            this.comboNomUtilisateur.FormattingEnabled = true;
            this.comboNomUtilisateur.Location = new System.Drawing.Point(146, 37);
            this.comboNomUtilisateur.Name = "comboNomUtilisateur";
            this.comboNomUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.comboNomUtilisateur.TabIndex = 1;
            this.comboNomUtilisateur.SelectedIndexChanged += new System.EventHandler(this.ComboNomUtilisateur_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboNomUtilisateur);
            this.groupBox1.Controls.Add(this.labelNomUtilisateur);
            this.groupBox1.Location = new System.Drawing.Point(56, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix Utilisateur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageErr);
            this.groupBox2.Controls.Add(this.adresseMailMess);
            this.groupBox2.Controls.Add(this.checkBoxAdmin);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboDroit);
            this.groupBox2.Controls.Add(this.textEmail);
            this.groupBox2.Controls.Add(this.textPrenom);
            this.groupBox2.Controls.Add(this.textNom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(56, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 261);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détail utilisateur";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdmin.Location = new System.Drawing.Point(395, 156);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(106, 17);
            this.checkBoxAdmin.TabIndex = 15;
            this.checkBoxAdmin.Text = "Administrateur";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(598, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(481, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonModifier_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mdpConfMess);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textPass);
            this.groupBox3.Controls.Add(this.textPassConfirm);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(395, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 114);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mot de passe : ";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(120, 26);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 20);
            this.textPass.TabIndex = 9;
            // 
            // textPassConfirm
            // 
            this.textPassConfirm.Location = new System.Drawing.Point(120, 67);
            this.textPassConfirm.Name = "textPassConfirm";
            this.textPassConfirm.Size = new System.Drawing.Size(100, 20);
            this.textPassConfirm.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmation : ";
            // 
            // comboDroit
            // 
            this.comboDroit.FormattingEnabled = true;
            this.comboDroit.Location = new System.Drawing.Point(115, 134);
            this.comboDroit.Name = "comboDroit";
            this.comboDroit.Size = new System.Drawing.Size(121, 21);
            this.comboDroit.TabIndex = 11;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(115, 101);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(206, 20);
            this.textEmail.TabIndex = 8;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(115, 67);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(100, 20);
            this.textPrenom.TabIndex = 7;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(115, 36);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Droit : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // adresseMailMess
            // 
            this.adresseMailMess.AutoSize = true;
            this.adresseMailMess.ForeColor = System.Drawing.Color.Red;
            this.adresseMailMess.Location = new System.Drawing.Point(234, 82);
            this.adresseMailMess.Name = "adresseMailMess";
            this.adresseMailMess.Size = new System.Drawing.Size(0, 13);
            this.adresseMailMess.TabIndex = 16;
            // 
            // mdpConfMess
            // 
            this.mdpConfMess.AutoSize = true;
            this.mdpConfMess.ForeColor = System.Drawing.Color.Red;
            this.mdpConfMess.Location = new System.Drawing.Point(120, 95);
            this.mdpConfMess.Name = "mdpConfMess";
            this.mdpConfMess.Size = new System.Drawing.Size(0, 13);
            this.mdpConfMess.TabIndex = 11;
            // 
            // messageErr
            // 
            this.messageErr.AutoSize = true;
            this.messageErr.ForeColor = System.Drawing.Color.Red;
            this.messageErr.Location = new System.Drawing.Point(285, 228);
            this.messageErr.Name = "messageErr";
            this.messageErr.Size = new System.Drawing.Size(0, 13);
            this.messageErr.TabIndex = 17;
            // 
            // ManagerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManagerUtilisateur";
            this.Size = new System.Drawing.Size(829, 514);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNomUtilisateur;
        private System.Windows.Forms.ComboBox comboNomUtilisateur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textPassConfirm;
        private System.Windows.Forms.ComboBox comboDroit;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label adresseMailMess;
        private System.Windows.Forms.Label mdpConfMess;
        private System.Windows.Forms.Label messageErr;
    }
}
