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
    public partial class ChangeSMTP : Form
    {
        public ChangeSMTP()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimmentions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            textBoxSMTP.Text = Properties.Settings.Default.SMTP;

            labelMessage.Text = "Vous pouvez ici changer votre SMTP.";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SMTP = textBoxSMTP.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
