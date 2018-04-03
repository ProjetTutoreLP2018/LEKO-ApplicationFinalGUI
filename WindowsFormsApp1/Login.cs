using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //TODO: Voire dans la base de données les 
            // identifiants pour pouvoir 
            // vérifier la connexion

            if (this.textBoxUtilisateur.Text.Equals("azerty") && this.textBoxPass.Text.Equals("azerty"))
            {
                this.Visible = false;

                Panel panel = (Panel) this.Parent.Controls.Find("mainPanel", false)[0];

                panel.Visible = true;


            }
            else
            {
                this.labelErrorConnect.Text = "Identifiant ou mot de passe incorrecte !";
            }
           
        }
    }
}
