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
                // Properties.Settings.Default.PathFINACOOP = "null";
                // Properties.Settings.Default.Save();
                //==================================================

               // MessageBox.Show(Properties.Settings.Default.PathFINACOOP);

                if (Properties.Settings.Default.PathFINACOOP.Equals("null"))
                {
                                    
                    PopUp_ChoixDossierFINACOOP choosePath = new PopUp_ChoixDossierFINACOOP();
                    Application.Run(choosePath);

                }
                
                FINACOOPFolder = Properties.Settings.Default.PathFINACOOP;

                if(!QuitApp)
                    Application.Run(new Page_Principale());

            } catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Vous n'êtes pas connecté à la base de données. Merci" +
                    "de vérifier votre connexion internet ou de vérifier que le port 1433 de votre Box est bien ouvert.");
            }
        }
    }
}
