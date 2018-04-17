using System;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class ChoosePath : Form
    {
        public ChoosePath()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelMessage.Text = "Bonjour, bienvenue dans votre application\n" +
                "de gestion de Lettres de Coopérations.\n" +
                "Merci de renseigner ici le chemin d'accès à votre dossier\n" +
                "'FINACOOP' de votre ordinateur afin de continuer.";
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPath.Text))
            {

                Program.FINACOOPFolder = textBoxPath.Text;

                this.Close();

            } else
            {
                MessageBox.Show("Merci de renseigner le chemin du dossier 'FINACOOP'");
            }
        }


        private void butonParcour_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Program.QuitApp = true;
        }
    }
}
