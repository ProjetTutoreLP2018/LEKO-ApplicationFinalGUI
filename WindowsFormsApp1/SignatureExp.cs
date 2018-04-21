using System;
using System.Collections.Generic;
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

            OpenFileDialog openFile2 = new OpenFileDialog();
            openFile2.Filter = "Image Files|*.png;*.jpg;*.gif;";
            openFile2.DefaultExt = "png";
            openFile2.ShowDialog();
            this.file2 = openFile2.FileName;



            //throw new NotImplementedException();
            string txt = "";
            for (int i = 0; i < LCDataGridView.RowCount; ++i)
            {
                DataGridViewCheckBoxCell chkchecking = LCDataGridView.Rows[i].Cells[4] as DataGridViewCheckBoxCell;


                //MessageBox.Show(chkchecking.Value.ToString());

                if (chkchecking.Value != null && (bool)chkchecking.Value)
                {



                    var app = new Microsoft.Office.Interop.Word.Application();
                    /*
                     try
                     {*/
                    //ouverture du document

                    MessageBox.Show(Program.FINACOOPFolder + listLc[i].chemin_lc);

                    var doc = app.Documents.Add(
                        Program.FINACOOPFolder + listLc[i].chemin_lc,
                        Visible: false);

                    doc.Activate();

                    //récuperation du mot a remplacer
                    //************************************************
                    var motcle = "signature";
                    MessageBox.Show("Remplacement du mot: " + motcle + " ...");
                    var sel = app.Selection;
                    sel.Find.Text = string.Format("[" + motcle + "]");
                    sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                    sel.Range.Select();

                    //Insertion de l'image 
                    var imgPath = Path.GetFullPath(string.Format(file2));

                    sel.InlineShapes.AddPicture(
                        FileName: imgPath,
                        LinkToFile: false,
                        SaveWithDocument: true);
                    //************************************************

                    //sauvegarde du doc.
                    modelManager.ChangerEtatLC_Signer(listLc[i].id_lc);
                    modelManager.AjoutSignataire(listLc[i], PagePrincipale.Utilisateur);
                    doc.SaveAs(Program.FINACOOPFolder + listLc[i].chemin_lc);
                    doc.Close();

                    AjoutNomSignataire(Program.FINACOOPFolder + listLc[i].chemin_lc);

                        /*}
                        catch (Exception ex)
                        {
                            MessageBox.Show(Program.FINACOOPFolder + fileName);
                            MessageBox.Show(ex.Message);
                        }*/
                        
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
