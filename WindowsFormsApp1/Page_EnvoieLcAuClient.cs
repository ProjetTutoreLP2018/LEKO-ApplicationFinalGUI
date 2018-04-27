using LettreCooperation.Model;
using LettreCooperation.modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using WordToPDF;

namespace LettreCooperation
{
    public partial class Page_EnvoieLcAuClient : UserControl
    {

        private ModelManager modelManager = new ModelManager();
        private List<LC> listLc;
        private string pathPDF;
        private bool envoieMail = false;

        public Page_EnvoieLcAuClient()
        {
            InitializeComponent();
            this.textBoxPass.PasswordChar = '•';
            Init();
        }


        /// <summary>
        /// Méthode d'initialisation du tableau
        /// </summary>
        private void Init()
        {

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            this.textBoxPass.Text = "";
            buttonEnvoyer.Enabled = false;
            listLc = modelManager.GetListLCWaitingSend();

            if (listLc == null)
                return;


            for (int i = 0; i < listLc.Count; i++)
            {


                string[] row = {

                    listLc[i].nom_lc,
                    modelManager.FindClient(listLc[i].id_client).raison_sociale,
                    listLc[i].date_debut.ToString(),
                    modelManager.FindUtilisateur(listLc[i].id_utilisateur).nom_utilisateur + " " 
                    + modelManager.FindUtilisateur(listLc[i].id_utilisateur).prenom_utilisateur,
                    modelManager.FindUtilisateur(listLc[i].id_signataire).nom_utilisateur + " "
                    + modelManager.FindUtilisateur(listLc[i].id_signataire).prenom_utilisateur
                };

                dataGridView.Rows.Add(row);
            }

        }


        /// <summary>
        /// Méthode qui permet de vérifier le champ du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBoxPass.Text))
                this.buttonEnvoyer.Enabled = true;
            else
                this.buttonEnvoyer.Enabled = false;
        }


        /// <summary>
        /// Méthode qui permet de valider l'envoir
        /// au clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnvoyer_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PopUp_Patienter waitForm = new PopUp_Patienter();
            waitForm.Show();

            
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell chkchecking = dataGridView.Rows[i].Cells[5] as DataGridViewCheckBoxCell;

                if (chkchecking.Value != null && (bool)chkchecking.Value)
                {
                    try
                    {
                        CopyLc(listLc[i]);
                        CreatePDF(listLc[i]);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Le fichier est introuvable. Il a peut-être été supprimé" +
                            " ou déplacé.");
                    }

                    try
                    {
                        SendMailClient(listLc[i], this.textBoxPass.Text);
                    }catch(Exception)
                    {
                        MessageBox.Show("Une erreur est survenue, l'Email n'a pas était envoyé. Merci de vérifier votre connexion internet et que le port SMTP 587 soit bien ouvert.");
                    }

