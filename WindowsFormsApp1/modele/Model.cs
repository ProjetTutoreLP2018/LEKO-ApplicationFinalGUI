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

        public List<Utilisateur> GetListUtilisateurs()
        {

            return context.Utilisateur.ToList();
        }

        public void ModifUtilisateur()
        {
            context.SaveChanges();
        }

        public void SupprimerUtilisateur(Utilisateur utilisateur)
        {
            context.Utilisateur.Remove(utilisateur);
            context.SaveChanges();
        }

        public Boolean seConnecter(string login, string mdp)
        {
             
            var users = from user in context.Utilisateur
                        where user.EmailUtilisateur == login
                        && user.MdpUtilisateur == mdp
                        select user;
            if (users.ToList().Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
