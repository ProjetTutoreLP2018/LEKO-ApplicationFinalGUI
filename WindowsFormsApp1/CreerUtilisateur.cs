using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.modele;


namespace WindowsFormsApp1
{
    public partial class CreerUtilisateur : UserControl
    {

        
        private List<Droit> droits;
        private WindowsFormsApp1.modele.Model model = new WindowsFormsApp1.modele.Model();


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
                comboDroit.Items.Add(d.Permission);

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
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.NomUtilisateur = textNom.Text;
            utilisateur.PrenomUtilisateur = textPrenom.Text;
            utilisateur.EmailUtilisateur = textEmail.Text;

            int index = 0;

            foreach (Droit d in droits)
                if (d.Permission.Equals(comboDroit.SelectedItem))
                    index = d.IdDroit;
            

            utilisateur.IdDroit = index;
            utilisateur.MdpUtilisateur = textPass.Text;

            model.CreerUtilisateur(utilisateur);
            Init();
        }
    }
}
