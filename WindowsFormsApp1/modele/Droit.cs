using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Droit
    {
        public Droit()
        {
            Utilisateur = new HashSet<Utilisateur>();
        }

        public int IdDroit { get; set; }
        public string Permission { get; set; }

        public ICollection<Utilisateur> Utilisateur { get; set; }
    }
}
