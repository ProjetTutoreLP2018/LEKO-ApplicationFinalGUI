using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LettreCooperation.modele;
using LettreCooperation.Model;

namespace LettreCooperation
{
    public partial class ManagerUtilisateur : UserControl
    {


        private List<Utilisateur> utilisateurs;
        private List<Droit> droits;
        private ModelManager model;
        private int index;


        public ManagerUtilisateur()
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
        /// Méthode de gestion du chagement de la page
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();

        }


        /// <summary>
        /// Méthode qui permet de gérer le changement
        /// de l'élément séléctionner dans la comboBox.
        /// Elle permet de chager les éléments dans le
        /// reste de la page en fonction de la séléction
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
        /// inscrit dans les champs en fonction de l'élément séléctionné
        /// dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModifier_Click(object sender, EventArgs e)
        {

            adresseMailMess.Text = string.Empty;
            mdpConfMess.Text = string.Empty;
            messageErr.Text = string.Empty;

            string email = textEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);



            if (!match.Success)
            {
                adresseMailMess.Text = "L'adresse email n'est pas valide.";
                return;
            }

            if (!textPass.Text.Equals(textPassConfirm.Text))
            {
                mdpConfMess.Text = "Le mot de passe \n ne correspond pas.";
                return;
            }



            utilisateurs[index].nom_utilisateur = textNom.Text;
            utilisateurs[index].prenom_utilisateur = textPrenom.Text;
            utilisateurs[index].email_utilisateur = textEmail.Text;

            if(!String.IsNullOrWhiteSpace(textPass.Text))
                utilisateurs[index].mdp_utilisateur = textPass.Text;

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
                Image imageSignature = Image.FromFile(labelPathImage.Text);
                utilisateurs[index].image_Blob_Signature = ImageToByteArray(imageSignature);
            }

            model.SaveBDD();
            MessageBox.Show("Votre utilisateur a bien été modifié");
            Init();

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
        /// en fonction de l'élément séléctionné
        /// dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            model.SupprimerUtilisateur(utilisateurs[index]);
            MessageBox.Show("Votre utilisateur a bien été supprimé");
            Init();

        }


        /// <summary>
        /// Méthode qui permet de récupèrer l'image
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
