using System;
using System.Windows.Forms;
using LettreCooperation.Model;


namespace LettreCooperation
{
    public partial class PagePrincipale : Form
    {

        private UserControl log;
        
        public static Utilisateur Utilisateur { get; set; }

        public static Microsoft.Office.Interop.Word.Application FichierWord { get; set; }


        public PagePrincipale()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            FichierWord = new Microsoft.Office.Interop.Word.Application();
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


            log = new Login
            {
                Parent = this,
                Dock = DockStyle.Top
            };

            log.Show(); 

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
           
            Microsoft.Office.Interop.Word.Application app = (Microsoft.Office.Interop.Word.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");
            if (app == null)
                return;

            foreach (Microsoft.Office.Interop.Word.Document d in app.Documents)
            {
                // MessageBox.Show("Fermeture de document");
                object saveOption = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
                object originalFormat = Microsoft.Office.Interop.Word.WdOriginalFormat.wdOriginalDocumentFormat;
                object routeDocument = false;
                d.Close(ref saveOption, ref originalFormat, ref routeDocument);
                
            }

            try

            {

                FichierWord.Documents.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                FichierWord.Quit(false);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(FichierWord);
            }
            catch
            {
                //MessageBox.Show("Word fermé");
            }
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
   
            InitUserContole(new FenGenerationLC());
        }


        /// <summary>
        /// Méthode qui gére l'événement 'Voir / Modifier une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoirModifierUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InitUserContole(new Voir_Modif_LC());

        }


        /// <summary>
        /// Méthode qui gére l'événement 'Signer une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PagePrincipale.Utilisateur.id_droit == 2)
                InitUserContole(new SignatureExp());
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
                InitUserContole(new CreerUtilisateur());
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
                InitUserContole(new ManagerUtilisateur());
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
                InitUserContole(new EnvoieLcAuClient());
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
                ChangePath changePath = new ChangePath();
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
            InitUserContole(new UCFenFormClient());
        }


        /// <summary>
        /// Méthode qui permet de voir et modifier un client
        /// dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoirModifierUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitUserContole(new ModifClient());
        }


        /// <summary>
        /// Méthode qui permet de montrer la page ' A propos '
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AProposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changerSMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PagePrincipale.Utilisateur.isAdmin)
            {
                ChangeSMTP changeSMTP = new ChangeSMTP();
                changeSMTP.Show();
            }
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");
        }
    }
}
