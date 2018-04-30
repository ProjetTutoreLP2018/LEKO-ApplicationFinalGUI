using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LettreCooperation.modele;
using LettreCooperation.Model;

namespace LettreCooperation
{
    public partial class PopUp_VoirArchives : Form
    {

        private ModelManager modelManager = new ModelManager();
        private List<Client> clients;
        private List<LC> lCs;

        public PopUp_VoirArchives()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimensions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitClient();
        }



        private void InitClient()
        {
            clients = modelManager.GetListClientArchive();

            if (clients == null)
                return;

            foreach (Client client in clients)
            {
                comboBoxClient.Items.Add(client.raison_sociale);
            }
        }

        private void InitLc()
        {
            comboBoxLC.Items.Clear();
            comboBoxLC.Text = String.Empty;

            lCs = modelManager.GetListLCFromClienteArchive(
                clients[comboBoxClient.SelectedIndex].id_client
                );
            foreach (LC lc in lCs)
            {
                comboBoxLC.Items.Add(lc.nom_lc);
            }
        }

        private void ComboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitLc();

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLC.SelectedIndex < 0)
                return;

            axAcroPDF1.src = Program.FINACOOPFolder + lCs[comboBoxLC.SelectedIndex].chemin_lc;
        }
    }
}
