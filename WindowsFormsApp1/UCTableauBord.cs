using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LettreCooperation.Model;
using LettreCooperation.modele;

namespace LettreCooperation
{
	public partial class UCTableauBord : UserControl
	{
		public UCTableauBord()
		{
			InitializeComponent();
		}



		public void Comptage()
		{
			int nbLcAttenteSignature = 0;
			int nbLcSigneesValidees = 0;
			int nbLcEnvoyees = 0;
			int nbLcRefusees = 0;

			ModelManager modele = new ModelManager();
			List<LC> listLc = modele.GetListLc();

			foreach (LC lc in listLc) {
				if (lc.id_etat == 1)
					nbLcAttenteSignature++;
				if (lc.id_etat == 7)
					nbLcSigneesValidees++;
				if (lc.id_etat == 8)
					nbLcEnvoyees++;
				if (lc.id_etat == 11)
					nbLcRefusees++;
			}

			nbLCEnAttenteDeSignature.Text = nbLcAttenteSignature.ToString();
			nbLCSigneesValidees.Text = nbLcSigneesValidees.ToString();
			nbLCEnvoyees.Text = nbLcEnvoyees.ToString();
			nbLCRefusees.Text = nbLcRefusees.ToString();
		}

		private void UCTableauBord_Load(object sender, EventArgs e)
		{
			Comptage();
		}

		private void nbLCSigneesValidees_Click(object sender, EventArgs e)
		{

		}
	}
}
