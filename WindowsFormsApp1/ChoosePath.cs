using System;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class ChoosePath : Form
    {

        /// <summary>
        /// Constructeur de class qui permet
        /// de l'initialiser
        /// </summary>
        public ChoosePath()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimmentions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelMessage.Text = "Bonjour, bienvenue dans votre application\n" +
                "de gestion de Lettres de Coopérations.\n" +
                "Merci de renseigner ici le chemin d'accès à votre dossier\n" +
                "'FINACOOP' de votre ordinateur afin de continuer.";
        }


        /// <summary>
        /// Méthode qui va gérer l'événement du clique
        /// sur le bouton valider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            // Si le chemin du dossier est renseigné,
            // nous pouvons ouvrir l'application
            if (!String.IsNullOrEmpty(textBoxPath.Text))
            {
                MessageBox.Show("Merci de renseigner le chemin du dossier 'FINACOOP'");
                return;
            }

            Program.FINACOOPFolder = textBoxPath.Text;
            this.Close();
        }


        /// <summary>
        /// Méthode qui permet de gérer le parcour
        /// sur le Disque Dur de l'utilisateur pour trouver
        /// le dossier FINACOOP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButonParcour_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowser.SelectedPath;
            }
        }


        /// <summary>
        /// Méthode qui permet de quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Program.QuitApp = true;
        }
    }
}
