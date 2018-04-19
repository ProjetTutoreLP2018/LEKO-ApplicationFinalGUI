using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Xceed.Words.NET;
using WindowsFormsApp1.Model;
using LettreCooperation.modele;
using System.IO;
using LettreCooperation;

namespace Lot2_PartieLC
{
	public partial class FenGenerationLC : UserControl
	{

        private ModelManager modeleManager = new ModelManager();
        private List<Client> clients = new List<Client>();
        private List<Modele> modeles = new List<Modele>();
        private string _PATH = Program.FINACOOPFolder + @"\Interne\5.LC & Prospection\5.Lettres de coopération\LC à réaliser et envoyer";


		public FenGenerationLC()
		{
			InitializeComponent();
		}


		private void FenGenerationLC_Load(object sender, EventArgs e)
		{
            clients = modeleManager.GetListClient();
            modeles = modeleManager.GetModeles();

            foreach (Modele modele in modeles)
                comboBoxModel.Items.Add(modele.id_modele);

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
			string raisonSociale = ListeDeroulanteChoixClient.SelectedItem.ToString();

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


			DocX documentModele = DocX.Load(Program.FINACOOPFolder + modeles[comboBoxModel.SelectedIndex].chemin_modele + ".docx");

			foreach (var item in donnees)
			{
				documentModele.ReplaceText("{{" + item.Key + "}}", item.Value);
			}

            string pathFolder = _PATH + "\\" + client.raison_sociale;

            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
                File.SetAttributes(pathFolder, FileAttributes.Normal);

            }

            LC lc = new LC();

            lc.chemin_lc = @"\Interne\5.LC & Prospection\5.Lettres de coopération\LC à réaliser et envoyer" + "\\" + client.raison_sociale + @"\test.docx";
            lc.date_debut = DateTime.Today;
            lc.id_client = client.id_client;
            lc.id_modele = modeles[comboBoxModel.SelectedIndex].id_modele;
            lc.nom_lc = "test.docx";
            lc.id_etat = 1;
            lc.id_utilisateur = 13;

            


            documentModele.SaveAs(pathFolder + @"\test.docx");

            AfficherLC(pathFolder + @"\test.docx");

            saveLC(lc);

            MessageBox.Show("La lettre de coopération a été générée dans le fichier " + pathFolder + @"Test.docx" + ".\nAssurez-vous que la lettre de coopération générée ne contient pas d'erreurs, modifiez-la si nécessaire.", "Lettre de coopération générée", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


        private void saveLC(LC lc)
        {
            modeleManager.SaveLC(lc);
        }


        private void AfficherLC(string pathOrigine)
        {

            Microsoft.Office.Interop.Word.Application fichier = new Microsoft.Office.Interop.Word.Application();
            //  this.refFichier = fichier;

            // permet de visualisé les opérations
            fichier.Visible = true;

            // objet vide pour les parémétres inutilisés
            Object missing = System.Reflection.Missing.Value;

            // chemin du doc a ouvrir
            String path = pathOrigine;

            // ouvrir le doc word 
            fichier.Documents.Open(path, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing);



            // désactiver le bouton ouvrir et activé le bouton fermer
            // close.Enabled = true;
            // open.Enabled = false;

        }

    }
}
