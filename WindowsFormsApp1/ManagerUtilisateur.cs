using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    public partial class ManagerUtilisateur : UserControl
    {


        private List<Utilisateur> utilisateurs;
        private List<Droit> droits;
        private WindowsFormsApp1.modele.Model model;
        private int index;


        public ManagerUtilisateur()
        {
            InitializeComponent();
            Init();
            
        }

        private void Init()
        {

            utilisateurs = new List<Utilisateur>();
            droits = new List<Droit>();
            model = new WindowsFormsApp1.modele.Model();
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           
        }

        private void comboNomUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = comboNomUtilisateur.SelectedIndex;
            textNom.Text = utilisateurs[index].NomUtilisateur;
            textPrenom.Text = utilisateurs[index].PrenomUtilisateur;
            textEmail.Text = utilisateurs[index].EmailUtilisateur;

            comboDroit.SelectedIndex = utilisateurs[index].IdDroit - 1;

        }

        // Modify user
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
            MessageBox.Show("Votre utilisateur a bien était modifier");
            Init();
        }

        // Delete user
        private void button2_Click(object sender, EventArgs e)
        {

            model.SupprimerUtilisateur(utilisateurs[index]);
            MessageBox.Show("Votre utilisateur a bien était supprimer");
            Init();

        }
    }
}
