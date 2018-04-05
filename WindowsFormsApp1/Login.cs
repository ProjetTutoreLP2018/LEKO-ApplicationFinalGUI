using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {

            if (this.textBoxUtilisateur.Text != "" && this.textBoxPass.Text != "")
            {
                Model connexion = new Model();
                Boolean connecte = connexion.seConnecter(this.textBoxUtilisateur.Text, this.textBoxPass.Text);

                if (connecte)
                {
                    this.Visible = false;

                    Panel panel = (Panel)this.Parent.Controls.Find("mainPanel", false)[0];

                    panel.Visible = true;
                } else
                {
                    this.labelErrorConnect.Text = "Identifiants incorrects";
                }

            }
            else
            {
                this.labelErrorConnect.Text = "Merci de renseigner les champs vides.";
            }
           
        }
    }
}
