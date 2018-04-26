using LettreCooperation.Model;
using LettreCooperation.modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using WordToPDF;

namespace LettreCooperation
{
    public partial class EnvoieLcAuClient : UserControl
    {

        private ModelManager modelManager = new ModelManager();
        private List<LC> listLc;
        private string pathPDF;
        private const string _PATHLCENVOYE = @"\Interne\5.LC & Prospection\5.Lettres de coopération\LC envoyées\";
        private bool envoieMail = false;

        public EnvoieLcAuClient()
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

            for(int i = 0; i < listLc.Count; i++)
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

            WaitForm waitForm = new WaitForm();
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
                        MessageBox.Show("Une erreur est survenue, l'Email n'a pas était envoyé.");
                    }
                    
                    if (envoieMail)
                        ChangeEtat(listLc[i]);
                }
            }

            Init();

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
            string from = PagePrincipale.Utilisateur.email_utilisateur;
            mail.From = new MailAddress(from);

            //Password du type
            string pass = password;

            // Set recipient email address
            string to = client.mail_referent;
            mail.To.Add(to);

            // Set email subject
            string title = "Voici votre LC";
            mail.Subject = title;

            // Set email body


            SmtpClient oSmtp = new SmtpClient(Properties.Settings.Default.SMTP, 587)
            {
                Credentials = new NetworkCredential(PagePrincipale.Utilisateur.email_utilisateur, password),
                EnableSsl = true
            };


            string body = "Voici votre LC";

            mail.Body = body;

            try
            {
                //Test PJ
                string pj = Program.FINACOOPFolder + pathPDF;
                if (!pj.Equals(""))
                    mail.Attachments.Add(new Attachment(pj));
            }
            catch (System.UnauthorizedAccessException)
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
            catch (Exception ep)
            {
                MessageBox.Show("Problème lors de l'envoi du message : Merci de vérifier votre Adresse Mail", "Erreur : Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string dossier = Program.FINACOOPFolder + _PATHLCENVOYE + modelManager.FindClient(lc.id_client).raison_sociale;

            if (!Directory.Exists(dossier))
            {
                Directory.CreateDirectory(dossier);
                File.SetAttributes(dossier, FileAttributes.Normal);

            }

            //MessageBox.Show(Program.FINACOOPFolder + lc.chemin_lc);

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
            string dossier = Program.FINACOOPFolder + _PATHLCENVOYE + modelManager.FindClient(lc.id_client).raison_sociale;

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

            modelManager.UpdatePathLc(lc, _PATHLCENVOYE + modelManager.FindClient(lc.id_client).raison_sociale + "\\" + lc.nom_lc);
            pathPDF = _PATHLCENVOYE + modelManager.FindClient(lc.id_client).raison_sociale + "\\" + ExtensionCible;

            MessageBox.Show("Le PDF a était créer : " + pathPDF);
        }


        /// <summary>
        /// Méthode qui permet de raffraichir le tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Init();
        }

        
        /// <summary>
        /// Méthode qui permet d'ouvrir un LC avant de la signer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
