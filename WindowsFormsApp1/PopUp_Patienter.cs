using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class PopUp_Patienter : Form
    {
        public PopUp_Patienter()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
