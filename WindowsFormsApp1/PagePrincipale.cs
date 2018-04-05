using lot1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pagePrincipale : Form
    {

        private UserControl log = new Login();
        //private UserControl creerLC = new CreerUneLC();
        private UserControl creerLC = new FenFormulaireGenerationLC();
        private UserControl signerLC = new SignerLC();
        private UserControl ajou_mod_lc = new Ajout_Modif_LC();
        private UserControl creerUtilisateur = new CreerUtilisateur();
        private UserControl manageUtilisateur = new ManagerUtilisateur();
        

        List<UserControl> listUserControle = new List<UserControl>();

        public pagePrincipale()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = false;

            
            creerLC.Parent = mainPanel;
            creerLC.Visible = false;
           // mainPanel.Controls.Add(creerLC);

            ajou_mod_lc.Parent = mainPanel;
            ajou_mod_lc.Visible = false;
            //mainPanel.Controls.Add(ajou_mod_lc);

            creerUtilisateur.Parent = mainPanel;
            creerUtilisateur.Visible = false;

            signerLC.Parent = mainPanel;
            signerLC.Visible = false;

            manageUtilisateur.Parent = mainPanel;
            manageUtilisateur.Visible = false;

            log.Parent = this;
            log.Dock = DockStyle.Top;
            log.Show();
           
        }

        private void créerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            InitUserContole(creerLC);
        }

        private void voirModifierUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InitUserContole(ajou_mod_lc);

        }

        private void signerUneLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InitUserContole(signerLC);

        }

        private void créerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            InitUserContole(creerUtilisateur);

        }

        private void ManagerUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InitUserContole(manageUtilisateur);
        }


        private void InitUserContole(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.Visible = true;
        }
    }
}
