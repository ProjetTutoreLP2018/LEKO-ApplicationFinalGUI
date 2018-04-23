using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
