﻿namespace WindowsFormsApp1
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
            this.ManagerUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.textBoxUtilisateur = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.labelErrorConnect = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.imageHome = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureLogout = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesLettreDeCoToolStripMenuItem,
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesUtilisateursToolStripMenuItem,
            this.aProposToolStripMenuItem});
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
            this.ManagerUtilisateurToolStripMenuItem});
            this.gestionDesUtilisateursToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            resources.ApplyResources(this.gestionDesUtilisateursToolStripMenuItem, "gestionDesUtilisateursToolStripMenuItem");
            // 
            // créerUnUtilisateurToolStripMenuItem
            // 
            this.créerUnUtilisateurToolStripMenuItem.Name = "créerUnUtilisateurToolStripMenuItem";
            resources.ApplyResources(this.créerUnUtilisateurToolStripMenuItem, "créerUnUtilisateurToolStripMenuItem");
            this.créerUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.créerUnUtilisateurToolStripMenuItem_Click);
            // 
            // ManagerUtilisateurToolStripMenuItem
            // 
            this.ManagerUtilisateurToolStripMenuItem.Name = "ManagerUtilisateurToolStripMenuItem";
            resources.ApplyResources(this.ManagerUtilisateurToolStripMenuItem, "ManagerUtilisateurToolStripMenuItem");
            this.ManagerUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ManagerUtilisateurToolStripMenuItem_Click);
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
            // imageHome
            // 
            this.imageHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.imageHome, "imageHome");
            this.imageHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageHome.Name = "imageHome";
            this.imageHome.TabStop = false;
            this.imageHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelWelcome
            // 
            resources.ApplyResources(this.labelWelcome, "labelWelcome");
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Name = "labelWelcome";
            // 
            // labelUser
            // 
            resources.ApplyResources(this.labelUser, "labelUser");
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelUser.Name = "labelUser";
            // 
            // pictureLogout
            // 
            this.pictureLogout.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureLogout, "pictureLogout");
            this.pictureLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogout.Name = "pictureLogout";
            this.pictureLogout.TabStop = false;
            this.pictureLogout.Click += new System.EventHandler(this.pictureLogout_Click);
            // 
            // pagePrincipale
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureLogout);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.imageHome);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "pagePrincipale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem ManagerUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TextBox textBoxUtilisateur;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label labelErrorConnect;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox imageHome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureLogout;
    }
}

