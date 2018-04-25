using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Xceed.Words.NET;
using LettreCooperation.Model;
using LettreCooperation.modele;
using System.IO;

namespace LettreCooperation
{
	public partial class FenGenerationLC : UserControl
	{

        private ModelManager modeleManager = new ModelManager();
        private List<Client> clients = new List<Client>();
        private List<Modele> modeles = new List<Modele>();
        private string _PATH =  @"\Interne\5.LC & Prospection\5.Lettres de coopération\LC à réaliser et envoyer";


		public FenGenerationLC()
		{
			InitializeComponent();
		}


		private void FenGenerationLC_Load(object sender, EventArgs e)
		{
            clients = modeleManager.GetListClient();
            modeles = modeleManager.GetModeles();

            foreach (Modele modele in modeles)
                comboBoxModel.Items.Add(modele.nom_fichier);

            foreach (Client client in clients)
                ListeDeroulanteChoixClient.Items.Add(client.raison_sociale);
            
			ListeDeroulanteChoixClient.SelectedIndex = 0;
            comboBoxModel.SelectedIndex = 0;

        }


		private void BoutonParcourirFichierValoHonoraires_Click(object sender, EventArgs e)
		{
			if (ouvrirFichierValoHonoraires.ShowDialog(this) == DialogResult.OK)
			{
				FichierValoHonoraires.Text = ouvrirFichierValoHonoraires.FileName;
			}
		}


        
		private void BoutonGenerer_Click(object sender, EventArgs e)
		{
            WaitForm waitForm = new WaitForm();
            waitForm.Show();

            string raisonSociale = ListeDeroulanteChoixClient.SelectedItem.ToString();

            String nomFichier = DateTime.Today.ToString("yyyy_MM_dd") + "_" + ListeDeroulanteChoixClient.SelectedItem.ToString() + "_" + "FINACOOP_" + textBoxMission.Text + ".docx";

            Client client = new Client();
            client = clients[ListeDeroulanteChoixClient.SelectedIndex];


            Dictionary<string, string> donnees = new Dictionary<string, string>()
			{
				{ "RaisonSociale", client.raison_sociale },
				{ "FormeJuridique", client.forme_juridique },
				{
					"Adresse",
					String.Format("{0} {1}", client.Adresse.numero,
														client.Adresse.voie)
				},
				{ "CP", client.Adresse.code_postal },
				{ "Ville", client.Adresse.ville },
				//{ "Activite", client.Activite.libelle_activite },
				{ "DateCourante", DateTime.Today.ToShortDateString() },
				{ "Millesime", DateTime.Today.Year.ToString() },
				{ "Prenom", client.prenom_referent },
				{ "Nom", client.nom_referent },
				{ "Fonction", client.fonction_referent },
				{ "Civilite",
					(client.sexe_referent == "M" ? "Monsieur" : "Madame")
				},
				{ "CherGenre", (client.sexe_referent == "M" ? "Cher" : "Chère") },
				{ "CA", client.CA.ToString() },
				{ "Effectif", client.effectifs.ToString() },
				{ "OrganisationComptable", client.organisation_comptable },
				{ "VolumesAnnuels", client.volume_annuel.ToString() },
				{ "DateImmatriculation", client.date_immatriculation.ToString() },
				{ "LieuImmatriculation", client.lieu_immatriculation },
			};


            using (DocX documentModele = DocX.Load(Program.FINACOOPFolder + modeles[comboBoxModel.SelectedIndex].chemin_modele + ".docx"))
            {

                foreach (var item in donnees)
                {
                    documentModele.ReplaceText("{{" + item.Key + "}}", item.Value);
                }

                string pathFolder = Program.FINACOOPFolder + _PATH + "\\" + client.raison_sociale;

                if (!Directory.Exists(pathFolder))
                {
                    Directory.CreateDirectory(pathFolder);
                    File.SetAttributes(pathFolder, FileAttributes.Normal);

                }

                LC lc = new LC();

                lc.chemin_lc = _PATH + "\\" + client.raison_sociale + @"\" + nomFichier;
                lc.date_debut = DateTime.Today;
                lc.id_client = client.id_client;
                lc.id_modele = modeles[comboBoxModel.SelectedIndex].id_modele;
                lc.nom_lc = nomFichier;
                lc.id_etat = 1;
                lc.id_utilisateur = PagePrincipale.Utilisateur.id_utilisateur;


                if (File.Exists(pathFolder + @"\" + nomFichier))
                {
                    string message = "Cette LC existe déjà, voulez-vous l'écraser ?";
                    string caption = "Lettre de coopération existant";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, caption, buttons);

                    if (result == DialogResult.No)
                    {
                        waitForm.Close();
                        return;
                    }

                }

                documentModele.SaveAs(pathFolder + @"\" + nomFichier);

                AfficherLC(pathFolder + @"\" + nomFichier);

                SaveLC(lc);
                waitForm.Close();
                MessageBox.Show("La lettre de coopération a été générée dans le fichier " + pathFolder + @"\" + nomFichier + ".\nAssurez-vous que la lettre de coopération générée ne contient pas d'erreurs, modifiez-la si nécessaire.", "Lettre de coopération générée", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void SaveLC(LC lc)
        {
            modeleManager.SaveLC(lc);
        }


        private void AfficherLC(string pathOrigine)
        {

            WordTools.Path = pathOrigine;
            WordTools.OpenWord();

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMission.Text = modeles[comboBoxModel.SelectedIndex].nom_mission;
        }
    }
}
