using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using Xceed.Words.NET;
using System.Net.Http;
using Newtonsoft.Json;
using LettreCooperation;
using LettreCooperation.modele;

namespace lot1
{
    public partial class FenFormulaireGenerationLC : UserControl
    {

        // objet vide pour les parémétres inutilisés
        private Object missing = System.Reflection.Missing.Value;
        private ModelManager model;
        private string pathFolder = Program.FINACOOPFolder;


        public FenFormulaireGenerationLC()
        {
            InitializeComponent();
            DateCourante.Value = DateTime.Now;
        }


        /// <summary>
        /// Méthode qui permet de générer la Ville
        /// en fonction du code postal entré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CP_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CP.Text))
            {
                Ville.Items.Clear();
            }

            if (CP.Text.Length == 5)
            {
                int codePostal;
                try
                {
                    codePostal = Int32.Parse(CP.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le code postal doit être constitué de 5 chiffres", "Code postal incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                HttpClient client = new HttpClient();
                HttpResponseMessage reponse = await client.GetAsync("https://geo.api.gouv.fr/communes?codePostal=" + codePostal);
                string json = await reponse.Content.ReadAsStringAsync();
                if (!String.IsNullOrEmpty(json))
                {
                    List<Ville> listeVilles = JsonConvert.DeserializeObject<List<Ville>>(json);
                    foreach (var item in listeVilles)
                    {
                        Ville.Items.Add(item.nom.ToUpper());
                    }
                    Ville.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Le code postal entré semble ne correspondre à aucune ville. \nAssurez-vous que le code postal est valide.", "Code postal incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Affiche une fenêtre modale de sélection du modèle et du fichier de destination puis génère la lettre de coopération
        /// </summary>
        private void GenererLC()
        {
            FenGenerationLC fenGenerationLC = new FenGenerationLC();
            if (fenGenerationLC.ShowDialog(this) == DialogResult.OK)
            {
                using (DocX document = DocX.Load(@fenGenerationLC.ModeleSelectionne))
                {
                    Dictionary<string, string> valeurs = new Dictionary<string, string>();
                    valeurs["RaisonSociale"] = RaisonSociale.Text;
                    valeurs["Adresse"] = Adresse.Text;
                    valeurs["CP"] = CP.Text;
                    valeurs["FormeJuridique"] = FormeJuridique.Text;
                    valeurs["Fonction"] = Fonction.Text;
                    valeurs["Ville"] = Ville.Text;
                    valeurs["DateCourante"] = DateCourante.Text;
                    valeurs["Prenom"] = Prenom.Text;
                    valeurs["Nom"] = Nom.Text;
                    valeurs["CA"] = CA.Text;
                    valeurs["Effectif"] = Effectif.Text;
                    valeurs["OrganisationComptable"] = OrganisationComptable.Text;
                    valeurs["VolumesAnnuels"] = VolumesAnnuels.Text;
                    valeurs["LieuImmatriculation"] = LieuImmatriculation.Text;
                    valeurs["LeveeFinancement"] = LeveeFinancement.Text;
                    valeurs["PeriodeAFinancer"] = PeriodeAFinancer.Text;
                    valeurs["ProjetAFinancer"] = ProjetAFinancer.Text;
                    valeurs["ExerciceSocial"] = ExerciceSocial.Text;
                    valeurs["ProduitExploitationEstime"] = produitExploitationEstime.Text;
                    valeurs["Millesime"] = Millesime.Text;
                    valeurs["DateImmatriculation"] = DateImmatriculation.Text;
                    valeurs["Activite"] = Activite.Text;

                    if (Monsieur.Checked)
                    {
                        valeurs["Civilite"] = "Monsieur";
                        valeurs["CherGenre"] = "Cher";
                    }
                    else
                    {
                        valeurs["CherGenre"] = "Chère";
                        valeurs["Civilite"] = "Madame";
                    }

                    foreach (var item in valeurs)
                    {
                        document.ReplaceText("{{" + item.Key + "}}", (String.IsNullOrWhiteSpace(item.Value) ? item.Key : item.Value));
                    }


                    fenGenerationLC.DestinationSelectionnee += RaisonSociale.Text;
                    pathFolder += @fenGenerationLC.DestinationSelectionnee;

                    if (!Directory.Exists(pathFolder))
                    {
                        Directory.CreateDirectory(pathFolder);
                        File.SetAttributes(pathFolder, FileAttributes.Normal);

                    }
                        

                    document.SaveAs(pathFolder + @"\test.docx");
                    
                    AfficherLC(pathFolder + @"\test.docx");

                    MessageBox.Show("La lettre de coopération a été générée dans le fichier " + pathFolder, "Lettre de coopération générée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Récupère les valeurs provenant du fichier client et les affiche dans les champs appropriés
        /// </summary>
        private void ChargerDonnees()
        {
            if (ouvrirSourceDonnees.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(@ouvrirSourceDonnees.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet();
                        var spreadsheet = result.Tables[0];
                        for (int i = 0; i < spreadsheet.Columns.Count; i++)
                        {

                            if (spreadsheet.Rows[1][2].ToString() == "Monsieur")
                            {
                                Monsieur.Checked = true;
                            }
                            else if (spreadsheet.Rows[1][2].ToString() == "Madame")
                            {
                                Madame.Checked = true;
                            }

                            Millesime.Text = spreadsheet.Rows[1][1].ToString();
                            Nom.Text = spreadsheet.Rows[1][3].ToString();
                            Prenom.Text = spreadsheet.Rows[1][4].ToString();
                            Fonction.Text = spreadsheet.Rows[1][5].ToString();
                            CA.Text = spreadsheet.Rows[1][6].ToString();
                            Effectif.Text = spreadsheet.Rows[1][7].ToString();
                            OrganisationComptable.Text = spreadsheet.Rows[1][8].ToString();
                            VolumesAnnuels.Text = spreadsheet.Rows[1][9].ToString();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenererLC();
            Panel panel = (Panel)this.Parent.Controls.Find("mainPanel", false)[0];
            panel.Controls.Clear(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChargerDonnees();
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
