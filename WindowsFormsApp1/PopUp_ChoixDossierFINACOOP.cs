using System;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class PopUp_ChoixDossierFINACOOP : Form
    {

        /// <summary>
        /// Constructeur de classe qui permet
        /// de l'initialiser
        /// </summary>
        public PopUp_ChoixDossierFINACOOP()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimensions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            textBoxPath.Text = Properties.Settings.Default.PathFINACOOP;

            labelMessage.Text = "Bonjour, bienvenue dans votre application\n" +
                "de gestion de Lettres de Coopération.\n" +
                "Merci de renseigner ici le chemin d'accès à votre dossier\n" +
                "'FINACOOP' de votre ordinateur afin de continuer.";
        }


        /// <summary>
        /// Méthode qui va gérer l'évènement du clic
        /// sur le bouton valider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            // Si le chemin du dossier est renseigné,
            // nous pouvons ouvrir l'application
            if (textBoxPath.Text.Equals("null"))
            {
                MessageBox.Show("Merci de renseigner le chemin du dossier 'FINACOOP'");
                return;
            }

            Properties.Settings.Default.PathFINACOOP = textBoxPath.Text;
            Properties.Settings.Default.Save();

            this.Close();
        }


        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (textBoxPath.Text.Equals("null"))
            {
                Program.QuitApp = true;
            }

           // e.Cancel = true;
        }


        /// <summary>
        /// Méthode qui permet de gérer le parcours
        /// sur le Disque Dur de l'utilisateur pour trouver
        /// le dossier FINACOOP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParcours_Click(object sender, EventArgs e)
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
           
        }
    }
}
