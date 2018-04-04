using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Client
    {
        public Client()
        {
            Lc = new HashSet<Lc>();
        }

        public int IdClient { get; set; }
        public string Siret { get; set; }
        public string FormeJuridique { get; set; }
        public string RaisonSociale { get; set; }
        public double? Ca { get; set; }
        public int Effectifs { get; set; }
        public string OrganisationComptable { get; set; }
        public double? VolumeAnnuel { get; set; }
        public DateTime? DateImmatriculation { get; set; }
        public string LieuImmatriculation { get; set; }
        public string NomReferent { get; set; }
        public string PrenomReferent { get; set; }
        public string FonctionReferent { get; set; }
        public string SexeReferent { get; set; }
        public int? IdActivite { get; set; }
        public int IdAdresse { get; set; }
        public string SiteWeb { get; set; }
        public bool? Ess { get; set; }
        public string TelFix { get; set; }
        public string TelPortable { get; set; }
        public int? IdStatut { get; set; }

        public Activite IdActiviteNavigation { get; set; }
        public Adresse IdAdresseNavigation { get; set; }
        public Statut IdStatutNavigation { get; set; }
        public ICollection<Lc> Lc { get; set; }
    }
}
