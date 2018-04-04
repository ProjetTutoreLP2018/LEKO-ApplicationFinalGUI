using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Modele
    {
        public Modele()
        {
            Lc = new HashSet<Lc>();
        }

        public int IdModele { get; set; }
        public string CheminModele { get; set; }
        public string NomFichier { get; set; }

        public ICollection<Lc> Lc { get; set; }
    }
}
