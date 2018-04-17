using LettreCooperation.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace lot1
{
    public partial class FormulaireClient : Form
    {
        public FormulaireClient()
        {
            InitializeComponent();
        }

        private void FormulaireClient_Load(object sender, EventArgs e)
        {
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

        private async void BoutonValider_Click(object sender, EventArgs e)
        {
			await Task.Run(() => {
				try
				{
					ModelManager modele = new ModelManager();

					Adresse adresse = new Adresse();
					adresse.numero= NumeroVoie.Text;
					adresse.indice = IndiceRepetition.Text;
					adresse.voie = Adresse.Text;
					adresse.complements = Complement.Text;
					adresse.code_postal = CodePostal.Text;
					adresse.ville = Ville.Text;

					modele.CreerAdresse(adresse);

					Client client = new Client();
					client.CA = (double) CA.Value;
					client.date_immatriculation= DateImmatriculation.Value;
					client.effectifs= (int) Effectif.Value;
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

				} catch(Exception ex)
				{
					MessageBox.Show("Une erreur est survenue. Veuillez réessayer.\nSi cette erreur se reproduit à l'avenir, contactez le développeur du logiciel en lui indiquant le message d'erreur.\nMessage d'erreur : " + ex.InnerException.Message, "Erreur", MessageBoxButtons.OK);
				}
			});

			
		}
	}
}
