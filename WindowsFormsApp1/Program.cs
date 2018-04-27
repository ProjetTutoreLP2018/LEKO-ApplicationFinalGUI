using System;
using System.Windows.Forms;

namespace LettreCooperation
{
    static class Program
    {

        public static string FINACOOPFolder { get; set; }
        public static bool QuitApp { get; set; }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            QuitApp = false;

            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // =================================================
                Properties.Settings.Default.PathFINACOOP = String.Empty;
                //==================================================

                if (Properties.Settings.Default.PathFINACOOP.Length == 0)
                {
                    
                    while (String.IsNullOrEmpty(Properties.Settings.Default.PathFINACOOP) && !QuitApp)
                    {
                        PopUp_ChoixDossierFINACOOP choosePath = new PopUp_ChoixDossierFINACOOP();
                        Application.Run(choosePath);

                        if (!String.IsNullOrEmpty(FINACOOPFolder))
                        {
                            Properties.Settings.Default.PathFINACOOP = FINACOOPFolder;
                            Properties.Settings.Default.Save();
                        } else
                        {
                            MessageBox.Show("Merci de renseigner le chemin du dossier 'FINACOOP'");
                        }
        
                    }

                } else
                {
                    FINACOOPFolder = Properties.Settings.Default.PathFINACOOP;
                }

                if(!QuitApp)
                    Application.Run(new Page_Principale());

            } catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");
            }
        }
    }
}
