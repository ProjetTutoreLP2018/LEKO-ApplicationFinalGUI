using LettreCooperation.modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LettreCooperation.Model;
using System.Drawing.Drawing2D;

namespace LettreCooperation
{
    public partial class Page_CreerNouveauUtilisateur : UserControl
    {


        private List<Droit> droits;
        private ModelManager model = new ModelManager();


        public Page_CreerNouveauUtilisateur()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Méthode d'initialisation de la page
        /// </summary>
        private void Init()
        {

            labelPathImage.Text = String.Empty;
            textNom.Text = string.Empty;
            textPrenom.Text = string.Empty;
            textEmail.Text = string.Empty;
            textConfirmEmail.Text = string.Empty;
            textPass.Text = string.Empty;
            textConfPass.Text = string.Empty;

            adresseMailMess.Text = string.Empty;
            adresseMailConfMess.Text = string.Empty;
            mdpConfMess.Text = string.Empty;
            messageErr.Text = string.Empty;

            comboDroit.ResetText();

            checkBoxAdmin.Checked = false;

            this.textPass.PasswordChar = '•';
            this.textConfPass.PasswordChar = '•';
        }


        /// <summary>
        /// Méthode qui permet de gérer l'événement
        /// de chargement de la page.
        /// On y initialise la liste de droit prise
        /// dans la base de données
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            droits = model.GetListDroit();

            foreach (Droit d in droits)
                comboDroit.Items.Add(d.permission);

            Init();
        }


        /// <summary>
        /// Méthode qui permet de valider une
        /// création d'un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {

            adresseMailMess.Text = string.Empty;
            adresseMailConfMess.Text = string.Empty;
            mdpConfMess.Text = string.Empty;
            messageErr.Text = string.Empty;

            string email = textEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);



            if (!match.Success) {
                adresseMailMess.Text = "L'adresse email n'est pas valide.";
                return;
            }


            if (!textEmail.Text.Equals(textConfirmEmail.Text))
            {
                adresseMailConfMess.Text = "L'adresse email ne correspond pas.";
                return;

            }
            if (!textPass.Text.Equals(textConfPass.Text))
            {
                mdpConfMess.Text = "Le mot de passe \n ne correspond pas.";
                return;
            }



            if (textNom.Text.Equals("") || textPrenom.Text.Equals("") || textEmail.Text.Equals("") ||
                textConfirmEmail.Text.Equals("") ||
                textPass.Text.Equals("") || textConfPass.Text.Equals(""))
            {
                messageErr.Text = "Veuillez renseigner tous les champs.";
                return;
            }

            Utilisateur utilisateur = new Utilisateur();
            utilisateur.nom_utilisateur = textNom.Text;
            utilisateur.prenom_utilisateur = textPrenom.Text;
            utilisateur.email_utilisateur = textEmail.Text;

            if (checkBoxAdmin.Checked)
            {
                utilisateur.isAdmin = true;
            }
            else
            {
                utilisateur.isAdmin = false;
            }
                    
            int index = 0;

            foreach (Droit d in droits)
            {
                if (d.permission.Equals(comboDroit.SelectedItem))
                {
                    index = d.id_droit;
                    break;
                }
            }


            utilisateur.id_droit = index;
            utilisateur.mdp_utilisateur = EncryptePass(textPass.Text);

           
            MessageBox.Show("L'utilisateur " + utilisateur.nom_utilisateur +
                " " + utilisateur.prenom_utilisateur + " a bien était créer");

            if (!String.IsNullOrEmpty(labelPathImage.Text))
            {
                string image = ResizeImage(labelPathImage.Text);
                using (Image imageSignature = Image.FromFile(image))
                {
                    utilisateur.image_Blob_Signature = ImageToByteArray(imageSignature);
                }
                File.Delete(image);
            }


            model.CreerUtilisateur(utilisateur);
            Init();
        }


        private String ResizeImage(string path)
        {

            using (var srcImage = Image.FromFile(path))
            {
                var newWidth = (int)(210);
                var newHeight = (int)(53);
                using (var newImage = new Bitmap(newWidth, newHeight))
                using (var graphics = Graphics.FromImage(newImage))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                    newImage.Save(Program.FINACOOPFolder + "tmp.png");
                }
            }

            return Program.FINACOOPFolder + "tmp.png";

        }


        private string EncryptePass(string pass)
        {

            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            return hash;
        }


        /// <summary>
        /// Méthode qui permet de convertir une image en 
        /// tableau de byte
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


        /// <summary>
        /// Méthode qui permet de réinitialiser
        /// le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            Init();
        }


        /// <summary>
        /// Méthode qui permet de récupèrer l'image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShearchImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile2 = new OpenFileDialog();
            openFile2.Filter = "Image Files|*.png;*.jpg;*.gif;";
            openFile2.DefaultExt = "png";
            openFile2.ShowDialog();
            labelPathImage.Text = openFile2.FileName;
        }
    }
}
