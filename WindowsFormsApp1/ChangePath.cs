using System;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class ChangePath : Form
    {


        public ChangePath()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimmentions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelMessage.Text = "Vous pouvez ici changer changer le chemin\n"
                + "de votre dossier FINACOOP.";
        }
       

        /// <summary>
        /// Méthode qui permet d'enregistrer dans la 
        /// base de données le nouveau chemin 'FINACOOP'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            // Si le chemin du dossier est renseigné,
            // nous pouvons ouvrir l'application
            if (String.IsNullOrEmpty(textBoxPath.Text))
            {
                MessageBox.Show("Merci de renseigner le chemin du dossier 'FINACOOP'");
                return;
            }

            Program.FINACOOPFolder = textBoxPath.Text;
            Properties.Settings.Default.PathFINACOOP = textBoxPath.Text;
            Properties.Settings.Default.Save();
            this.Close();

        }


        /// <summary>
        /// Méthode qui ferme la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Méthode qui permet d'aller chercher le fichier
        /// sur le disque dur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButonParcour_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
