using LettreCooperation.modele;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Model;


namespace WindowsFormsApp1
{
    public partial class CreerUtilisateur : UserControl
    {


        private List<Droit> droits;
        private ModelManager model = new ModelManager();


        public CreerUtilisateur()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Méthode d'initialisation de la page
        /// </summary>
        private void Init()
        {





            textNom.Text = string.Empty;
            textPrenom.Text = string.Empty;
            textEmail.Text = string.Empty;
            textConfirmEmail.Text = string.Empty;
            textPass.Text = string.Empty;
            textConfPass.Text = string.Empty;

            adresseMailMess.Text = string.Empty;
            adresseMailConfMess.Text = string.Empty;
            mdpConfMess.Text = string.Empty;

            

            this.textPass.PasswordChar = '•';
            this.textConfPass.PasswordChar = '•';
        }


        /// <summary>
        /// Méthode qui permet de gérer l'événement
        /// de chargement de la page.
        /// On y initialise la liste de droit prise
        /// dans la base de données
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            droits = model.GetListDroit();

            foreach (Droit d in droits)
                comboDroit.Items.Add(d.permission);

            Init();
        }


        /// <summary>
        /// Méthode qui permet de valider une
        /// création d'un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bValider_Click(object sender, EventArgs e)
        {

            adresseMailMess.Text = string.Empty;
            adresseMailConfMess.Text = string.Empty;
            mdpConfMess.Text = string.Empty;

            string email = textEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);


            
            if (match.Success) {
                if (!textEmail.Text.Equals(textConfirmEmail.Text) || !textPass.Text.Equals(textConfPass.Text))
                {

                    if (!textEmail.Text.Equals(textConfirmEmail.Text))
                    {
                        adresseMailConfMess.Text = "L'adresse email ne correspond pas.";

                    }
                    else if (!textPass.Text.Equals(textConfPass.Text))
                    {
                        mdpConfMess.Text = "Le mot de passe \n ne correspond pas.";
                    }

                }
                else
                {
                    Utilisateur utilisateur = new Utilisateur();
                    utilisateur.nom_utilisateur = textNom.Text;
                    utilisateur.prenom_utilisateur = textPrenom.Text;
                    utilisateur.email_utilisateur = textEmail.Text;

                    if (checkBoxAdmin.Checked)
                    {
                        utilisateur.isAdmin = true;
                    }
                    else
                    {
                        utilisateur.isAdmin = false;
                    }
                    
                    int index = 0;

                    foreach (Droit d in droits)
                        if (d.permission.Equals(comboDroit.SelectedItem))
                            index = d.id_droit;


                    utilisateur.id_droit = index;
                    utilisateur.mdp_utilisateur = textPass.Text;

                    model.CreerUtilisateur(utilisateur);
                    Init();
                    
                    
                }

            } else {
                    adresseMailMess.Text = "L'adresse email n'est pas valide.";
            }
            


        }

    

        private void bAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
