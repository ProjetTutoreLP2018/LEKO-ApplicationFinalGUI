using System.Collections.Generic;
using System.Linq;
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


        /// <summary>
        /// Méthode qui permet de récupérer la liste de droit
        /// </summary>
        /// <returns></returns>
        public List<Droit> GetListDroit()
        {
            return context.Droit.ToList();
        }


        /// <summary>
        /// Méthode qui permetde créer un nouvel utilisateur
        /// </summary>
        /// <param name="utilisateur"></param>
        public void CreerUtilisateur(Utilisateur utilisateur)
        {
            context.Utilisateur.Add(utilisateur);
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode qui permet de récupèrer la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        public List<Utilisateur> GetListUtilisateurs()
        {

            return context.Utilisateur.ToList();
        }


        /// <summary>
        /// Méthode qui permet d'enregister la modification d'un utilisateur
        /// </summary>
        public void ModifUtilisateur()
        {
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode qui permet de supprimer un utilisateur
        /// </summary>
        /// <param name="utilisateur"></param>
        public void SupprimerUtilisateur(Utilisateur utilisateur)
        {
            context.Utilisateur.Remove(utilisateur);
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode qui permet de récupérer la liste de LC
        /// </summary>
        /// <returns></returns>
        public List<LC> GetListLc()
        {
            return context.LC.ToList();
        }


        /// <summary>
        /// Méthode qui permet de récupérer la liste des clients
        /// </summary>
        /// <returns></returns>
        public List<Client> GetListClient()
        {
            return context.Client.ToList();
        }


        /// <summary>
        /// Méthode qui permet de récupérer les LC
        /// liées a un client
        /// </summary>
        /// <param name="indexClient"></param>
        /// <returns></returns>
        public List<LC> GestLcFromClient(int indexClient)
        {
            return context.LC.Where(a => a.id_client == indexClient).ToList();
        }


        /// <summary>
        /// Méthode qui permet de ce connecter
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public Utilisateur SeConnecter(string login, string mdp)
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


        /// <summary>
        /// Méthode qui permet de rechercher un Etat
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Etat GetEtat(int? index)
        {
            return context.Etat.Find(index);
        }


        /// <summary>
        /// Méthode qui permet de rechercher un utilisateur
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Utilisateur GetUser(int? index)
        {
            return context.Utilisateur.Find(index);
        }


        /// <summary>
        /// Méthode qui permet de créer un client
        /// </summary>
        /// <param name="client"></param>
        public void CreerClient(Client client)
        {
            context.Client.Add(client);
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode qui permet de créer une adresse
        /// </summary>
        /// <param name="adresse"></param>
        public void CreerAdresse(Adresse adresse)
        {
            context.Adresse.Add(adresse);
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode qui permet de récuprérer la liste des LC
        /// en attente d'envoie
        /// </summary>
        /// <returns></returns>
        public List<LC> GetListLCWaitingSend()
        {
     
            return (from lc in context.LC
                   join etat in context.Etat
                   on lc.id_etat equals etat.id_etat
                   where etat.libelle_etat == "SE" 
                   select lc).ToList();
        }

        
        /// <summary>
        /// Méthode qui permet de trouver un client avec son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client FindClient(int id)
        {
            return context.Client.Find(id);
        }


        /// <summary>
        /// Méthode qui permet de trouver un utilisateur
        /// avec son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Utilisateur FindUtilisateur(int? id)
        {
            return context.Utilisateur.Find(id);
        }


        /// <summary>
        /// Méthode qui permet de changer l'Etat d'un LC
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="etat"></param>
        public void UpdateEtatLc(LC lc, int etat)
        {
            lc.id_etat = etat;
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode qui permet de changer le chemin du fichier
        /// aprés envoie au client
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="path"></param>
        public void UpdatePathLc(LC lc, string path)
        {
            lc.chemin_lc = path;
            context.SaveChanges();
        }
    }
}
