using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Lc
    {
        public int IdLc { get; set; }
        public string CheminLc { get; set; }
        public DateTime DateLc { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int IdClient { get; set; }
        public int IdModele { get; set; }

        public Client IdClientNavigation { get; set; }
        public Modele IdModeleNavigation { get; set; }
    }
}
