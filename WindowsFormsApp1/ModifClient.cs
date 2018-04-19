using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using LettreCooperation.modele;

namespace WindowsFormsApp1
{
    public partial class ModifClient : UserControl
    {

        private List<Client> clients;
        private ModelManager model;
        private int index;

        public ModifClient()
        {
            InitializeComponent();

            
        }
        private void ReloadComboBox()
        {
            clients = model.GetListClient();

            comboBox2.Items.Clear();

            foreach (Client c in clients)
            {
                
                comboBox2.Items.Add(c.raison_sociale);


            }
        }

        private void Init()
        {
            index = 0;
            clients = new List<Client>();
            model = new ModelManager();

            comboBox2.Text = string.Empty;
            NumeroVoie.Text = string.Empty;

            IndiceRepetition.Text = string.Empty;
            Adresse.Text = string.Empty;
            Complement.Text = string.Empty;
            CodePostal.Text = string.Empty;
            Ville.Text = string.Empty;

            CA.Value = 0;
            DateImmatriculation.Value = DateTime.Now;
            Effectif.Value = 0;
            ESSNon.PerformClick();
            FonctionRepresentant.Text = string.Empty;
            FormeJuridique.Text = string.Empty;
            LieuImmatriculation.Text = string.Empty;
            NomRepresentant.Text = string.Empty;
            OrganisationComptable.Text = string.Empty;
            PrenomRepresentant.Text = string.Empty;
            NomOrganisation.Text = string.Empty;
            SexeRepresentant.Text = string.Empty;
            NumeroSiret.Text = string.Empty;
            SiteInternet.Text = string.Empty;
            TelephoneRepresentant.Text = string.Empty;
            TelephonePortableRepresentant.Text = string.Empty;
            VolumesAnnuels.Text = string.Empty;
            CourrielRepresentant.Text = string.Empty;



            ReloadComboBox();




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

        internal ModelManager Model { get => Model1; set => Model1 = value; }
        internal ModelManager Model1 { get => model; set => model = value; }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = comboBox2.SelectedIndex;
            comboBox2.Text = clients[index].raison_sociale;

            NomOrganisation.Text = clients[index].raison_sociale;
            FormeJuridique.Text = clients[index].forme_juridique;
            Effectif.Value = clients[index].effectifs;
            CA.Value = (decimal) clients[index].CA ;
            SiteInternet.Text = clients[index].site_web;
            if(clients[index].ESS == true)
            {
                ESSOui.PerformClick();
            } else
            {
                ESSNon.PerformClick() ;
            }
            NumeroSiret.Text = clients[index].siret;

            DateImmatriculation.Value = (DateTime) clients[index].date_immatriculation;
            LieuImmatriculation.Text = clients[index].lieu_immatriculation;
            OrganisationComptable.Text = clients[index].organisation_comptable;
            VolumesAnnuels.Value = (decimal) clients[index].volume_annuel;
            NumeroVoie.Text =  clients[index].Adresse.numero;
            IndiceRepetition.Text = clients[index].Adresse.indice;
            Adresse.Text = clients[index].Adresse.voie;
            Complement.Text = clients[index].Adresse.complements;
            CodePostal.Text = clients[index].Adresse.code_postal;
            Ville.Text = clients[index].Adresse.ville;
            NomRepresentant.Text = clients[index].nom_referent;
            PrenomRepresentant.Text = clients[index].prenom_referent;
            CourrielRepresentant.Text = clients[index].mail_referent;
            SexeRepresentant.Text = clients[index].sexe_referent;
            FonctionRepresentant.Text = clients[index].fonction_referent;
            TelephonePortableRepresentant.Text = clients[index].tel_portable;
            TelephoneRepresentant.Text = clients[index].tel_fix;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BoutonValider_Click(object sender, EventArgs e)
        {
            clients[index].raison_sociale = NomOrganisation.Text;
            
            clients[index].forme_juridique = FormeJuridique.Text;
            clients[index].effectifs = (int) Effectif.Value;
            clients[index].CA = (double) CA.Value;
            clients[index].site_web = SiteInternet.Text;
            if (ESSOui.Checked)
            {
                clients[index].ESS = true;

            } else
            {
                clients[index].ESS = false;
            }

            clients[index].siret = NumeroSiret.Text;
            clients[index].date_immatriculation = DateImmatriculation.Value;
            clients[index].lieu_immatriculation = LieuImmatriculation.Text;
            clients[index].organisation_comptable = OrganisationComptable.Text;
            clients[index].volume_annuel = (double) VolumesAnnuels.Value;

            //Adresse
            clients[index].Adresse.numero = NumeroVoie.Text;
            clients[index].Adresse.indice = IndiceRepetition.Text;
            clients[index].Adresse.voie = Adresse.Text;
            clients[index].Adresse.complements = Complement.Text;
            clients[index].Adresse.code_postal = CodePostal.Text;
            clients[index].Adresse.ville = Ville.Text;

            //Referent 
            clients[index].nom_referent = NomRepresentant.Text;
            clients[index].prenom_referent = PrenomRepresentant.Text;
            clients[index].sexe_referent = SexeRepresentant.Text;
            clients[index].mail_referent = CourrielRepresentant.Text;
            clients[index].fonction_referent = FonctionRepresentant.Text;
            clients[index].tel_portable = TelephonePortableRepresentant.Text;
            clients[index].tel_fix = TelephoneRepresentant.Text;







            try
            {
                model.ModifClient();
                MessageBox.Show("Le client "+ clients[index].raison_sociale + " a bien été modifié.");
                Init();
            }
            catch (Exception)
            {
                MessageBox.Show("Oops ! Le client "+ clients[index].raison_sociale + " n'a pas été modifié.");

            }
         

        }

        private void BoutonAnnuler_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void SupprimerClient_Click(object sender, EventArgs e)
        {
          
            bool isDeleted = model.SupprimerClient(clients[index]);
            if (isDeleted)
            {
                MessageBox.Show("Le client "+ clients[index].raison_sociale + " a bien été supprimé");
            } else
            {
                MessageBox.Show("Au moins une Lettre de coopération appartient au client : "+ clients[index].raison_sociale + ". Suppression impossible.");
            }          
            Init();

        }
    }
}
