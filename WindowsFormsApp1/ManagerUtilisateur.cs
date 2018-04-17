using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LettreCooperation.modele;
using WindowsFormsApp1.Model;

namespace LettreCooperation
{
    public partial class ManagerUtilisateur : UserControl
    {


        private List<Utilisateur> utilisateurs;
        private List<Droit> droits;
        private ModelManager model;
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
            model = new ModelManager();
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
                comboNomUtilisateur.Items.Add(u.nom_utilisateur);


            foreach (Droit d in droits)
                comboDroit.Items.Add(d.permission);
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
            textNom.Text = utilisateurs[index].nom_utilisateur;
            textPrenom.Text = utilisateurs[index].prenom_utilisateur;
            textEmail.Text = utilisateurs[index].email_utilisateur;

            comboDroit.SelectedIndex = utilisateurs[index].id_droit - 1;

            if (utilisateurs[index].isAdmin)
                checkBoxAdmin.Checked = true;
            else
                checkBoxAdmin.Checked = false;

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


            utilisateurs[index].nom_utilisateur = textNom.Text;
            utilisateurs[index].prenom_utilisateur = textPrenom.Text;
            utilisateurs[index].email_utilisateur = textEmail.Text;

            if(!textPass.Text.Equals("") && textPass.Text.Equals(textPassConfirm.Text))
                utilisateurs[index].mdp_utilisateur = textPass.Text;

            int indexDroit = 0;

            foreach (Droit d in droits)
                if (d.permission.Equals(comboDroit.SelectedItem))
                    indexDroit = d.id_droit;

            utilisateurs[index].id_droit = indexDroit;

            if (checkBoxAdmin.Checked)
                utilisateurs[index].isAdmin = true;
            else
                utilisateurs[index].isAdmin = false;

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
