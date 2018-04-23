using System;
using System.Windows;

namespace LettreCooperation
{
    class WordTools
    {

        public static Microsoft.Office.Interop.Word.Application FichierWord { get; set; }
        public static string Path { get; set; }


        /// <summary>
        /// Méthode qui permet d'ouvrir un document
        /// Word
        /// </summary>
        public static void OpenWord()
        {
            CloseWord();

            FichierWord = new Microsoft.Office.Interop.Word.Application
            {
                Visible = true
            };

            // objet vide pour les parémétres inutilisés
            Object missing = System.Reflection.Missing.Value;

            // ouvrir le doc word 
            FichierWord.Documents.Open(Path, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing);
        }


        /// <summary>
        /// Méthode qui permet de fermer
        /// proprement tous les documents Word
        /// en exécution
        /// </summary>
        public static void CloseWord()
        {

            if (FichierWord == null)
                return;

            try
            {
                FichierWord.Documents.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges, Path, null);
                FichierWord.Quit();
            }
            catch (Exception)
            { }
            finally
            {
                
                System.Runtime.InteropServices.
                    Marshal.ReleaseComObject(FichierWord);
                FichierWord = null;
            }
        }
    }
}
