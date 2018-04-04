using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Statut
    {
        public Statut()
        {
            Client = new HashSet<Client>();
        }

        public int IdStatut { get; set; }
        public string Libelle { get; set; }
        public int IdTypestatut { get; set; }

        public TypeStatut IdTypestatutNavigation { get; set; }
        public ICollection<Client> Client { get; set; }
    }
}
