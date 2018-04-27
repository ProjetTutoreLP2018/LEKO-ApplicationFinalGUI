using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Xceed.Words.NET;
using LettreCooperation.Model;
using LettreCooperation.modele;
using System.IO;
using ExcelDataReader;

namespace LettreCooperation
{
	public partial class Page_CreationDeLc : UserControl
	{

        private ModelManager modeleManager = new ModelManager();
        private List<Client> clients = new List<Client>();
        private List<Modele> modeles = new List<Modele>();


		public Page_CreationDeLc()
		{
			InitializeComponent();
		}


		private void FenGenerationLC_Load(object sender, EventArgs e)
		{
            clients = modeleManager.GetListClient();
            
            if(clients == null)
                return;

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
			
            ouvrirFichierValoHonoraires.Filter = "Fichiers .xlsx|*.xlsx";
            ouvrirFichierValoHonoraires.ShowDialog(this);

            if (ouvrirFichierValoHonoraires.SafeFileName.Length == 0)
            {
                MessageBox.Show("Vous n'avez pas renseigné de fichier");
                return;
            }

            FichierValoHonoraires.Text = ouvrirFichierValoHonoraires.FileName;

        }


        
		private void BoutonGenerer_Click(object sender, EventArgs e)
		{
            Cursor.Current = Cursors.WaitCursor;
            if (FichierValoHonoraires.Text.Length == 0)
            {
                MessageBox.Show("Merci de choisir un fichier d'honoraire.");
                Cursor.Current = Cursors.Default;
                return;
            }


            PopUp_Patienter waitForm = new PopUp_Patienter();
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
                { "Activite", client.activite },
                { "ExerciceSocial", ((DateTime) client.exercice_debut).ToString("yyyy_MM_dd") +
                "  -  " + ((DateTime) client.exercice_fin).ToString("yyyy_MM_dd") },
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


            try { 
                using (var stream = File.Open(FichierValoHonoraires.Text, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet();

                        var spreadsheet = result.Tables[2];



                        for (int i = 0; i < spreadsheet.Rows.Count; i++)
                        {
                            for (int j = 0; j < spreadsheet.Columns.Count; j++)
                            {

                                if ((spreadsheet.Rows[i][j].ToString()).Contains("{{"))
                                {
                                    String chaine = spreadsheet.Rows[i][j].ToString();
                                    String[] cutChaine = chaine.Split(new[] { "{{", "}}" }, StringSplitOptions.RemoveEmptyEntries);
                                    chaine = cutChaine[0];
                                    donnees.Add(chaine, spreadsheet.Rows[i - 1][j].ToString());
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de chargement. Merci de vérifier que vous avez renseigner le bon fichier FINACOOP");
                Cursor.Current = Cursors.Default;
            }



            try
            {
                using (DocX documentModele = DocX.Load(Program.FINACOOPFolder + modeles[comboBoxModel.SelectedIndex].chemin_modele + ".docx"))
                {

                    foreach (var item in donnees)
                    {
                        documentModele.ReplaceText("{{" + item.Key + "}}", item.Value);
                    }

                    string pathFolder = Program.FINACOOPFolder + Properties.Settings.Default.PathRealiser + client.raison_sociale;

                    if (!Directory.Exists(pathFolder))
                    {
                        Directory.CreateDirectory(pathFolder);
                        File.SetAttributes(pathFolder, FileAttributes.Normal);

                    }

                    LC lc = new LC
                    {
                        chemin_lc = Properties.Settings.Default.PathRealiser + client.raison_sociale + @"\" + nomFichier,
                        date_debut = DateTime.Today,
                        id_client = client.id_client,
                        id_modele = modeles[comboBoxModel.SelectedIndex].id_modele,
                        nom_lc = nomFichier,
                        id_etat = 1,
                        id_utilisateur = Page_Principale.Utilisateur.id_utilisateur
                    };


                    if (File.Exists(pathFolder + @"\" + nomFichier))
                    {
                        string message = "Cette LC existe déjà, voulez-vous l'écraser ?";
                        string caption = "Lettre de coopération existant";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, caption, buttons);

                        if (result == DialogResult.No)
                        {
                            waitForm.Close();
                            Cursor.Current = Cursors.Default;
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
            catch (Exception)
            {
                MessageBox.Show("Erreur de chargement. Merci de vérifier que vous avez renseigner le bon fichier FINACOOP");
                Cursor.Current = Cursors.Default;
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
