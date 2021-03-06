﻿using System;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class PopUp_ChangeCheminDossierFINACOOP : Form
    {


        public PopUp_ChangeCheminDossierFINACOOP()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimensions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelMessage.Text = "Vous pouvez changer ici le chemin\n"
                + "de votre dossier FINACOOP.";

            textBoxPath.Text = Properties.Settings.Default.PathFINACOOP;
        }
       

        /// <summary>
        /// Méthode qui permet d'enregistrer dans la 
        /// base de données le nouveau chemin 'FINACOOP'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Si le chemin du dossier est renseigné,
            // nous pouvons ouvrir l'application
            if (textBoxPath.Text.Length == 0)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Merci de renseigner le chemin du dossier 'FINACOOP'");
                return;
            }

            Program.FINACOOPFolder = textBoxPath.Text;
            Properties.Settings.Default.PathFINACOOP = textBoxPath.Text;
            Properties.Settings.Default.Save();
            this.Close();
            Cursor.Current = Cursors.Default;
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
        private void ButtonParcours_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
