using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    public partial class Voir_Modif_LC : UserControl
    {

        private Model model;
        private List<Lc> listLc;
        private List<Client> listClient;
        private int index;

        public Voir_Modif_LC()
        {
            InitializeComponent();

        }

        
        public void Init()
        {

            index = 0;
            model = new Model();
            listLc = new List<Lc>();
            listClient = new List<Client>();


            listClient = model.GetListClient();
            //  listLc = model.GetListLc();


            foreach (Client client in listClient)
                comboClient.Items.Add(client.RaisonSociale);
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();

        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = comboClient.SelectedIndex;
            comboLC.Items.Clear();

            List<Lc> listLc =  model.GestLcFromClient(listClient[index].IdClient);

            foreach (Lc lc in listLc)
                comboLC.Items.Add(lc.CheminLc);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
