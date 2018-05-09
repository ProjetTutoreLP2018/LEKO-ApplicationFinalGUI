using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LettreCooperation.modele;
using LettreCooperation.Model;
using app_lp;

namespace LettreCooperation
{
	public partial class Page_CreationNouveauClient : UserControl
	{
		public Page_CreationNouveauClient()
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
			PopUp_RemplissageBaseSIRENE fenPreRemplissageAutomatique = new PopUp_RemplissageBaseSIRENE();
			if (fenPreRemplissageAutomatique.ShowDialog(this) == DialogResult.OK)
			{
				Record enregistrement = fenPreRemplissageAutomatique.entrepriseSelectionnee;

                if(NomOrganisation.Text == string.Empty) 
                    if (enregistrement.fields.l1_normalisee != null)
                        NomOrganisation.Text = enregistrement.fields.l1_normalisee;
                    else
                        NomOrganisation.Text = "";

                if (FormeJuridique.Text == string.Empty)
                    if (enregistrement.fields.libnj != null)
                        FormeJuridique.Text = enregistrement.fields.libnj.Split(',')[0];
                    else
                        FormeJuridique.Text = "";

                if (Adresse.Text == string.Empty)
                    if (enregistrement.fields.numvoie != null && enregistrement.fields.typvoie != null && enregistrement.fields.libvoie != null)
                        Adresse.Text = String.Format("{0} {1}", enregistrement.fields.typvoie, enregistrement.fields.libvoie);
                    else
                        Adresse.Text = "";

                if (CodePostal.Text == string.Empty)
                    if (enregistrement.fields.codpos != null)
                        CodePostal.Text = enregistrement.fields.codpos;
                    else
                        CodePostal.Text = "";

                if (Ville.Text == string.Empty)
                    if (enregistrement.fields.libcom != null)
                        Ville.Text = enregistrement.fields.libcom;
                    else
                        Ville.Text = "";

                if (NumeroSiret.Text == string.Empty)
                    if (enregistrement.fields.siret != null)
                        NumeroSiret.Text = enregistrement.fields.siret;
                    else
                        NumeroSiret.Text = "";

                if (textBoxActivite.Text == string.Empty)
                    if (enregistrement.fields.libapet != null)
                        textBoxActivite.Text = enregistrement.fields.libapet;
                    else
                        textBoxActivite.Text = "";

                if (NumeroVoie.Text == string.Empty || NumeroVoie.Text.Equals("0"))
                    if (enregistrement.fields.numvoie != null)
                        NumeroVoie.Value = Int32.Parse(enregistrement.fields.numvoie);
                    else
                        NumeroVoie.Value = 0;

                if (DateImmatriculation.Text == string.Empty)
                    if (enregistrement.fields.dcren != null)
                        DateImmatriculation.Text = enregistrement.fields.dcren;
                    else
                        DateImmatriculation.Text = "";

                if (Effectif.Text == string.Empty || Effectif.Text.Equals("0"))
                    if (enregistrement.fields.efetcent.Equals("NN"))
                        Effectif.Value = 0;
                    else
                        Effectif.Value = Int32.Parse(enregistrement.fields.efetcent);

                if (IndiceRepetition.Text == string.Empty)
                    if (enregistrement.fields.indrep != null)
                    {
                        if (enregistrement.fields.indrep.Equals("T"))
                            IndiceRepetition.Text = "ter";
                        if (enregistrement.fields.indrep.Equals("B"))
                            IndiceRepetition.Text = "bis";
                        if (enregistrement.fields.indrep.Equals("Q"))
                            IndiceRepetition.Text = "quater";
                        if (enregistrement.fields.indrep.Equals("C"))
                            IndiceRepetition.Text = "quinquies";

                    } else
                    {
                        IndiceRepetition.Text = "";
                    }


            }
		}


		private void PréremplirAvecUnFichierClientToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            PopUp_ChoixClientTypeForm choixClientTypeForm = new PopUp_ChoixClientTypeForm();
            if (choixClientTypeForm.ShowDialog(this) == DialogResult.OK)
            {
                InfoEntreprise entrepriseChoisie = PopUp_ChoixClientTypeForm.infoEntreprise;
                if (String.IsNullOrWhiteSpace(NomOrganisation.Text))
                {
                    NomOrganisation.Text = entrepriseChoisie.nomEntreprise;
                }

                if (String.IsNullOrWhiteSpace(FormeJuridique.Text))
                {
                    FormeJuridique.Text = entrepriseChoisie.statut_commercial;
                }

                if (String.IsNullOrWhiteSpace(Adresse.Text))
                {
                    Adresse.Text = entrepriseChoisie.adresse1;
                }

                if (String.IsNullOrWhiteSpace(SexeRepresentant.Text))
                {
                    if (entrepriseChoisie.civilite == "Madame")
                    {
                        SexeRepresentant.Text = "F";
                    }
                    else
                    {
                        SexeRepresentant.Text = "M";
                    }
                }

                if (String.IsNullOrWhiteSpace(NomRepresentant.Text))
                {
                    NomRepresentant.Text = entrepriseChoisie.nom_contact;
                }

                if (String.IsNullOrWhiteSpace(PrenomRepresentant.Text))
                {
                    PrenomRepresentant.Text = entrepriseChoisie.prenom;
                }

                if (String.IsNullOrWhiteSpace(Ville.Text))
                {
                    Ville.Text = entrepriseChoisie.ville;
                }

                if (String.IsNullOrWhiteSpace(CodePostal.Text))
                {
                    CodePostal.Text = entrepriseChoisie.code_postal;
                }

               /* if (String.IsNullOrWhiteSpace(DateImmatriculation.Text))
                { */
                    DateImmatriculation.Text = entrepriseChoisie.date_creation;
                /*}*/

                if (String.IsNullOrWhiteSpace(CA.Value.ToString()) || CA.Value.Equals("0"))
                {
                    CA.Value = Int32.Parse(entrepriseChoisie.ca);
                }

                if (String.IsNullOrWhiteSpace(FonctionRepresentant.Text))
                {
                    FonctionRepresentant.Text = entrepriseChoisie.fonction;
                }

                if (String.IsNullOrWhiteSpace(Effectif.Value.ToString()) || Effectif.Value.Equals("0"))
                {
                    Effectif.Value = Int32.Parse(entrepriseChoisie.effectif);
                }

                if (String.IsNullOrWhiteSpace(OrganisationComptable.Text))
                {
                    OrganisationComptable.Text = entrepriseChoisie.organisation_comptable;
                }

                if (String.IsNullOrWhiteSpace(VolumesAnnuels.Text) || VolumesAnnuels.Text.Equals("0"))
                {
                    VolumesAnnuels.Text = entrepriseChoisie.volume_recette;
                }

               /* if (String.IsNullOrWhiteSpace(DateImmatriculation.Text))
                {*/
                    DateImmatriculation.Text = entrepriseChoisie.date_immatriculation;
                /*}*/

                if (String.IsNullOrWhiteSpace(LieuImmatriculation.Text))
                {
                    LieuImmatriculation.Text = entrepriseChoisie.lieu_immatriculation;
                }

                if (String.IsNullOrEmpty(textBoxActivite.Text))
                {
                    textBoxActivite.Text = entrepriseChoisie.activites;
                }
            }
        }


		private void BoutonValider_ClickAsync(object sender, EventArgs e)
		{
            Cursor.Current = Cursors.WaitCursor;

            messageErr.Text = string.Empty;
            adresseMailMess.Text = string.Empty;

            string email = CourrielRepresentant.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);


            if (!match.Success)
            {
                adresseMailMess.Text = "L'adresse email n'est pas valide.";
                Cursor.Current = Cursors.Default;
                return;
            }

            if (NomOrganisation.Text.Equals("") || FormeJuridique.Text.Equals("") || Effectif.Text.Equals("") ||
                NumeroSiret.Text.Equals("") || OrganisationComptable.Text.Equals("") || NumeroVoie.Text.Equals("") ||
                Adresse.Text.Equals("") || CodePostal.Text.Equals("") || Ville.Text.Equals("") ||
                NomRepresentant.Text.Equals("") || PrenomRepresentant.Text.Equals("") || CourrielRepresentant.Text.Equals("") ||
                SexeRepresentant.Text.Equals("") || FonctionRepresentant.Text.Equals("") || LieuImmatriculation.Text.Equals(""))
            {
                messageErr.Text = "Veuillez renseigner tous les champs.";
                Cursor.Current = Cursors.Default;
                return;
            }



                try
			{
				ModelManager modele = new ModelManager();

				Adresse adresse = new Adresse();
				adresse.numero = NumeroVoie.Text;
                if (!String.IsNullOrWhiteSpace(IndiceRepetition.Text))
                    adresse.indice = IndiceRepetition.Text;
                else
                    adresse.indice = " ";

                adresse.voie = Adresse.Text;

                if (!String.IsNullOrEmpty(Complement.Text))
                    adresse.complements = Complement.Text;
                else
                    adresse.complements = " ";

				adresse.code_postal = CodePostal.Text;
				adresse.ville = Ville.Text;

				modele.CreerAdresse(adresse);

                Client client = new Client
                {
                    CA = Convert.ToDouble(CA.Value),
                    date_immatriculation = DateImmatriculation.Value,
                    effectifs = Convert.ToInt32(Effectif.Value),
                    ESS = ESSOui.Checked,
                    fonction_referent = FonctionRepresentant.Text,
                    forme_juridique = FormeJuridique.Text,
                    lieu_immatriculation = LieuImmatriculation.Text,
                    nom_referent = NomRepresentant.Text,
                    organisation_comptable = OrganisationComptable.Text,
                    prenom_referent = PrenomRepresentant.Text,
                    raison_sociale = NomOrganisation.Text,
                    sexe_referent = SexeRepresentant.Text,
                    siret = NumeroSiret.Text,
                    //exercice_debut = dateTimeExercice_debut.Value,
                    //exercice_fin = dateTimeExercice_fin.Value,
                    activite = textBoxActivite.Text
                };


                if (String.IsNullOrEmpty(SiteInternet.Text))
                    client.site_web = " ";
                else
                    client.site_web = SiteInternet.Text;

                if (String.IsNullOrEmpty(TelephoneRepresentant.Text))
                    client.tel_fix = " ";
                else
                    client.tel_fix = TelephoneRepresentant.Text;


                if (String.IsNullOrEmpty(TelephonePortableRepresentant.Text))
                    client.tel_portable = " ";
                else
                    client.tel_portable = TelephonePortableRepresentant.Text;

                if (String.IsNullOrEmpty(VolumesAnnuels.Value.ToString()))
                    client.volume_annuel = 0;
                else
                    client.volume_annuel = Double.Parse(VolumesAnnuels.Text);

				client.id_adresse = adresse.id_adresse;
                client.mail_referent = CourrielRepresentant.Text;

				modele.CreerClient(client);

                MessageBox.Show("Votre client " + client.raison_sociale + " a bien été enregistré");

                Init();

            }
			catch (Exception ex)
			{
                Cursor.Current = Cursors.Default;
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
            textBoxActivite.Text = string.Empty;
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
