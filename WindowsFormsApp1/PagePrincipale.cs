using lot1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Model;

namespace LettreCooperation
{
    public partial class PagePrincipale : Form
    {

        private UserControl log = new Login();
        private UserControl creerLC = new FenFormulaireGenerationLC();
        private UserControl signerLC = new SignerLC();
        private UserControl voir_mod_lc = new Voir_Modif_LC();
        private UserControl creerUtilisateur = new CreerUtilisateur();
        private UserControl manageUtilisateur = new ManagerUtilisateur();
        private UserControl formulaireClient = new UCFenFormClient();
        
        public static Utilisateur Utilisateur { get; set; }


        public PagePrincipale()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }



        /// <summary>
        /// Méthode d'initialisation des éléments
        /// du menu
        /// </summary>
        private void Init()
        {
            mainPanel.Visible = false;
            pictureLogout.Visible = false;
            labelUser.Visible = false;

            creerLC.Parent = mainPanel;
            creerLC.Visible = false;

            voir_mod_lc.Parent = mainPanel;
            voir_mod_lc.Visible = false;

            creerUtilisateur.Parent = mainPanel;
            creerUtilisateur.Visible = false;

            signerLC.Parent = mainPanel;
            signerLC.Visible = false;

            manageUtilisateur.Parent = mainPanel;
            manageUtilisateur.Visible = false;

            formulaireClient.Parent = mainPanel;
            formulaireClient.Visible = false;

            log.Parent = this;
            log.Dock = DockStyle.Top;
            log.Show(); 

            imageHome.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();      
        }


        ///======================================================================
        ///== Gestion du Menu
        ///======================================================================



        /// <summary>
        /// Méthode qui gére l'événement 'Créer Une Lc"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CréerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            InitUserContole(creerLC);
        }


        /// <summary>
        /// Méthode qui gére l'événement 'Voir / Modifier une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoirModifierUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InitUserContole(voir_mod_lc);

        }


        /// <summary>
        /// Méthode qui gére l'événement 'Signer une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PagePrincipale.Utilisateur.id_droit == 2)
                InitUserContole(signerLC);
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");

        }


        /// <summary>
        /// Méthode qui gére l'événement 'Créer un Utilisateur"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CréerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (PagePrincipale.Utilisateur.isAdmin)
                InitUserContole(creerUtilisateur);
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");

        }


        /// <summary>
        /// Méthode qui gére l'événement 'Manager un Utilisateur"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (PagePrincipale.Utilisateur.isAdmin)
                InitUserContole(manageUtilisateur);
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");
        }


        /// <summary>
        /// Initialisation de l'User Controle avant chaque séléctions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitUserContole(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.Visible = true;
        }


        /// <summary>
        /// Méthode qui permet de retourner à la page d'accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureHome_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
        }


        /// <summary>
        /// Méthode qui gére la déconnection de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureLogout_Click(object sender, EventArgs e)
        {
            Init();
            MessageBox.Show("Vous avez été déconnecté");
        }


        /// <summary>
        /// Méthode qui gére l'envoir de la LC au client par mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnvoyerUneLCAuClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PagePrincipale.Utilisateur.id_droit == 2)
            {
                ///TODO: Page d'envoie de LC au client
            }
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");
        }


        /// <summary>
        /// Méthode qui gère le retour de la LC signée par le client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetourLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PagePrincipale.Utilisateur.id_droit == 2)
            {
                ///TODO: Page de gestion de retour de LC
            }
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");
        }


        /// <summary>
        /// Méthode qu gère les modèles de LC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerUnModèleDeLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PagePrincipale.Utilisateur.isAdmin)
            {
                ///TODO: Page d'ajout/suppression d'un modele
            }
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");
        }


        /// <summary>
        /// Méthode qui permet de changer le chemin du
        /// fichier FINACOOP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangerCheminDossierFINACOOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PagePrincipale.Utilisateur.isAdmin)
            {
                ///TODO: Page de changement de Path pour le dossier FINACOOP
            }
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");
        }


        /// <summary>
        /// Méthode qui permet de créer un client
        /// dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CréerUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitUserContole(formulaireClient);
        }


        /// <summary>
        /// Méthode qui permet de voir et modifier un client
        /// dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoirModifierUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Méthode qui permet de montrer la page ' A propos '
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AProposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
