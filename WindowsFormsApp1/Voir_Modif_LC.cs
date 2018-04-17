using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LettreCooperation.modele;
using WindowsFormsApp1.Model;

namespace LettreCooperation
{
    public partial class Voir_Modif_LC : UserControl
    {

        private ModelManager model;
        private List<LC> listLc;
        private List<Client> listClient;
        private int indexClient;
        private int indexLc;

        public Voir_Modif_LC()
        {
            InitializeComponent();

        }

        
        public void Init()
        {

            indexClient = 0;
            indexLc = 0;
            model = new ModelManager();
            listLc = new List<LC>();
            listClient = new List<Client>();


            listClient = model.GetListClient();
            //  listLc = model.GetListLc();


            foreach (Client client in listClient)
                comboClient.Items.Add(client.raison_sociale);
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();

        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indexClient = comboClient.SelectedIndex;
            comboLC.Items.Clear();

            listLc =  model.GestLcFromClient(listClient[indexClient].id_client);

            foreach (LC lc in listLc)
                comboLC.Items.Add(lc.nom_lc);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(listLc[indexLc].chemin_lc);
            AfficherLC(listLc[indexLc].chemin_lc);
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


        }


        private void comboLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indexLc = comboLC.SelectedIndex;
            labelDateCrea.Text = listLc[indexLc].date_debut.ToString();

            Etat etat = model.GetStatut(listLc[indexLc].id_etat);

            Utilisateur utilisateur = model.GetUser(listLc[indexLc].id_utilisateur);

            labelCreateur.Text = utilisateur.nom_utilisateur + " " +
                utilisateur.prenom_utilisateur;

            if (etat.libelle_etat.Equals("C"))
                labelStatus.Text = "En attente de validation comptable";
            if (etat.libelle_etat.Equals("ATCL"))
                labelStatus.Text = "En attente de signature du client";
            if (etat.libelle_etat.Equals("S"))
                labelStatus.Text = "Signée par le client";
            if (etat.libelle_etat.Equals("A"))
                labelStatus.Text = "Archivée";
            if (etat.libelle_etat.Equals("R"))
                labelStatus.Text = "Refus du client";
        }
    }
}
