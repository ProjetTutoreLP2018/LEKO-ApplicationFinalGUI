using lot1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    public partial class pagePrincipale : Form
    {

        private UserControl log = new Login();
        //private UserControl creerLC = new CreerUneLC();
        private UserControl creerLC = new FenFormulaireGenerationLC();
        private UserControl signerLC = new SignerLC();
        private UserControl voir_mod_lc = new Voir_Modif_LC();
        private UserControl creerUtilisateur = new CreerUtilisateur();
        private UserControl manageUtilisateur = new ManagerUtilisateur();

        public static Utilisateur Utilisateur { get; set; }

       
        List<UserControl> listUserControle = new List<UserControl>();

        public pagePrincipale()
        {
            InitializeComponent();
           
        }


        /// <summary>
        /// Méthode d'initialisation des éléments
        /// de la page
        /// </summary>
        private void Init()
        {
            mainPanel.Visible = false;
            pictureLogout.Visible = false;
            labelUser.Visible = false;

            creerLC.Parent = mainPanel;
            creerLC.Visible = false;
            // mainPanel.Controls.Add(creerLC);

            voir_mod_lc.Parent = mainPanel;
            voir_mod_lc.Visible = false;
            //mainPanel.Controls.Add(ajou_mod_lc);

            creerUtilisateur.Parent = mainPanel;
            creerUtilisateur.Visible = false;

            signerLC.Parent = mainPanel;
            signerLC.Visible = false;

            manageUtilisateur.Parent = mainPanel;
            manageUtilisateur.Visible = false;

            log.Parent = this;
            log.Dock = DockStyle.Top;
            log.Show();

            imageHome.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
           
        }


        /// <summary>
        /// Méthode qui gére l'événement 'Créer Une Lc"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void créerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            InitUserContole(creerLC);
        }


        /// <summary>
        /// Méthode qui gére l'événement 'Voir / Modifier une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voirModifierUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InitUserContole(voir_mod_lc);

        }


        /// <summary>
        /// Méthode qui gére l'événement 'Signer une LC"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pagePrincipale.Utilisateur.id_droit == 2)
                InitUserContole(signerLC);
            else
                MessageBox.Show("Vous n'avez pas la permission de faire cette action.");

        }


        /// <summary>
        /// Méthode qui gére l'événement 'Créer un Utilisateur"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void créerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pagePrincipale.Utilisateur.id_droit == 2)
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

            if (pagePrincipale.Utilisateur.id_droit == 2)
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
        }


        /// <summary>
        /// Méthode qui gére la déconnection de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureLogout_Click(object sender, EventArgs e)
        {
            Init();
            MessageBox.Show("Vous avez été déconnecté");
        }
    }
}
