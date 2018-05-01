using AnswerTypeForm;
using app_lp;
using System;
using System.Windows.Forms;

namespace LettreCooperation
{
	public partial class PopUp_ChoixClientTypeForm : Form
	{

		public static InfoEntreprise infoEntreprise;
		private Formulaire1 form1;
		private Formulaire2 form2;
		public PopUp_ChoixClientTypeForm()
		{
			InitializeComponent();

            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

		private void btnValider_Click(object sender, EventArgs e)
		{
			infoEntreprise = FormulaireAbstract.getInfoEntrepriseForm1Form2(form1, form2, cbChoixClientTypeForm.SelectedItem.ToString());
		}

		private async void Page_ChoixClientTypeForm_Load(object sender, EventArgs e)
		{
			form1 = new Formulaire1();
			form2 = new Formulaire2();

			AnswerObject reponses = await typeFormApi.getAnswers(Identifiants.Token, Identifiants.IDFormulaire1);
			form1.json_answers = reponses;

			reponses = await typeFormApi.getAnswers(Identifiants.Token, Identifiants.IDFormulaire2);
			form2.json_answers = reponses;

			foreach(InfoEntreprise infoEntreprise in form1.getInfoEntreprises())
			{
				cbChoixClientTypeForm.Items.Add(infoEntreprise.nomEntreprise);
			}
		}
	}
}
