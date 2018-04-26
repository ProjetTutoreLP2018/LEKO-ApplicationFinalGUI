using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class PopUp_AfficherPDF : Form
    {
        public PopUp_AfficherPDF()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimmentions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        public void Initialiser(string path)
        {
            axAcroPDF1.src = path;
        }

    }
}
