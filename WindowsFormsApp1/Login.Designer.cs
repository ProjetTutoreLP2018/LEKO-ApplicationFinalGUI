namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.labelErrorConnect = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUtilisateur = new System.Windows.Forms.TextBox();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConnexion
            // 
            this.panelConnexion.BackColor = System.Drawing.Color.White;
            this.panelConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelConnexion.Controls.Add(this.labelErrorConnect);
            this.panelConnexion.Controls.Add(this.buttonConnexion);
            this.panelConnexion.Controls.Add(this.textBoxPass);
            this.panelConnexion.Controls.Add(this.labelPass);
            this.panelConnexion.Controls.Add(this.textBoxUtilisateur);
            this.panelConnexion.Controls.Add(this.labelUtilisateur);
            this.panelConnexion.Controls.Add(this.pictureLogo);
            this.panelConnexion.Location = new System.Drawing.Point(0, 0);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(829, 514);
            this.panelConnexion.TabIndex = 2;
            // 
            // labelErrorConnect
            // 
            this.labelErrorConnect.AutoSize = true;
            this.labelErrorConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelErrorConnect.ForeColor = System.Drawing.Color.Red;
            this.labelErrorConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelErrorConnect.Location = new System.Drawing.Point(281, 246);
            this.labelErrorConnect.Name = "labelErrorConnect";
            this.labelErrorConnect.Size = new System.Drawing.Size(0, 17);
            this.labelErrorConnect.TabIndex = 6;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonConnexion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonConnexion.Location = new System.Drawing.Point(362, 400);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = false;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(305, 348);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(188, 20);
            this.textBoxPass.TabIndex = 4;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPass.Location = new System.Drawing.Point(302, 332);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(71, 13);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Mot de passe";
            // 
            // textBoxUtilisateur
            // 
            this.textBoxUtilisateur.Location = new System.Drawing.Point(305, 291);
            this.textBoxUtilisateur.Name = "textBoxUtilisateur";
            this.textBoxUtilisateur.Size = new System.Drawing.Size(188, 20);
            this.textBoxUtilisateur.TabIndex = 2;
            // 
            // labelUtilisateur
            // 
            this.labelUtilisateur.AutoSize = true;
            this.labelUtilisateur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUtilisateur.Location = new System.Drawing.Point(302, 275);
            this.labelUtilisateur.Name = "labelUtilisateur";
            this.labelUtilisateur.Size = new System.Drawing.Size(86, 13);
            this.labelUtilisateur.TabIndex = 1;
            this.labelUtilisateur.Text = "Utilisateur (email)";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.BackgroundImage")));
            this.pictureLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(256, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(282, 238);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelConnexion);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(829, 514);
            this.panelConnexion.ResumeLayout(false);
            this.panelConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.Label labelErrorConnect;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUtilisateur;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}
