using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Adresse
    {
        public Adresse()
        {
            Client = new HashSet<Client>();
        }

        public int IdAdresse { get; set; }
        public string Numero { get; set; }
        public string Indice { get; set; }
        public string Voie { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Complements { get; set; }

        public ICollection<Client> Client { get; set; }
    }
}
