namespace WindowsFormsApp1
{
    partial class CreerUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreerUtilisateur));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adresseMailConfMess = new System.Windows.Forms.Label();
            this.adresseMailMess = new System.Windows.Forms.Label();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.textConfirmEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bValider = new System.Windows.Forms.Button();
            this.comboDroit = new System.Windows.Forms.ComboBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textConfPass = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mdpConfMess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adresseMailConfMess);
            this.groupBox1.Controls.Add(this.adresseMailMess);
            this.groupBox1.Controls.Add(this.checkBoxAdmin);
            this.groupBox1.Controls.Add(this.textConfirmEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bAnnuler);
            this.groupBox1.Controls.Add(this.bValider);
            this.groupBox1.Controls.Add(this.comboDroit);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textPrenom);
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(205, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(708, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel Utilisateur";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // adresseMailConfMess
            // 
            this.adresseMailConfMess.AutoSize = true;
            this.adresseMailConfMess.Location = new System.Drawing.Point(418, 183);
            this.adresseMailConfMess.Name = "adresseMailConfMess";
            this.adresseMailConfMess.Size = new System.Drawing.Size(0, 17);
            this.adresseMailConfMess.TabIndex = 18;
            this.adresseMailConfMess.ForeColor = System.Drawing.Color.Red;
            // 
            // adresseMailMess
            // 
            this.adresseMailMess.AutoSize = true;
            this.adresseMailMess.Location = new System.Drawing.Point(464, 144);
            this.adresseMailMess.Name = "adresseMailMess";
            this.adresseMailMess.Size = new System.Drawing.Size(0, 17);
            this.adresseMailMess.TabIndex = 17;
            this.adresseMailMess.ForeColor = System.Drawing.Color.Red;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdmin.Location = new System.Drawing.Point(441, 226);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(135, 21);
            this.checkBoxAdmin.TabIndex = 16;
            this.checkBoxAdmin.Text = "Administrateur";
            this.checkBoxAdmin.UseVisualStyleBackColor = false;
            // 
            // textConfirmEmail
            // 
            this.textConfirmEmail.Location = new System.Drawing.Point(164, 183);
            this.textConfirmEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textConfirmEmail.Name = "textConfirmEmail";
            this.textConfirmEmail.Size = new System.Drawing.Size(201, 22);
            this.textConfirmEmail.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Confirmation : ";
            // 
            // bAnnuler
            // 
            this.bAnnuler.BackColor = System.Drawing.Color.Red;
            this.bAnnuler.Location = new System.Drawing.Point(400, 420);
            this.bAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(100, 28);
            this.bAnnuler.TabIndex = 12;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = false;
            // 
            // bValider
            // 
            this.bValider.BackColor = System.Drawing.Color.YellowGreen;
            this.bValider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bValider.BackgroundImage")));
            this.bValider.Location = new System.Drawing.Point(537, 420);
            this.bValider.Margin = new System.Windows.Forms.Padding(4);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(100, 28);
            this.bValider.TabIndex = 11;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = false;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // comboDroit
            // 
            this.comboDroit.FormattingEnabled = true;
            this.comboDroit.Location = new System.Drawing.Point(164, 222);
            this.comboDroit.Margin = new System.Windows.Forms.Padding(4);
            this.comboDroit.Name = "comboDroit";
            this.comboDroit.Size = new System.Drawing.Size(201, 24);
            this.comboDroit.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(164, 140);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(201, 22);
            this.textEmail.TabIndex = 9;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(164, 97);
            this.textPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(201, 22);
            this.textPrenom.TabIndex = 8;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(164, 57);
            this.textNom.Margin = new System.Windows.Forms.Padding(4);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(201, 22);
            this.textNom.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mdpConfMess);
            this.groupBox2.Controls.Add(this.textConfPass);
            this.groupBox2.Controls.Add(this.textPass);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(36, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(601, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mot de passe";
            // 
            // textConfPass
            // 
            this.textConfPass.Location = new System.Drawing.Point(213, 69);
            this.textConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.textConfPass.Name = "textConfPass";
            this.textConfPass.Size = new System.Drawing.Size(201, 22);
            this.textConfPass.TabIndex = 11;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(213, 31);
            this.textPass.Margin = new System.Windows.Forms.Padding(4);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(201, 22);
            this.textPass.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mot de passe : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmation mot de passe : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Droit : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse Email : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // mdpConfMess
            // 
            this.mdpConfMess.AutoSize = true;
            this.mdpConfMess.Location = new System.Drawing.Point(449, 69);
            this.mdpConfMess.Name = "mdpConfMess";
            this.mdpConfMess.Size = new System.Drawing.Size(0, 17);
            this.mdpConfMess.TabIndex = 12;
            this.mdpConfMess.ForeColor = System.Drawing.Color.Red;
            // 
            // CreerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreerUtilisateur";
            this.Size = new System.Drawing.Size(1105, 633);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textConfPass;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.ComboBox comboDroit;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.TextBox textConfirmEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label adresseMailMess;
        private System.Windows.Forms.Label adresseMailConfMess;
        private System.Windows.Forms.Label mdpConfMess;
    }
}
