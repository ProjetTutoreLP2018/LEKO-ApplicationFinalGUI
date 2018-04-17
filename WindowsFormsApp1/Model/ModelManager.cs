using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace LettreCooperation.modele
{
    class ModelManager
    {

        private LCBDEntities2 context;

        public ModelManager()
        {
            context = new LCBDEntities2();
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


        public List<LC> GetListLc()
        {
            return context.LC.ToList();
        }


        public List<Client> GetListClient()
        {
            return context.Client.ToList();
        }


        public List<LC> GestLcFromClient(int indexClient)
        {
            return context.LC.Where(a => a.id_client == indexClient).ToList();
        }


        public Utilisateur seConnecter(string login, string mdp)
        {

            var users = from user in context.Utilisateur
                        where user.email_utilisateur == login
                        && user.mdp_utilisateur == mdp
                        select user;


            if (users.ToList().Count() == 0)
                return null;

            Utilisateur utilisateur = new Utilisateur();

            foreach(var result in users)
            {
                utilisateur.nom_utilisateur = result.nom_utilisateur;
                utilisateur.prenom_utilisateur = result.prenom_utilisateur;
                utilisateur.email_utilisateur = result.email_utilisateur;
                utilisateur.mdp_utilisateur = result.mdp_utilisateur;
                utilisateur.id_droit = result.id_droit;
                utilisateur.isAdmin = result.isAdmin;

            }

            return utilisateur;

        }

        public Etat GetStatut(int? index)
        {
            return context.Etat.Find(index);
        }

        public Utilisateur GetUser(int? index)
        {
            return context.Utilisateur.Find(index);
        }


        public void CreerClient(Client client)
        {
            context.Client.Add(client);
            context.SaveChanges();
        }

        public void CreerAdresse(Adresse adresse)
        {
            context.Adresse.Add(adresse);
            context.SaveChanges();
        }
    }
}
