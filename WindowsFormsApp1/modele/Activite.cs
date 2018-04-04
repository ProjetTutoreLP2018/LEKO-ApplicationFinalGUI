using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Activite
    {
        public Activite()
        {
            Client = new HashSet<Client>();
        }

        public int IdActivite { get; set; }
        public string LibelleActivite { get; set; }

        public ICollection<Client> Client { get; set; }
    }
}
