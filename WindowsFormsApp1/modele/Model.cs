using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modele
{
    class Model
    {

        private LCBDContext context;

        public Model()
        {
            context = new LCBDContext();
        }

        public List<Droit> GetListDroit()
        {
            return context.Droit.ToList();
        }

        public void CreerUtilisateur(Utilisateur utilisateur)
        {
            context.Utilisateur.Add(utilisateur);
            context.SaveChanges();
        }
    }
}
