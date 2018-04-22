using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LettreCooperation;
using LettreCooperation.modele;
using Microsoft.Office.Interop.Word;
using WindowsFormsApp1.Model;
using Xceed.Words.NET;

namespace WindowsFormsApp1
{
    public partial class SignatureExp : UserControl
    {

        private ModelManager modelManager = new ModelManager();
        private List<LC> listLc = new List<LC>();
        private string file2 = "";
      //  private const string _PATHLCENVOYE = @"\Interne\5.LC & Prospection\5.Lettres de coopération\LC envoyées\";


        public SignatureExp()
        {
            InitializeComponent();
            Init();
            this.textBoxPass.PasswordChar = '•';
        }

        private void Init()
        {


            LCDataGridView.Rows.Clear();
            LCDataGridView.Refresh();
            listLc = modelManager.GetListLcASigner();
            foreach (var item in listLc)
            {
                if (item.id_etat == 1)
                {
                    String[] row = {
                        item.nom_lc ,
                        modelManager.FindClient(item.id_client).raison_sociale,
                        item.date_debut + "",
                        modelManager.FindUtilisateur(item.id_utilisateur).nom_utilisateur + " " + modelManager.FindUtilisateur(item.id_utilisateur).prenom_utilisateur};
                    LCDataGridView.Rows.Add(row);
                }

            }

        }

        private void ButtonSigner_Click(object sender, EventArgs e)
        {


            if (!textBoxPass.Text.Equals(PagePrincipale.Utilisateur.mdp_utilisateur))
            {
                MessageBox.Show("Votre mot de passe est incorrecte");
                return;
            }



            for (int i = 0; i < LCDataGridView.RowCount; ++i)
            {
                DataGridViewCheckBoxCell chkchecking = LCDataGridView.Rows[i].Cells[4] as DataGridViewCheckBoxCell;


                //MessageBox.Show(chkchecking.Value.ToString());

                if (chkchecking.Value != null && (bool)chkchecking.Value)
                {



                    var app = new Microsoft.Office.Interop.Word.Application();
                    
                     try
                     {
                        //ouverture du document

                        // MessageBox.Show(Program.FINACOOPFolder + listLc[i].chemin_lc);

                        var doc = app.Documents.Add(
                            Program.FINACOOPFolder + listLc[i].chemin_lc,
                            Visible: false);

                        doc.Activate();

                        //récuperation du mot a remplacer
                        //************************************************
                        var motcle = "signature";
                        // MessageBox.Show("Remplacement du mot: " + motcle + " ...");
                        var sel = app.Selection;
                        sel.Find.Text = string.Format("[" + motcle + "]");
                        sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                        sel.Range.Select();

                        //Insertion de l'image 
                        // var imgPath = Path.GetFullPath(string.Format(file2));
                        System.Drawing.Image imgPath = ByteArrayToImage(PagePrincipale.Utilisateur.image_Blob_Signature);
                        imgPath.Save(Program.FINACOOPFolder + @"\signature.png");

                        sel.InlineShapes.AddPicture(
                            FileName: Program.FINACOOPFolder + @"\signature.png",
                            LinkToFile: false,
                            SaveWithDocument: true);

                        File.Delete(Program.FINACOOPFolder + @"\signature.png");

                        //************************************************

                        //sauvegarde du doc.
                        modelManager.ChangerEtatLC_Signer(listLc[i].id_lc);
                        modelManager.AjoutSignataire(listLc[i], PagePrincipale.Utilisateur);
                        doc.SaveAs(Program.FINACOOPFolder + listLc[i].chemin_lc);
                        doc.Close();

                        AjoutNomSignataire(Program.FINACOOPFolder + listLc[i].chemin_lc);
                        MessageBox.Show("Votre fichier a bien était signée");

                    }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }

            }

            Init();
        }


        private void AjoutNomSignataire(String path)
        {
            DocX documentModele = DocX.Load(path);
            documentModele.ReplaceText("{{PrenomEComptable}}", PagePrincipale.Utilisateur.prenom_utilisateur);
            documentModele.ReplaceText("{{NomEComptable}}", PagePrincipale.Utilisateur.nom_utilisateur);
            documentModele.SaveAs(path);
        }


        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBoxPass.Text))
                this.button1.Enabled = true;
            else
                this.button1.Enabled = false;
        }


        public System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
