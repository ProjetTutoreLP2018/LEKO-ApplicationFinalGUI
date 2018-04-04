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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textConfPass = new System.Windows.Forms.TextBox();
            this.comboDroit = new System.Windows.Forms.ComboBox();
            this.bValider = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textConfirmEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(154, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel Utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Droit : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mot de passe : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmation mot de passe : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textConfPass);
            this.groupBox2.Controls.Add(this.textPass);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(27, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mot de passe";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(123, 46);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(152, 20);
            this.textNom.TabIndex = 7;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(123, 79);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(152, 20);
            this.textPrenom.TabIndex = 8;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(123, 114);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(152, 20);
            this.textEmail.TabIndex = 9;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(160, 25);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(152, 20);
            this.textPass.TabIndex = 10;
            // 
            // textConfPass
            // 
            this.textConfPass.Location = new System.Drawing.Point(160, 56);
            this.textConfPass.Name = "textConfPass";
            this.textConfPass.Size = new System.Drawing.Size(152, 20);
            this.textConfPass.TabIndex = 11;
            // 
            // comboDroit
            // 
            this.comboDroit.FormattingEnabled = true;
            this.comboDroit.Location = new System.Drawing.Point(123, 180);
            this.comboDroit.Name = "comboDroit";
            this.comboDroit.Size = new System.Drawing.Size(152, 21);
            this.comboDroit.TabIndex = 10;
            // 
            // bValider
            // 
            this.bValider.BackColor = System.Drawing.Color.YellowGreen;
            this.bValider.Location = new System.Drawing.Point(403, 341);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 11;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = false;
            // 
            // bAnnuler
            // 
            this.bAnnuler.BackColor = System.Drawing.Color.Red;
            this.bAnnuler.Location = new System.Drawing.Point(300, 341);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 12;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Confirmation : ";
            // 
            // textConfirmEmail
            // 
            this.textConfirmEmail.Location = new System.Drawing.Point(123, 149);
            this.textConfirmEmail.Name = "textConfirmEmail";
            this.textConfirmEmail.Size = new System.Drawing.Size(152, 20);
            this.textConfirmEmail.TabIndex = 14;
            // 
            // CreerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "CreerUtilisateur";
            this.Size = new System.Drawing.Size(829, 514);
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
    }
}
