using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using LettreCooperation.Model;

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
        /// Méthode qui permet de récupèrer la liste de LC
        /// a signer
        /// </summary>
        /// <returns></returns>
        public List<LC> GetListLcASigner()
        {
            return (from lc in context.LC
                    join etat in context.Etat
                    on lc.id_etat equals etat.id_etat
                    where etat.libelle_etat == "C"
                    select lc).ToList();
        }


        /// <summary>
        /// Méthode qui renvoie une LC en fonction de son nom
        /// </summary>
        /// <param name="etat"></param>
        /// <returns></returns>
        public LC GetListLCByName(string nom)
        {
            List<LC> lcs = (from lc in context.LC
                    where lc.nom_lc == nom
                    select lc).ToList();

            return lcs.First();
        }


        /// <summary>
        /// Méthode qui permet de suppirmer une LC
        /// </summary>
        /// <param name="lc"></param>
        public void DeleteLC(LC lc)
        {
            context.LC.Remove(lc);
            context.SaveChanges();
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

            try
            {
                if (users.ToList().Count() == 0)
                    return null;

            }
            catch(System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("La connextion n'a pas pu être établie avec la base de données." +
                    " Merci de vérifier votre connexion internet.");

                return null;
            }
           

            Utilisateur utilisateur = new Utilisateur();

            foreach(var result in users)
            {
                utilisateur.id_utilisateur = result.id_utilisateur;
                utilisateur.nom_utilisateur = result.nom_utilisateur;
                utilisateur.prenom_utilisateur = result.prenom_utilisateur;
                utilisateur.email_utilisateur = result.email_utilisateur;
                utilisateur.mdp_utilisateur = result.mdp_utilisateur;
                utilisateur.id_droit = result.id_droit;
                utilisateur.isAdmin = result.isAdmin;
                utilisateur.image_Blob_Signature = result.image_Blob_Signature;

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
          
            Utilisateur u = context.Utilisateur.Find(id);

            if (u == null)
                return new Utilisateur();

            return u;
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

        /// <summary>
        /// Méthode de modification d'un client
        /// </summary>
        public void ModifClient()
        {
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode de suppression d'un clinet
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool SupprimerClient(Client client)
        {
            bool PossedeLC = false;
            foreach (LC lc in GetListLc())
            {
                if (client.id_client == lc.id_client)
                {
                    PossedeLC = true;
                }
            }

            if (PossedeLC == false)
            {
                context.Client.Remove(client);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupérer un client
        /// en fonction de sa raison sociale
        /// </summary>
        /// <param name="raisonSociale"></param>
        /// <returns></returns>
        public Client GetClients(string raisonSociale)
        {
           
            IEnumerable<Client> client_sql = from c
                                in context.Client
                                             where c.raison_sociale == raisonSociale
                                             select c;

            return client_sql.First();
        }


        /// <summary>
        /// Méthode qui permet de récupèrer la liste
        /// des modèles présent dans la base de données
        /// </summary>
        /// <returns></returns>
        public List<Modele> GetModeles()
        {
            return context.Modele.ToList();
        }


        /// <summary>
        /// Méthode qui permet d'ajouter une nouvelle LC dans
        /// la base de données
        /// </summary>
        /// <param name="lc"></param>
        public void SaveLC(LC lc)
        {
            context.LC.Add(lc);
            context.SaveChanges();
        }


        /// <summary>
        /// Méthode qui permet de récupèrer un état en fonction
        /// de son clés primaire
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Etat GetEtatById(int i)
        {
            return context.Etat.Find(i);
        }


        /// <summary>
        /// Méthode qui eprmet de changer l'état d'une LC
        /// en 'LC_Signer'
        /// </summary>
        /// <param name="i"></param>
        public void ChangerEtatLC_Signer(int i)
        {
            LC lc = context.LC.Find(i);
            lc.id_etat = 7;
            context.SaveChanges();
        }

        /// <summary>
        /// Méthode qui permet d'ajouter le signataire
        /// de la LC dans la base de données
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="utilisateur"></param>
        public void AjoutSignataire(LC lc, Utilisateur utilisateur)
        {
            LC lcFromDB = context.LC.Find(lc.id_lc);

            //MessageBox.Show("Utilisateur signataire id : " + utilisateur.id_utilisateur
              //  + " Nom :" + utilisateur.nom_utilisateur);

            lcFromDB.id_signataire = utilisateur.id_utilisateur;
            context.SaveChanges();
        }


        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        public void AjouterModel(string pathDestination, string nomFichier, string nomMission, string typeLettre)
        {
            try
            {
                context.Modele.Add(new Modele { chemin_modele = pathDestination, nom_fichier = nomFichier, nom_mission = nomMission, type_lettre = typeLettre });
                context.SaveChanges();
                MessageBox.Show("Le modéle de LC " + nomFichier + " a était ajoutée");
            }
            catch
            {
                MessageBox.Show("Erreur, le modéle n'as pas était ajouté");
            }

        }
    }
}