                    if (envoieMail)
                    {
                        ChangeEtat(listLc[i]);
                        modelManager.UpdatePathLc(listLc[i], Properties.Settings.Default.PathEnvoyer + modelManager.FindClient(listLc[i].id_client).raison_sociale + "\\" + listLc[i].nom_lc);
                    }
                }
            }

            Init();
            Cursor.Current = Cursors.Default;
            waitForm.Close();
        }


        /// <summary>
        /// Méthode qui permet l'enoie par mail
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="password"></param>
        private void SendMailClient(LC lc, string password)
        {

            Client client = modelManager.FindClient(lc.id_client);
            MailMessage mail = new MailMessage();

            // Your gmail email address
            string from = Page_Principale.Utilisateur.email_utilisateur;
            mail.From = new MailAddress(from);

            //Password du type
            string pass = password;

            // Set recipient email address
            string to = client.mail_referent;
            mail.To.Add(to);

            // Set email body


            SmtpClient oSmtp = new SmtpClient(Properties.Settings.Default.SMTP, 587)
            {
                Credentials = new NetworkCredential(Page_Principale.Utilisateur.email_utilisateur, password),
                EnableSsl = true
            };


            Dictionary<string, string> donnees = new Dictionary<string, string>()
            {
                {"Annee", lc.date_lc.Year.ToString()},
                {"RaisonSociale", client.raison_sociale},
                {"Millesime", DateTime.Today.Year.ToString()},
                {"Prenom", client.prenom_referent}
            };

            string text = File.ReadAllText(Program.FINACOOPFolder + Properties.Settings.Default.PathModeles + "Mail_Template.txt", Encoding.UTF8);
            string[] lines = File.ReadAllLines(Program.FINACOOPFolder + Properties.Settings.Default.PathModeles + "Mail_Template.txt");
            int i = 0;
            foreach (var item in donnees)
            {
                text = text.Replace("{{" + item.Key + "}}", item.Value);
                for (i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].Replace("{{" + item.Key + "}}", item.Value);
                }
            }
            text.Replace("\n", Environment.NewLine);

            File.WriteAllText("Mail_Template.txt", text, Encoding.UTF8);

            mail.Body = text;

            // Set email subject            
            string ligneZero = lines[0];
            mail.Subject = ligneZero;


            try
            {
                //Test PJ
                string pj = Program.FINACOOPFolder + pathPDF;
                if (!pj.Equals(""))
                    mail.Attachments.Add(new Attachment(pj));
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Vous n'avez pas l'autorisation d'ouvrir ce fichier. L' Email n'est pas envoyé");
                throw;
            }


            try
            {
                oSmtp.Send(mail);
                MessageBox.Show("Votre mail a bien été envoyé à l'adresse : " + to, "Message envoyé");
                envoieMail = true;
            }
            catch (SmtpException)
            {
                MessageBox.Show("Mot de passe ou adresse Email incorrecte", "Erreur : Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Méthode qui permet le changement d'état de la LC
        /// </summary>
        /// <param name="lc"></param>
        private void ChangeEtat(LC lc)
        {
            modelManager.UpdateEtatLc(lc, 8);
        }


        /// <summary>
        /// Méthode qui permet de copier la LC
        /// dans le nouveau dossier d'attente de réponse du client
        /// </summary>
        /// <param name="lc"></param>
        private void CopyLc(LC lc)
        {
           // MessageBox.Show("Copie en cours ...");

            string dossier = Program.FINACOOPFolder + Properties.Settings.Default.PathEnvoyer + modelManager.FindClient(lc.id_client).raison_sociale;

            if (!Directory.Exists(dossier))
            {
                Directory.CreateDirectory(dossier);
                File.SetAttributes(dossier, FileAttributes.Normal);

            }

         //   MessageBox.Show("Lien du ficher a copier : " + 
          //      Program.FINACOOPFolder + lc.chemin_lc
         //       );

            File.Copy(
                Program.FINACOOPFolder + lc.chemin_lc,
                dossier + "\\" + lc.nom_lc,
                true
                );

           // MessageBox.Show("La copie a était faite.");
        }


        /// <summary>
        /// Méthode qui permet de créer le PDF que nous enverons au client
        /// </summary>
        /// <param name="lc"></param>
        private void CreatePDF(LC lc)
        {

            Word2Pdf ObjetWord = new Word2Pdf();
            string dossier = Program.FINACOOPFolder + Properties.Settings.Default.PathEnvoyer + modelManager.FindClient(lc.id_client).raison_sociale;

            if (!Directory.Exists(dossier))
            {
                Directory.CreateDirectory(dossier);
                File.SetAttributes(dossier, FileAttributes.Normal);

            }


            string nomDuFichierAConvertir = lc.nom_lc;
            object CheminDuFichier = Program.FINACOOPFolder + lc.chemin_lc;
            string ExtensionDuFichier = Path.GetExtension(nomDuFichierAConvertir);
            string ExtensionCible = nomDuFichierAConvertir.Replace(ExtensionDuFichier, ".pdf");
            if (ExtensionDuFichier == ".doc" || ExtensionDuFichier == ".docx")
            {
                object DossierCible = dossier + "\\" + ExtensionCible;
                ObjetWord.InputLocation = CheminDuFichier;
                ObjetWord.OutputLocation = DossierCible;
                ObjetWord.Word2PdfCOnversion();
            }

            
            pathPDF = Properties.Settings.Default.PathEnvoyer + modelManager.FindClient(lc.id_client).raison_sociale + "\\" + ExtensionCible;

           // MessageBox.Show("Le PDF a était créer : " + pathPDF);
        }


        /// <summary>
        /// Méthode qui permet de raffraichir le tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Init();
            Cursor.Current = Cursors.Default;
        }

        
        /// <summary>
        /// Méthode qui permet d'ouvrir un LC avant de la signer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!Page_Principale.Utilisateur.isAdmin)
                return;

            if (dataGridView.CurrentCell.ColumnIndex == 0)
                AfficherLC(Program.FINACOOPFolder + listLc[dataGridView.CurrentCell.RowIndex].chemin_lc);


        }


        /// <summary>
        /// Méthode qui permet de gérer les fichier Word
        /// </summary>
        /// <param name="pathOrigine"></param>
        private void AfficherLC(string pathOrigine)
        {

            WordTools.Path = pathOrigine;
            WordTools.OpenWord();

        }
    }
}
