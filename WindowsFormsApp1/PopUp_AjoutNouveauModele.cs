using LettreCooperation.modele;
using System;
using System.IO;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class PopUp_AjoutNouveauModele : Form
    {
        private string pathSource;
        private string pathDestination = Properties.Settings.Default.PathModeles;
        private string nomFichier;
        private string nomMission;
        private string typeLettre;
        private ModelManager modeleManager = new ModelManager();

        public PopUp_AjoutNouveauModele()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimensions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.adresseFichier.Enabled = false;
            this.Ajouter.Enabled = false;
            this.label2.Enabled = false;
            this.textBoxNomMision.Enabled = false;
            this.comboBox1.Enabled = false;

            Init();
           
        }


        private void Init()
        {
            pathSource = string.Empty;
            pathDestination = Properties.Settings.Default.PathModeles;
            nomFichier = string.Empty;
            nomMission = string.Empty;
            typeLettre = string.Empty;
        }

        //Fonction pour ajouter un modèle de LC
        private void Ajouter_Click(object sender, EventArgs e) {

            Cursor.Current = Cursors.WaitCursor;

            if (label2.TextLength == 0)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Vous devez saisir un nom de fichier");
                return;
            }
            else this.nomFichier = this.label2.Text;

            if (textBoxNomMision.TextLength == 0)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Vous devez donner un nom de mission");
                return;
            }
            else this.nomMission = this.textBoxNomMision.Text;

            if (this.comboBox1.SelectedIndex < 0)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Merci de sélectionner un type de Modèle.");
                return;
            }

            this.typeLettre = this.comboBox1.SelectedItem.ToString();


            string[] files = Directory.GetFiles(Program.FINACOOPFolder +  this.pathDestination);
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
                Cursor.Current = Cursors.Default;
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
                    File.Copy(pathSource, Program.FINACOOPFolder +  pathDestination);
                }

                else
                {
                    MessageBox.Show("Le modèle LC est inexistant");
                    return;
                }


            this.adresseFichier.Clear();
                
            }
            catch (Exception var)
            {
                Cursor.Current = Cursors.Default;
                Console.WriteLine("The process failed: {0}", var.ToString());
            }
            
            // Désactiver le bouton ajouter
            this.Ajouter.Enabled = false;

 
            this.adresseFichier.Clear();
            this.label2.Clear();
            this.textBoxNomMision.Clear();


            /* Accès BDD pour sauvegarder les élements */
            modeleManager.AjouterModel(this.pathDestination, this.nomFichier, this.nomMission, this.typeLettre);

            Init();

            Cursor.Current = Cursors.Default;
        }

       
        // Fonction pour sélectionner le modèle de LC à ajouter
        private void Selectionner_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
           
            //fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Word|*.docx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;

            //Vérifier si on a choisi un fichier
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                adresseFichier.Text = fdlg.FileName;
                this.pathSource = fdlg.FileName;
                
                this.nomFichier = Path.GetFileNameWithoutExtension(this.pathSource);
                this.label2.Text = this.nomFichier;

                this.Ajouter.Enabled = true;
                this.comboBox1.Enabled = true;
                this.label2.Enabled = true;
                this.textBoxNomMision.Enabled = true;
               
            }

        

        }
    }
}
    

