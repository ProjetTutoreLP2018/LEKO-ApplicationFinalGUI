using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LettreCooperation.modele;
using LettreCooperation.Model;
using System.Drawing.Drawing2D;

namespace LettreCooperation
{
    public partial class Page_ManagerUtilisateur : UserControl
    {


        private List<Utilisateur> utilisateurs;
        private List<Droit> droits;
        private ModelManager model;
        private int index;


        public Page_ManagerUtilisateur()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// Méthode d'initialisation de la
        /// page.
        /// </summary>
        private void Init()
        {
            this.textPass.PasswordChar = '•';
            this.textPassConfirm.PasswordChar = '•';

            pictureBoxSignature.Image = null;
            labelPathImage.Text = String.Empty;

            utilisateurs = new List<Utilisateur>();
            droits = new List<Droit>();
            model = new ModelManager();
            index = 0;
            comboNomUtilisateur.Items.Clear();
            comboNomUtilisateur.ResetText();
            comboDroit.Items.Clear();
            comboDroit.ResetText();
            textNom.Text = string.Empty;
            textPrenom.Text = string.Empty;
            textEmail.Text = string.Empty;
            textPass.Text = string.Empty;
            textPassConfirm.Text = string.Empty;
            labelPathImage.Text = string.Empty;


            utilisateurs = model.GetListUtilisateurs();
            droits = model.GetListDroit();

            foreach (Utilisateur u in utilisateurs)
                comboNomUtilisateur.Items.Add(u.nom_utilisateur);


            foreach (Droit d in droits)
                comboDroit.Items.Add(d.permission);
        }


        /// <summary>
        /// Méthode de gestion du chargement de la page
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();

        }


        /// <summary>
        /// Méthode qui permet de gérer le changement
        /// de l'élément sélectionné dans la comboBox.
        /// Elle permet de charger les éléments dans le
        /// reste de la page en fonction de la sélection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboNomUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = comboNomUtilisateur.SelectedIndex;
            textNom.Text = utilisateurs[index].nom_utilisateur;
            textPrenom.Text = utilisateurs[index].prenom_utilisateur;
            textEmail.Text = utilisateurs[index].email_utilisateur;

            comboDroit.SelectedIndex = utilisateurs[index].id_droit - 1;

            if (utilisateurs[index].isAdmin)
                checkBoxAdmin.Checked = true;
            else
                checkBoxAdmin.Checked = false;

            if (utilisateurs[index].image_Blob_Signature != null)
                pictureBoxSignature.Image = ByteArrayToImage(utilisateurs[index].image_Blob_Signature);
            else
                pictureBoxSignature.Image = null;


            if (utilisateurs[index].id_utilisateur == Page_Principale.Utilisateur.id_utilisateur)
                checkBoxAdmin.Enabled = false;
            else
                checkBoxAdmin.Enabled = true;
        }


        /// <summary>
        /// Méthode qui permet de transformer un tableau de Byte
        /// en Image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        /// <summary>
        /// Méthode qui permet de modifier les éléments
        /// inscrits dans les champs en fonction de l'élément sélectionné
        /// dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            if (comboNomUtilisateur.SelectedIndex < 0)
                return;

            Cursor.Current = Cursors.WaitCursor;

            adresseMailMess.Text = string.Empty;
            mdpConfMess.Text = string.Empty;
            messageErr.Text = string.Empty;

            string email = textEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);



            if (!match.Success)
            {
                Cursor.Current = Cursors.Default;
                adresseMailMess.Text = "L'adresse email n'est pas valide.";
                return;
            }

            if (!textPass.Text.Equals(textPassConfirm.Text))
            {
                Cursor.Current = Cursors.Default;
                mdpConfMess.Text = "Le mot de passe \n ne correspond pas.";
                return;
            }



            utilisateurs[index].nom_utilisateur = textNom.Text;
            utilisateurs[index].prenom_utilisateur = textPrenom.Text;
            utilisateurs[index].email_utilisateur = textEmail.Text;

            if(!String.IsNullOrWhiteSpace(textPass.Text))
                utilisateurs[index].mdp_utilisateur = EncryptePass(textPass.Text);

            int indexDroit = 0;

            foreach (Droit d in droits)
                if (d.permission.Equals(comboDroit.SelectedItem))
                    indexDroit = d.id_droit;

            utilisateurs[index].id_droit = indexDroit;

            if (checkBoxAdmin.Checked)
                utilisateurs[index].isAdmin = true;
            else
                utilisateurs[index].isAdmin = false;

            if (!String.IsNullOrEmpty(labelPathImage.Text))
            {
                string image = ResizeImage(labelPathImage.Text);
                using(Image imageSignature = Image.FromFile(image))
                {
                    utilisateurs[index].image_Blob_Signature = ImageToByteArray(imageSignature);

                }

                File.Delete(image);
            }

            model.SaveBDD();
            MessageBox.Show("Votre utilisateur a bien été modifié");
            Cursor.Current = Cursors.Default;
            Init();

        }


        private String ResizeImage(string path)
        {

            using (var srcImage = Image.FromFile(path))
            {
                var newWidth = (int)(210);
                var newHeight = (int)(53);
                using (var newImage = new Bitmap(newWidth, newHeight))
                {
                    using (var graphics = Graphics.FromImage(newImage))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                        newImage.Save(Program.FINACOOPFolder + "tmp.png");
                    }
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
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }


        /// <summary>
        /// Méthode qui permet de supprimer 
        /// de la base de données l'utilisateur
        /// en fonction de l'élément sélectionné
        /// dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            if (comboNomUtilisateur.SelectedIndex < 0)
                return;

            DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer definitivement cet Utilisateur ?",
               "Êtes vous sûr ?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;
            

            Cursor.Current = Cursors.WaitCursor;
            model.SupprimerUtilisateur(utilisateurs[index]);
            MessageBox.Show("Votre utilisateur a bien été supprimé");
            Init();
            Cursor.Current = Cursors.Default;
        }


        /// <summary>
        /// Méthode qui permet de récupérer l'image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile2 = new OpenFileDialog();
            openFile2.Filter = "Image Files|*.png;*.jpg;*.gif;";
            openFile2.DefaultExt = "png";
            openFile2.ShowDialog();
            labelPathImage.Text = openFile2.FileName;
        }
    }
}
