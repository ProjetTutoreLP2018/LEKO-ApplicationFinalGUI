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
                // Properties.Settings.Default.PathFINACOOP = String.Empty;
                //==================================================

                

                if (String.IsNullOrEmpty(Properties.Settings.Default.PathFINACOOP))
                {
                    
                    while (String.IsNullOrEmpty(Properties.Settings.Default.PathFINACOOP) && !QuitApp)
                    {
                        ChoosePath choosePath = new ChoosePath();
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
                    Application.Run(new PagePrincipale());

            } catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet.");
            }
        }
    }
}
