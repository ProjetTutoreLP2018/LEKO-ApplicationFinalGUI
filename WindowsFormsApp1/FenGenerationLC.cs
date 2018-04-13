using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace lot1
{
    public partial class FenGenerationLC : Form
    {

       
        /// <summary>
        /// Contient le chemin vers le modèle sélectionné par l'utilisateur
        /// </summary>
        public String ModeleSelectionne;

        /// <summary>
        /// Contient le chemin vers le fichier de destination sélectionné par l'utilisateur
        /// </summary>
        public String DestinationSelectionnee = @"C:\Users\Dupeyrat\Desktop\FINACOOP\Interne\5.LC & Prospection\5.Lettres de coopération\LC à réaliser et envoyer\";

        /// <summary>
        /// Initialise les composants graphiques et active ou désactive le bouton Générer
        /// </summary>
        public FenGenerationLC()
        {
            InitializeComponent();
            ActiverBoutonGenerer();
        }

        /// <summary>
        /// Affiche une boîte de dialogue pour sélectionner un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParcourirModele_Click(object sender, EventArgs e)
        {
            //OuvrirModele.InitialDirectory = Properties.Settings.Default.dossierLC;
            if (OuvrirModele.ShowDialog() == DialogResult.OK)
            {
                SelectionModele.Text = OuvrirModele.FileName;
            }
        }


        /// <summary>
        /// Place les chemins des deux fichiers modèle et destination dans les variables ModeleSelectionne et DestinationSelectionnee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoutonGenerer_Click(object sender, EventArgs e)
        {
            ModeleSelectionne = SelectionModele.Text;
            //DestinationSelectionnee = SelectionDestination.Text;
        }

        /// <summary>
        /// Désactive ou active le bouton Générer en fonction du contenu des champs
        /// </summary>
        private void ActiverBoutonGenerer()
        {
            BoutonGenerer.Enabled = (SelectionModele.Text != "" && File.Exists(@SelectionModele.Text) ? true : false);
        }

        /// <summary>
        /// Vérifie si le champ Modèle est rempli et que le chemin renseigné pointe vers un fichier qui existe, affiche une erreur le cas échéant et désactive le bouton Générer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionModele_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(@SelectionModele.Text))
            {
                AffichageErreurs.SetIconPadding(SelectionModele, 2);
                AffichageErreurs.SetError(SelectionModele, "Le champ doit être renseigné");
            }
            else
            {
                if (File.Exists(@SelectionModele.Text))
                {
                    AffichageErreurs.SetError(SelectionModele, "");
                }
                else
                {
                    AffichageErreurs.SetIconPadding(SelectionModele, 2);
                    AffichageErreurs.SetError(SelectionModele, "Le fichier n'existe pas");
                }
            }
            ActiverBoutonGenerer();
        }
 

        /// <summary>
        /// Permet de valider l'existence du fichier modèle à la perte du focus du champ Modèle, affiche une erreur le cas échéant et désactive le bouton Générer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionModele_Validating(object sender, CancelEventArgs e)
        {
            if (File.Exists(@SelectionModele.Text))
            {
                AffichageErreurs.SetError(SelectionModele, "");
            }
            else
            {
                AffichageErreurs.SetIconPadding(SelectionModele, 2);
                AffichageErreurs.SetError(SelectionModele, "Le fichier n'existe pas");
            }
            ActiverBoutonGenerer();
        }
    }
}