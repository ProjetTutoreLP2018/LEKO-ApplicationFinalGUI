using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class ChangeSMTP : Form
    {
        public ChangeSMTP()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimmentions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            textBoxSMTP.Text = Properties.Settings.Default.SMTP;

            labelMessage.Text = "Vous pouvez ici changer votre SMTP.";
        }


        /// <summary>
        /// Méthode qui permet d'enregistrer dans la 
        /// base de données le nouveau SMTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SMTP = textBoxSMTP.Text;
            Properties.Settings.Default.Save();
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
    }
}
