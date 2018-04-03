namespace WindowsFormsApp1
{
    partial class pagePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagePrincipale));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.gestionDesLettreDeCoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirModifierUneLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signerUneLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerUneLCAuClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirModifierUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirModifierUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.textBoxUtilisateur = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.labelErrorConnect = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.YellowGreen;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesLettreDeCoToolStripMenuItem,
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesUtilisateursToolStripMenuItem,
            this.aProposToolStripMenuItem});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // gestionDesLettreDeCoToolStripMenuItem
            // 
            this.gestionDesLettreDeCoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUneLCToolStripMenuItem,
            this.voirModifierUneLCToolStripMenuItem,
            this.signerUneLCToolStripMenuItem,
            this.envoyerUneLCAuClientToolStripMenuItem});
            this.gestionDesLettreDeCoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gestionDesLettreDeCoToolStripMenuItem.Name = "gestionDesLettreDeCoToolStripMenuItem";
            resources.ApplyResources(this.gestionDesLettreDeCoToolStripMenuItem, "gestionDesLettreDeCoToolStripMenuItem");
            // 
            // créerUneLCToolStripMenuItem
            // 
            this.créerUneLCToolStripMenuItem.Name = "créerUneLCToolStripMenuItem";
            resources.ApplyResources(this.créerUneLCToolStripMenuItem, "créerUneLCToolStripMenuItem");
            this.créerUneLCToolStripMenuItem.Click += new System.EventHandler(this.créerUneLCToolStripMenuItem_Click);
            // 
            // voirModifierUneLCToolStripMenuItem
            // 
            this.voirModifierUneLCToolStripMenuItem.Name = "voirModifierUneLCToolStripMenuItem";
            resources.ApplyResources(this.voirModifierUneLCToolStripMenuItem, "voirModifierUneLCToolStripMenuItem");
            this.voirModifierUneLCToolStripMenuItem.Click += new System.EventHandler(this.voirModifierUneLCToolStripMenuItem_Click);
            // 
            // signerUneLCToolStripMenuItem
            // 
            this.signerUneLCToolStripMenuItem.Name = "signerUneLCToolStripMenuItem";
            resources.ApplyResources(this.signerUneLCToolStripMenuItem, "signerUneLCToolStripMenuItem");
            this.signerUneLCToolStripMenuItem.Click += new System.EventHandler(this.signerUneLCToolStripMenuItem_Click);
            // 
            // envoyerUneLCAuClientToolStripMenuItem
            // 
            this.envoyerUneLCAuClientToolStripMenuItem.Name = "envoyerUneLCAuClientToolStripMenuItem";
            resources.ApplyResources(this.envoyerUneLCAuClientToolStripMenuItem, "envoyerUneLCAuClientToolStripMenuItem");
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnClientToolStripMenuItem,
            this.voirModifierUnClientToolStripMenuItem});
            this.gestionDesClientsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            resources.ApplyResources(this.gestionDesClientsToolStripMenuItem, "gestionDesClientsToolStripMenuItem");
            // 
            // créerUnClientToolStripMenuItem
            // 
            this.créerUnClientToolStripMenuItem.Name = "créerUnClientToolStripMenuItem";
            resources.ApplyResources(this.créerUnClientToolStripMenuItem, "créerUnClientToolStripMenuItem");
            // 
            // voirModifierUnClientToolStripMenuItem
            // 
            this.voirModifierUnClientToolStripMenuItem.Name = "voirModifierUnClientToolStripMenuItem";
            resources.ApplyResources(this.voirModifierUnClientToolStripMenuItem, "voirModifierUnClientToolStripMenuItem");
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnUtilisateurToolStripMenuItem,
            this.voirModifierUnUtilisateurToolStripMenuItem,
            this.supprimerUnUtilisateurToolStripMenuItem});
            this.gestionDesUtilisateursToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            resources.ApplyResources(this.gestionDesUtilisateursToolStripMenuItem, "gestionDesUtilisateursToolStripMenuItem");
            // 
            // créerUnUtilisateurToolStripMenuItem
            // 
            this.créerUnUtilisateurToolStripMenuItem.Name = "créerUnUtilisateurToolStripMenuItem";
            resources.ApplyResources(this.créerUnUtilisateurToolStripMenuItem, "créerUnUtilisateurToolStripMenuItem");
            // 
            // voirModifierUnUtilisateurToolStripMenuItem
            // 
            this.voirModifierUnUtilisateurToolStripMenuItem.Name = "voirModifierUnUtilisateurToolStripMenuItem";
            resources.ApplyResources(this.voirModifierUnUtilisateurToolStripMenuItem, "voirModifierUnUtilisateurToolStripMenuItem");
            // 
            // supprimerUnUtilisateurToolStripMenuItem
            // 
            this.supprimerUnUtilisateurToolStripMenuItem.Name = "supprimerUnUtilisateurToolStripMenuItem";
            resources.ApplyResources(this.supprimerUnUtilisateurToolStripMenuItem, "supprimerUnUtilisateurToolStripMenuItem");
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            resources.ApplyResources(this.aProposToolStripMenuItem, "aProposToolStripMenuItem");
            // 
            // labelUtilisateur
            // 
            resources.ApplyResources(this.labelUtilisateur, "labelUtilisateur");
            this.labelUtilisateur.Name = "labelUtilisateur";
            // 
            // pictureLogo
            // 
            resources.ApplyResources(this.pictureLogo, "pictureLogo");
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.TabStop = false;
            // 
            // textBoxUtilisateur
            // 
            resources.ApplyResources(this.textBoxUtilisateur, "textBoxUtilisateur");
            this.textBoxUtilisateur.Name = "textBoxUtilisateur";
            // 
            // labelPass
            // 
            resources.ApplyResources(this.labelPass, "labelPass");
            this.labelPass.Name = "labelPass";
            // 
            // textBoxPass
            // 
            resources.ApplyResources(this.textBoxPass, "textBoxPass");
            this.textBoxPass.Name = "textBoxPass";
            // 
            // buttonConnexion
            // 
            resources.ApplyResources(this.buttonConnexion, "buttonConnexion");
            this.buttonConnexion.Name = "buttonConnexion";
            // 
            // labelErrorConnect
            // 
            resources.ApplyResources(this.labelErrorConnect, "labelErrorConnect");
            this.labelErrorConnect.Name = "labelErrorConnect";
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // pagePrincipale
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "pagePrincipale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem gestionDesLettreDeCoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirModifierUneLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signerUneLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerUneLCAuClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirModifierUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirModifierUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TextBox textBoxUtilisateur;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label labelErrorConnect;
        private System.Windows.Forms.Panel mainPanel;
    }
}

