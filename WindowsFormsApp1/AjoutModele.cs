using LettreCooperation.modele;
using System;
using System.IO;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class AjoutModele : Form
    {
        private string pathSource;
        private string pathDestination = Program.FINACOOPFolder + @"\Interne\5.LC & Prospection\5.Lettres de coopération\Modèles LC\";
        private string nomFichier;
        private string nomMission;
        private string typeLettre;
        private ModelManager modeleManager = new ModelManager();

        public AjoutModele()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimmentions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.adresseFichier.Enabled = false;
            this.Ajouter.Enabled = false;
            this.textBoxNomFichier.Enabled = false;
            this.textBoxNomMision.Enabled = false;
            this.comboBox1.Enabled = false;
           
        }

        //Fonction pour ajouter un modele de LC
        private void Ajouter_Click(object sender, EventArgs e) {


            if (textBoxNomFichier.TextLength == 0)
            {
                MessageBox.Show("Vous devez saisir un nom de fichier");
                return;
            }
            else this.nomFichier = this.textBoxNomFichier.Text;

            if (textBoxNomMision.TextLength == 0)
            {
                MessageBox.Show("Vous devez donner un nom de mission");
                return;
            }
            else this.nomMission = this.textBoxNomMision.Text;

            this.typeLettre = this.comboBox1.SelectedItem.ToString();


            string[] files = Directory.GetFiles(this.pathDestination);
            bool nomUtilise = false;
            

            foreach (string file in files)
            {
                if (Path.GetFileName(file).Equals(this.nomFichier))
                {
                    nomUtilise = true;
                    break;
                }
            }

            if (nomUtilise)
            {
                MessageBox.Show("Nom déjà utilisé !\nVeuillez changer le nom du fichier svp");
                return;
            }


            try
            {


                // vérifier si le fichier existe dans la source
                if (File.Exists(pathSource))
                {
                    this.pathDestination += this.nomFichier + ".docx";
                    //Copier et coller le fichier
                    File.Copy(pathSource, pathDestination);
                }

                else
                {
                    MessageBox.Show("Le model LC inexistant");
                    return;
                }


            this.adresseFichier.Clear();
                
            }
            catch (Exception var)
            {
                Console.WriteLine("The process failed: {0}", var.ToString());
            }
            
            // Désactiver la bouton ajouter
            this.Ajouter.Enabled = false;

 
            this.adresseFichier.Clear();
            this.textBoxNomFichier.Clear();
            this.textBoxNomMision.Clear();


            /* Accée BDD pour sauvegarder les élements */
            modeleManager.AjouterModel(this.pathDestination, this.nomFichier, this.nomMission, this.typeLettre);

        }

       
        // Fonction pour selectionner le modele de LC à ajouter
        private void Selectionner_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
           
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Word|*.docx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;

            //Vérifier si ont a choisis un fichier
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                adresseFichier.Text = fdlg.FileName;
                this.pathSource = fdlg.FileName;
                
                this.nomFichier = Path.GetFileNameWithoutExtension(this.pathSource);
                this.textBoxNomFichier.Text = this.nomFichier;

                this.Ajouter.Enabled = true;
                this.comboBox1.Enabled = true;
                this.textBoxNomFichier.Enabled = true;
                this.textBoxNomMision.Enabled = true;
               
            }

        

        }
    }
}
    

