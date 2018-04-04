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

        
        private List<Droit> droits = new List<Droit>();
        private WindowsFormsApp1.modele.Model model = new WindowsFormsApp1.modele.Model();
       



        public CreerUtilisateur()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            //Your code to run on load goes here 

            // Call the base class OnLoad to ensure any delegate event handlers are still callled

            droits = model.GetListDroit();

            foreach (Droit d in droits)
            {
                Console.WriteLine(d);
                comboDroit.Items.Add(d.Permission);
            }

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

            utilisateur.IdDroit = index+1;

            utilisateur.MdpUtilisateur = textPass.Text;

            MessageBox.Show(utilisateur.ToString());

            model.CreerUtilisateur(utilisateur);

        }
    }
}
