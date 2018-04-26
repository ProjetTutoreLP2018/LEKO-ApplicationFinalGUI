using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LettreCooperation.modele;
using LettreCooperation.Model;

namespace LettreCooperation
{
    public partial class Voir_Modif_LC : UserControl
    {

        private ModelManager model;
        private List<LC> listLc;
        private List<Client> listClient;
        private int indexClient;
        private int indexLc;
        private int etat;
        private LC lcVisible;
        // private Microsoft.Office.Interop.Word.Application fichier = new Microsoft.Office.Interop.Word.Application();

        public Voir_Modif_LC()
        {
            InitializeComponent();
            Init();

        }

        
        /// <summary>
        /// Méthode d'initialisations
        /// </summary>
        public void Init()
        {
            labelSignataire.Text = "...";
            labelCreateur.Text = "...";
            labelDateCrea.Text = "...";
            indexClient = 0;
            indexLc = 0;
            radioButtonAttSignExp.Checked = true;
            model = new ModelManager();
            listLc = new List<LC>();
            listClient = new List<Client>();

            listClient = model.GetListClient();


            foreach (Client client in listClient)
                comboClient.Items.Add(client.raison_sociale);
        }


        /// <summary>
        /// Méthode qui permet de choisir un client
        /// et donc de remettre à jour la liste de LC a afficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateListLC();
        }


        /// <summary>
        /// Permet de mettre à jour les compteurs
        /// pour le différents status
        /// </summary>
        /// <param name="listLc"></param>
        private void UpdateNbr(List<LC> listLc)
        {

            int NbrAttenteSigne = 0;
            int nbrValidExp = 0;
            int nbrEnvoiCli = 0;
            int nbrArchive = 0;
            int nbrRefus = 0;

            foreach(LC lc in listLc)
            {
                if (lc.id_etat == 1)
                    NbrAttenteSigne++;
                if (lc.id_etat == 7)
                    nbrValidExp++;
                if (lc.id_etat == 8)
                    nbrEnvoiCli++;
                if (lc.id_etat == 10)
                    nbrArchive++;
                if (lc.id_etat == 11)
                    nbrRefus++;

            }

            labelNbrAttenteSigne.Text = "( " + NbrAttenteSigne + " )";
            labelNbrSigneExp.Text = "( " + nbrValidExp + " )";
            labelNbrEnvoieCli.Text = "( " + nbrEnvoiCli + " )";
            labelNbrArchive.Text = "( " + nbrArchive + " )";
            labelNbrRefus.Text = "( " + nbrRefus + " )";

        }



        /// <summary>
        /// Méthode qui permet de mettre à jour la liste
        /// de LC en fonction du client séléctionné
        /// </summary>
        private void UpdateListLC()
        {
            this.indexClient = comboClient.SelectedIndex;
            comboLC.Items.Clear();
            comboLC.ResetText();
          

            if (listClient == null || indexClient < 0)
                return;

            this.listLc = model.GestLcFromClient(listClient[indexClient].id_client);

            RadioButtonManager();

            foreach (LC lc in listLc)
            {
                if (lc.id_etat == etat)
                    comboLC.Items.Add(lc.nom_lc);
            }

            UpdateNbr(this.listLc);
        }


        /// <summary>
        /// Méthode qui permet de manager les radio
        /// bouttons de filtre de status de LC
        /// </summary>
        private void RadioButtonManager()
        {
            if (radioButtonAttSignExp.Checked)
            {
                this.etat = 1;
                buttonSupprimer.Enabled = true;
                buttonSupprimer.BackColor = Color.Red;
            }
            else if (radioButtonSignerExp.Checked)
            {
                this.etat = 7;
                buttonSupprimer.Enabled = false;
                buttonSupprimer.BackColor = Color.Silver;

                if (PagePrincipale.Utilisateur.id_droit == 2 || PagePrincipale.Utilisateur.isAdmin)
                {
                    buttonSupprimer.Enabled = true;
                    buttonSupprimer.BackColor = Color.Red;
                }
                else
                {
                    buttonSupprimer.Enabled = false;
                    buttonSupprimer.BackColor = Color.Silver;
                }
            }

            else if (radioButtonEnvoieCli.Checked)
            {
                this.etat = 8;

                if (PagePrincipale.Utilisateur.isAdmin)
                {
                    buttonSupprimer.Enabled = true;
                    buttonSupprimer.BackColor = Color.Red;
                }
                else
                {
                    buttonSupprimer.Enabled = false;
                    buttonSupprimer.BackColor = Color.Silver;
                }
            }

            else if (radioButtonArchive.Checked)
            {
                this.etat = 10;

                if (PagePrincipale.Utilisateur.isAdmin)
                {
                    buttonSupprimer.Enabled = true;
                    buttonSupprimer.BackColor = Color.Red;
                }
                else
                {
                    buttonSupprimer.Enabled = false;
                    buttonSupprimer.BackColor = Color.Silver;
                }
            }

            else
            {
                this.etat = 11;
                buttonSupprimer.Enabled = true;
            }
        }


