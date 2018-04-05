using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
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


        private void Init()
        {

            textNom.Text = string.Empty;
            textPrenom.Text = string.Empty;
            textEmail.Text = string.Empty;
            textConfirmEmail.Text = string.Empty;
            textPass.Text = string.Empty;
            textConfPass.Text = string.Empty;
        }

        protected override void OnLoad(EventArgs e)
        {
            
            droits = model.GetListDroit();

            foreach (Droit d in droits)
            {
                MessageBox.Show("Dans la list Droit : " + d.Permission);
                comboDroit.Items.Add(d.Permission);
            }

            Init();

            base.OnLoad(e);
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.NomUtilisateur = textNom.Text;
            utilisateur.PrenomUtilisateur = textPrenom.Text;
            utilisateur.EmailUtilisateur = textEmail.Text;

            int index = 0;

            foreach (Droit d in droits)
                if (d.Permission.Equals(comboDroit.SelectedText))
                    index = d.IdDroit;

            MessageBox.Show("" + index);

            utilisateur.IdDroit = index;

            utilisateur.MdpUtilisateur = textPass.Text;

            MessageBox.Show("Votre utilisateur " + utilisateur.NomUtilisateur + " a bien était créer");

            model.CreerUtilisateur(utilisateur);
            Init();
        }
    }
}
