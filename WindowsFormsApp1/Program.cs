using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new pagePrincipale());

            } catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet.");
            }
        }
    }
}
