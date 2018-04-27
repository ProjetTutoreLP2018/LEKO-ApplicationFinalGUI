using System;
using System.Windows.Forms;
using LettreCooperation.Model;


namespace LettreCooperation
{
    public partial class Page_Principale : Form
    {

       
        
        public static Utilisateur Utilisateur { get; set; }

        
        public Page_Principale()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

           // this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }



        /// <summary>
        /// Méthode d'initialisation des éléments
        /// du menu
        /// </summary>
        private void Init()
        {
            mainPanel.Controls.Clear();
            mainPanel.Visible = false;
            pictureLogout.Visible = false;
            labelUser.Visible = false;

        

            UserControl log = new Page_Connexion(this)
            {
                Parent = this,
                
            };

            log.Show();

            this.mainMenu.Visible = false;

            imageHome.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();      
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseAllWordFile();
        }


        private void CloseAllWordFile()
        {
            WordTools.CloseWord();
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
   
            InitUserContole(new Page_CreationDeLc());
        }


        /// <summary>
        /// Méthode qui gére l'événement 'Voir / Modifier une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoirModifierUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InitUserContole(new Page_ManagerLc());

        }


        /// <summary>
        /// Méthode qui gére l'événement 'Signer une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Page_Principale.Utilisateur.id_droit == 2)
                InitUserContole(new Page_SignatureExp());
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

            if (Page_Principale.Utilisateur.isAdmin)
                InitUserContole(new Page_CreerNouveauUtilisateur());
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

            if (Page_Principale.Utilisateur.isAdmin)
                InitUserContole(new Page_ManagerUtilisateur());
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
            InitUserContole(new Page_TableauDeBord());
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
            if (Page_Principale.Utilisateur.id_droit == 2)
            {
                InitUserContole(new Page_EnvoieLcAuClient());
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
            if (Page_Principale.Utilisateur.id_droit == 2)
            {
                RetourClientLC retourClientLC = new RetourClientLC();
                retourClientLC.Show();
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
            if (Page_Principale.Utilisateur.isAdmin)
            {
                PopUp_AjoutNouveauModele ajoutModele = new PopUp_AjoutNouveauModele();
                ajoutModele.Show();
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
            if (Utilisateur.isAdmin)
            {
                PopUp_ChangeCheminDossierFINACOOP changePath = new PopUp_ChangeCheminDossierFINACOOP();
                changePath.Show();
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
            InitUserContole(new Page_CreationNouveauClient());
        }


        /// <summary>
        /// Méthode qui permet de voir et modifier un client
        /// dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoirModifierUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitUserContole(new Page_ModificationClient());
        }


        /// <summary>
        /// Méthode qui permet de montrer la page ' A propos '
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopUp_APropos popUp_APropos = new PopUp_APropos();
            popUp_APropos.Show();
        }

        private void ChangerSMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utilisateur.isAdmin)
            {
                PopUp_ChangeSMTP changeSMTP = new PopUp_ChangeSMTP();
                changeSMTP.Show();
            }
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");
        }

        private void VoireLesArchivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Page_VoirArchives page_VoirArchives = new Page_VoirArchives();
            page_VoirArchives.Show();
        }

        private void supprimerUnModèleDeLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utilisateur.isAdmin)
            {
                PopUp_SupprimerUnModeleDeLc popUp_SupprimerUnModeleDeLc = new PopUp_SupprimerUnModeleDeLc();
                popUp_SupprimerUnModeleDeLc.Show();
            }
        }
    }
}
