using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class TypeStatut
    {
        public TypeStatut()
        {
            Statut = new HashSet<Statut>();
        }

        public int IdTypeStatut { get; set; }
        public string Libelle { get; set; }

        public ICollection<Statut> Statut { get; set; }
    }
}
