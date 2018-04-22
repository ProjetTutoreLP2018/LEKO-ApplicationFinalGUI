using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class FenPreRemplissageAutomatique : Form
    {
        private SIRENE entreprises;
        public Record entrepriseSelectionnee;
        public FenPreRemplissageAutomatique()
        {
            InitializeComponent();
        }

        private void FenSelectionEntreprise_Load(object sender, EventArgs e)
        {
            
        }

        private async void MotsCles_KeyDownAsync(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage reponse = await client.GetAsync("https://data.opendatasoft.com/api/records/1.0/search/?dataset=sirene%40public&q=" + MotsCles.Text.ToUpper() + "&facet=depet&facet=libcom&facet=siege&facet=libapet&facet=libnj&facet=libapen&facet=ess&facet=libtefen&facet=categorie&facet=nom_dept&facet=section");
                string json = await reponse.Content.ReadAsStringAsync();
                this.entreprises = JsonConvert.DeserializeObject<SIRENE>(json);
                int nombreEntreprises = this.entreprises.nhits;
                if (nombreEntreprises > 10)
                {
                    MessageBox.Show("Votre requête " + MotsCles.Text + " donne " + nombreEntreprises + " résultats.\nVeuillez modifier vos mots-clés ou rajouter.");
                } else
                {
                    foreach(Record enregistrement in this.entreprises.records)
                    {
                        string nom = enregistrement.fields.l1_normalisee;
                        string adresse = enregistrement.fields.l4_normalisee;
                        string codePostal = enregistrement.fields.codpos;
                        string ville = enregistrement.fields.libcom;
                        ListeChoixEntreprises.Items.Add(String.Format("{0} ({1} - {2} {3})", nom, adresse, codePostal, ville));
                    }
                }
            }
        }

        private void ListeChoixEntreprises_DoubleClick(object sender, EventArgs e)
        {
            if(ListeChoixEntreprises.Items.Count != 0)
            {
                this.entrepriseSelectionnee = this.entreprises.records[ListeChoixEntreprises.SelectedIndex];
                DialogResult = DialogResult.OK;
            }
        }

        private async void BoutonRechercher_ClickAsync(object sender, EventArgs e)
        {
            ListeChoixEntreprises.Items.Clear();
            HttpClient client = new HttpClient();
            HttpResponseMessage reponse = await client.GetAsync("https://data.opendatasoft.com/api/records/1.0/search/?dataset=sirene%40public&q=" + MotsCles.Text.ToUpper() + "&facet=depet&facet=libcom&facet=siege&facet=libapet&facet=libnj&facet=libapen&facet=ess&facet=libtefen&facet=categorie&facet=nom_dept&facet=section");
            string json = await reponse.Content.ReadAsStringAsync();
            this.entreprises = JsonConvert.DeserializeObject<SIRENE>(json);
            int nombreEntreprises = this.entreprises.nhits;
            if (nombreEntreprises > 10)
            {
                MessageBox.Show("Votre requête " + MotsCles.Text + " donne " + nombreEntreprises + " résultats.\nVeuillez modifier vos mots-clés ou rajouter.");
            }
            else
            {
                foreach (Record enregistrement in this.entreprises.records)
                {
                    string nom = enregistrement.fields.l1_normalisee;
                    string adresse = enregistrement.fields.l4_normalisee;
                    string codePostal = enregistrement.fields.codpos;
                    string ville = enregistrement.fields.libcom;
                    ListeChoixEntreprises.Items.Add(String.Format("{0} ({1} - {2} {3})", nom, adresse, codePostal, ville));
                }
            }
        }
    }
}
