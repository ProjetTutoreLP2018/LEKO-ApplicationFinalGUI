using System;
using System.Windows.Forms;
using LettreCooperation.modele;
using WindowsFormsApp1.Model;

namespace lot1
{
	public partial class UCFenFormClient : UserControl
	{
		public UCFenFormClient()
		{
			InitializeComponent();
            ESSNon.Checked = true;
		}

		private void préremplirAutomatiquementToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			PreremplirAutomatiquement();
		}

		private void PreremplirAutomatiquement()
		{
			FenPreRemplissageAutomatique fenPreRemplissageAutomatique = new FenPreRemplissageAutomatique();
			if (fenPreRemplissageAutomatique.ShowDialog(this) == DialogResult.OK)
			{
				Record enregistrement = fenPreRemplissageAutomatique.entrepriseSelectionnee;
				NomOrganisation.Text = enregistrement.fields.l1_normalisee;
				FormeJuridique.Text = enregistrement.fields.libnj.Split(',')[0];
				Adresse.Text = String.Format("{0} {1} {2}", enregistrement.fields.numvoie, enregistrement.fields.typvoie, enregistrement.fields.libvoie);
				CodePostal.Text = enregistrement.fields.codpos;
				Ville.Text = enregistrement.fields.libcom;
				//Activite.Text = enregistrement.fields.libapet;
			}
		}

		private void préremplirAvecUnFichierClientToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//TODO : à implémenter
		}

		private  void BoutonValider_ClickAsync(object sender, EventArgs e)
		{
			
			try
			{
				ModelManager modele = new ModelManager();

				Adresse adresse = new Adresse();
				adresse.numero = NumeroVoie.Text;

				adresse.indice = IndiceRepetition.SelectedItem.ToString();
				adresse.voie = Adresse.Text;
				adresse.complements = Complement.Text;
				adresse.code_postal = CodePostal.Text;
				adresse.ville = Ville.Text;

				modele.CreerAdresse(adresse);

				Client client = new Client();
				client.CA = (double)CA.Value;
				client.date_immatriculation = DateImmatriculation.Value;
				client.effectifs = (int)Effectif.Value;
				client.ESS = ESSOui.Checked;
				client.fonction_referent = FonctionRepresentant.Text;
				client.forme_juridique = FormeJuridique.Text;
				client.lieu_immatriculation = LieuImmatriculation.Text;
				client.nom_referent = NomRepresentant.Text;
				client.organisation_comptable = OrganisationComptable.Text;
				client.prenom_referent = PrenomRepresentant.Text;
				client.raison_sociale = NomOrganisation.Text;
				client.sexe_referent = SexeRepresentant.Text;
				client.siret = NumeroSiret.Text;
				client.site_web = SiteInternet.Text;
				client.tel_fix = TelephoneRepresentant.Text;
				client.tel_portable = TelephonePortableRepresentant.Text;
				client.volume_annuel = Double.Parse(VolumesAnnuels.Text);
				client.id_adresse = adresse.id_adresse;

				modele.CreerClient(client);

                MessageBox.Show("Votre client " + client.raison_sociale + " a bien était enregistré");

                Init();

            }
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue. Veuillez réessayer.\nSi cette erreur se reproduit à l'avenir, contactez le développeur du logiciel en lui indiquant le message d'erreur.\nMessage d'erreur : " + ex.StackTrace, "Erreur");
			}
		
		}

		private void BoutonAnnuler_Click(object sender, EventArgs e)
		{
            Init();
		}


        private void Init()
        {


            NumeroVoie.Text = string.Empty;

            IndiceRepetition.Items.Clear();
            Adresse.Text = string.Empty;
            Complement.Text = string.Empty;
            CodePostal.Text = string.Empty;
            Ville.Text = string.Empty;
            
            CA.Value = 0;
            DateImmatriculation.Value = DateTime.Now;
            Effectif.Value = 0;
            ESSOui.Checked = false;
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
            
        }
 
    }
}
