using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LettreCooperation.Model;
using LettreCooperation.modele;

namespace LettreCooperation
{
	public partial class Page_TableauDeBord : UserControl
	{
		public Page_TableauDeBord()
		{
			InitializeComponent();
		}



		public void Comptage()
		{
			int nbLcAttenteSignature = 0;
			int nbLcSigneesValidees = 0;
			int nbLcEnvoyees = 0;
			int nbLcRefusees = 0;
            int nbLcArchivees = 0;

			ModelManager modele = new ModelManager();
			List<LC> listLc = modele.GetListLc();

			foreach (LC lc in listLc) {
				if (lc.id_etat == modele.GetEtatByLibelle("C"))
					nbLcAttenteSignature++;
				if (lc.id_etat == modele.GetEtatByLibelle("SE"))
					nbLcSigneesValidees++;
				if (lc.id_etat == modele.GetEtatByLibelle("AC"))
					nbLcEnvoyees++;
				if (lc.id_etat == modele.GetEtatByLibelle("R"))
					nbLcRefusees++;
                if (lc.id_etat == modele.GetEtatByLibelle("A"))
                    nbLcArchivees++;
            }

			nbLCEnAttenteDeSignature.Text = nbLcAttenteSignature.ToString();
			nbLCSigneesValidees.Text = nbLcSigneesValidees.ToString();
			nbLCEnvoyees.Text = nbLcEnvoyees.ToString();
			nbLCRefusees.Text = nbLcRefusees.ToString();
            lcArchivees.Text = nbLcArchivees.ToString();

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
