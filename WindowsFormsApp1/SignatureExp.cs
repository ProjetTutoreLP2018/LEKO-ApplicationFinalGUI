using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LettreCooperation.modele;
using Microsoft.Office.Interop.Word;
using LettreCooperation.Model;
using Xceed.Words.NET;
using System.Drawing;

namespace LettreCooperation
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


        /// <summary>
        /// Initialisation de la page de signature
        /// </summary>
        private void Init()
        {


            LCDataGridView.Rows.Clear();
            LCDataGridView.Refresh();
            listLc = modelManager.GetListLcASigner();
            foreach (var item in listLc)
            {
                String[] row = {
                    item.nom_lc ,
                    modelManager.FindClient(item.id_client).raison_sociale,
                    item.date_debut + "",
                    modelManager.FindUtilisateur(item.id_utilisateur).nom_utilisateur + " " + modelManager.FindUtilisateur(item.id_utilisateur).prenom_utilisateur};
                LCDataGridView.Rows.Add(row);

                if (item.id_etat == modelManager.GetIdEtatRefuser())
                    LCDataGridView.Rows[LCDataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSalmon;
                
            }
  
        }


        /// <summary>
        /// Méthode qui permet de gérer la signature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSigner_Click(object sender, EventArgs e)
        {
           

            if (!textBoxPass.Text.Equals(PagePrincipale.Utilisateur.mdp_utilisateur))
            {
                MessageBox.Show("Votre mot de passe est incorrecte");
                return;
            }

            if (PagePrincipale.Utilisateur.image_Blob_Signature == null)
            {
                MessageBox.Show("Vous ne disposez pas de signature dans la base. Veuillez contacter l'Administrateur.");
                return;
            }

            WaitForm waitForm = new WaitForm();
            waitForm.Show();

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

                        if(listLc[i].id_etat.ToString().Equals(modelManager.GetIdEtatRefuser().ToString()))
                        {
                            if(listLc[i].id_signataire != PagePrincipale.Utilisateur.id_utilisateur)
                            {
                                MessageBox.Show("Seul le signataire originale de cette LC ou l'administrateur peut la revalider");
                            } else
                            {
                                modelManager.ChangerEtatLC_Signer(listLc[i].id_lc);
                                AfficherLC(Program.FINACOOPFolder + listLc[i].chemin_lc);
                                MessageBox.Show("Votre fichier a revalider");

                            }

                        } else
                        {
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
                            AfficherLC(Program.FINACOOPFolder + listLc[i].chemin_lc);
                            MessageBox.Show("Votre fichier a bien était signée");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                        
                }

            }

            Init();
            waitForm.Close();
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


        /// <summary>
        /// Ajout le nom du signataire sur
        /// le document
        /// </summary>
        /// <param name="path"></param>
        private void AjoutNomSignataire(String path)
        {
            DocX documentModele = DocX.Load(path);
            documentModele.ReplaceText("{{PrenomEComptable}}", PagePrincipale.Utilisateur.prenom_utilisateur);
            documentModele.ReplaceText("{{NomEComptable}}", PagePrincipale.Utilisateur.nom_utilisateur);
            documentModele.SaveAs(path);
        }


        /// <summary>
        /// Gère le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBoxPass.Text))
                this.button1.Enabled = true;
            else
                this.button1.Enabled = false;
        }


        /// <summary>
        /// Méthodeu qui permet de transformer un tableau
        /// de Byte en image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }


        /// <summary>
        /// Méthode de raffraichissement de la page
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
        private void LCDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (LCDataGridView.CurrentCell.ColumnIndex == 0)
                AfficherLC(Program.FINACOOPFolder + listLc[LCDataGridView.CurrentCell.RowIndex].chemin_lc);


        }
    }
}
