using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    public partial class ManagerUtilisateur : UserControl
    {


        private List<Utilisateur> utilisateurs;
        private List<Droit> droits;
        private Model model;
        private int index;


        public ManagerUtilisateur()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// Méthode d'initialisation de la
        /// page.
        /// </summary>
        private void Init()
        {
            this.textPass.PasswordChar = '•';
            this.textPassConfirm.PasswordChar = '•';

            utilisateurs = new List<Utilisateur>();
            droits = new List<Droit>();
            model = new Model();
            index = 0;
            comboNomUtilisateur.Items.Clear();
            comboNomUtilisateur.ResetText();
            comboDroit.Items.Clear();
            comboDroit.ResetText();
            textNom.Text = string.Empty;
            textPrenom.Text = string.Empty;
            textEmail.Text = string.Empty;
            textPass.Text = string.Empty;
            textPassConfirm.Text = string.Empty;


            utilisateurs = model.GetListUtilisateurs();
            droits = model.GetListDroit();

            foreach (Utilisateur u in utilisateurs)
                comboNomUtilisateur.Items.Add(u.NomUtilisateur);


            foreach (Droit d in droits)
                comboDroit.Items.Add(d.Permission);
        }


        /// <summary>
        /// Méthode de gestion du chagement de la page
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();

        }


        /// <summary>
        /// Méthode qui permet de gérer le changement
        /// de l'élément séléctionner dans la comboBox.
        /// Elle permet de chager les éléments dans le
        /// reste de la page en fonction de la séléction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboNomUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = comboNomUtilisateur.SelectedIndex;
            textNom.Text = utilisateurs[index].NomUtilisateur;
            textPrenom.Text = utilisateurs[index].PrenomUtilisateur;
            textEmail.Text = utilisateurs[index].EmailUtilisateur;

            comboDroit.SelectedIndex = utilisateurs[index].IdDroit - 1;

        }

        // Modify user
        /// <summary>
        /// Méthode qui permet de modifier les éléments
        /// inscrit dans les champs en fonction de l'élément séléctionné
        /// dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {


            utilisateurs[index].NomUtilisateur = textNom.Text;
            utilisateurs[index].PrenomUtilisateur = textPrenom.Text;
            utilisateurs[index].EmailUtilisateur = textEmail.Text;

            if(!textPass.Text.Equals("") && textPass.Text.Equals(textPassConfirm.Text))
                utilisateurs[index].MdpUtilisateur = textPass.Text;

            int indexDroit = 0;

            foreach (Droit d in droits)
                if (d.Permission.Equals(comboDroit.SelectedItem))
                    indexDroit = d.IdDroit;

            utilisateurs[index].IdDroit = indexDroit;

            model.ModifUtilisateur();
            MessageBox.Show("Votre utilisateur a bien été modifié");
            Init();
        }

        // Delete user
        /// <summary>
        /// Méthode qui permet de supprimer 
        /// de la base de données l'utilisateur
        /// en fonction de l'élément séléctionné
        /// dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            model.SupprimerUtilisateur(utilisateurs[index]);
            MessageBox.Show("Votre utilisateur a bien été supprimé");
            Init();

        }
    }
}
