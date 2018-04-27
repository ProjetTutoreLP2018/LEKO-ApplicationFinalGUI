using LettreCooperation.Model;
using LettreCooperation.modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class PopUp_SupprimerUnModeleDeLc : Form
    {
        private ModelManager modelManager;
        private List<Modele> data;
        private string pathInBdd;
        private int idModele;
        

        public PopUp_SupprimerUnModeleDeLc()
        {
            InitializeComponent();
            Init();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimmentions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }


        private void Init()
        {
            this.modelManager = new ModelManager();
            this.data = new List<Modele>();
            this.data = this.modelManager.GetModeles();


            foreach (Modele modele in this.data)
            {
                comboBox1.Items.Add(modele.nom_fichier);

            }

            
        }


        private void SupprimerModel_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            if (this.comboBox1.SelectedIndex < 0)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Merci de séléctionner un type de Modèle.");
                return;
            }


            DialogResult dialog = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement ce modéle ? ", " Alerte ", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
                return;
            else
            {
                string pathComplet = Program.FINACOOPFolder + this.pathInBdd;

                MessageBox.Show(pathComplet);

                File.Delete(pathComplet);
                this.modelManager.SupprimerModele(this.idModele);

            }

            textNomMission.Text = String.Empty;
            textTypeLettre.Text = String.Empty;
            comboBox1.Items.Clear();
            comboBox1.Text = String.Empty;

            Cursor.Current = Cursors.Default;

        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            this.idModele = data[comboBox1.SelectedIndex].id_modele;
            this.pathInBdd = data[comboBox1.SelectedIndex].chemin_modele;
            textNomMission.Text = data[comboBox1.SelectedIndex].nom_mission;
            textTypeLettre.Text = data[comboBox1.SelectedIndex].type_lettre;
    
        }

        
    }
}
