using EASendMail;
using LettreCooperation;
using LettreCooperation.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class EnvoieLcAuClient : UserControl
    {

        private ModelManager modelManager = new ModelManager();
        private List<LC> listLc;

        public EnvoieLcAuClient()
        {
            InitializeComponent();

            Init();
        }


        /// <summary>
        /// Méthode d'initialisation du tableau
        /// </summary>
        private void Init()
        {


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
        /// Méthode qui permet de valider l'envoir
        /// au clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnvoyer_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                DataGridViewCheckBoxCell chkchecking = dataGridView.Rows[i].Cells[5] as DataGridViewCheckBoxCell;

                //MessageBox.Show(chkchecking.Value.ToString());

                if (chkchecking.Value != null && (bool)chkchecking.Value)
                {

                    // Demander le mot de passe à l'utilisateur

                    SendMailClient(listLc[i], "");
                    ChangeEtat(listLc[i]);
                }
            }

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            Init();
        }


        /// <summary>
        /// Méthode qui permet l'enoie par mail
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="password"></param>
        private void SendMailClient(LC lc, string password)
        {
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            Client client = modelManager.FindClient(lc.id_client);

            // Your gmail email address
            string from = "kevin.dupeyrat@gmail.com";
            oMail.From = from;

            //Password du type
            string pass = "@Gmail.com77";

            // Set recipient email address
            string to = client.mail_referent;
            oMail.To = to;

            // Set email subject
            string title = "Voici votre LC";
            oMail.Subject = title;

            // Set email body
            string content = "Bonjour Voici votre LC !";
            oMail.TextBody = content;

            //Test PJ
            string pj = Program.FINACOOPFolder + lc.chemin_lc;
            if (!pj.Equals(""))
                oMail.AddAttachment(pj);

            //
            // PROPERTIES /!\
            //
            string smtp;
            smtp = "smtp.gmail.com";
            SmtpServer oServer = new SmtpServer(smtp);

            // Set 587 port, if you want to use 25 port, please change 587 5o 25
            //
            // On peut éventuellement le mettre en properties aussi plutôt qu'en brut afin de s'adapter aux changements sur leur SMTP /!\
            //
            oServer.Port = 587;

            // detect SSL/TLS automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            // Gmail user authentication
            // For example: your email is "gmailid@gmail.com", then the user should be the same
            oServer.User = from;
            oServer.Password = pass;
            //Console.WriteLine("start to send email over SSL ...");
            try
            {
                oSmtp.SendMail(oServer, oMail);
                MessageBox.Show("Votre mail a bien été envoyé à l'adresse : " + to, "Message envoyé");
              
            }
            catch (Exception ep)
            {
                MessageBox.Show("Problème lors de l'envoi du message : " + ep.StackTrace, "Erreur : Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }
    }
}