        /// <summary>
        /// Méthode qui permet d'affichier la LC séléctionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAfficher_Click(object sender, EventArgs e)
        {

            if (radioButtonArchive.Checked)
            {
                AfficherPDF afficherPDF = new AfficherPDF();
                afficherPDF.Initialiser(Program.FINACOOPFolder + lcVisible.chemin_lc);
                afficherPDF.Show();
            } else
            {
                WaitForm waitForm = new WaitForm();

                try
                {
                    AfficherLC(Program.FINACOOPFolder + lcVisible.chemin_lc);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le fichier est introuvable. Il a peut-être été supprimé" +
                        " ou déplacé.");

                    WordTools.CloseWord();
                }

                waitForm.Close();
            }

        }


        /// <summary>
        /// Méthode qui permet de gérer le fichier Word
        /// </summary>
        /// <param name="pathOrigine"></param>
        private void AfficherLC(string pathOrigine)
        {

            WordTools.Path = pathOrigine;
            WordTools.OpenWord();

        }


        /// <summary>
        /// Méthode qui permet de remmetre à jour les information
        /// de la LC dans les champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.indexLc = comboLC.SelectedIndex;

            this.lcVisible = model.GetListLCByName(comboLC.Text);

            labelDateCrea.Text = lcVisible.date_debut.ToString();

            Etat etat = model.GetEtat(lcVisible.id_etat);

            Utilisateur dechiffreuse = model.GetUser(lcVisible.id_utilisateur);

           
            if (lcVisible.id_signataire != null)
            {
                Utilisateur signataire = model.GetUser(lcVisible.id_signataire);
                labelSignataire.Text = signataire.nom_utilisateur + " " +
                    signataire.prenom_utilisateur;
            }
                

            
            labelCreateur.Text = dechiffreuse.nom_utilisateur + " " +
            dechiffreuse.prenom_utilisateur;
            


            if (etat.libelle_etat.Equals("C"))
                labelStatus.Text = "En attente de validation comptable";
            if (etat.libelle_etat.Equals("AC"))
                labelStatus.Text = "En attente de signature du client";
            if (etat.libelle_etat.Equals("S"))
                labelStatus.Text = "Signée par le client";
            if (etat.libelle_etat.Equals("A"))
                labelStatus.Text = "Archivée";
            if (etat.libelle_etat.Equals("R"))
                labelStatus.Text = "Refus du client";
            if (etat.libelle_etat.Equals("SE"))
                labelStatus.Text = "Signée par l'expert-comptable";
        }


        private void RadioButtonAttSignExp_CheckedChanged(object sender, EventArgs e)
        {

            UpdateListLC();
        }


        private void RadioButtonSignerExp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListLC();
        }


        private void RadioButtonEnvoieCli_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListLC();
        }

        private void RadioButtonArchive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListLC();
        }


        private void RadioButtonRefus_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListLC();
        }


        /// <summary>
        /// Méthode qui permet de suprimer une LC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer definitivement cette Lettre de coopération ?",
                "Êtes vous sûr?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;


            if (File.Exists(Program.FINACOOPFolder + lcVisible.chemin_lc))
            File.Delete(Program.FINACOOPFolder + lcVisible.chemin_lc);
            else
                MessageBox.Show("Le Fichier n'existe pas");

            model.DeleteLC(lcVisible);

            MessageBox.Show("Votre LC a bien était supprimer");
            Init();
        }
    }
}
