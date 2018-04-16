using System;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            this.textBoxPass.PasswordChar = '•';
        }


        /// <summary>
        /// Méthode qui permet la vérification des informations de 
        /// connexion avec la base de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnexion_Click(object sender, EventArgs e)
        {

            if (this.textBoxUtilisateur.Text != "" && this.textBoxPass.Text != "")
            {
                Model connexion = new Model();
                Utilisateur connecte = connexion.seConnecter(this.textBoxUtilisateur.Text, this.textBoxPass.Text);

                if (connecte != null)
                {
                    this.Visible = false;
                    pagePrincipale.Utilisateur = connecte;


                    Panel panel = (Panel)this.Parent.Controls.Find("mainPanel", false)[0];
                    panel.Visible = true;

                    PictureBox imageHome = (PictureBox)this.Parent.Controls.Find("imageHome", false)[0];
                    imageHome.Visible = true;

                    PictureBox pictureLogout = (PictureBox)this.Parent.Controls.Find("pictureLogout", false)[0];
                    pictureLogout.Visible = true;

                    Label labelUser = (Label)this.Parent.Controls.Find("labelUser", false)[0];
                    labelUser.Visible = true;



                    Label labelWelcome = (Label)this.Parent.Controls.Find("labelUser", false)[0];
                    labelWelcome.Text = pagePrincipale.Utilisateur.nom_utilisateur
                + " " + pagePrincipale.Utilisateur.prenom_utilisateur;


                    this.textBoxUtilisateur.Text = string.Empty;
                    this.textBoxPass.Text = string.Empty;

                    this.labelErrorConnect.Text = string.Empty;

                } else
                {
                    this.labelErrorConnect.Text = "Identifiants incorrects";
                }

            }
            else
            {
                this.labelErrorConnect.Text = "Merci de renseigner les champs vides.";
            }
           
        }
    }
}
