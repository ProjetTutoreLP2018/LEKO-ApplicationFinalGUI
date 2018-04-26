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
            try { 
                return context.Droit.ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permetde créer un nouvel utilisateur
        /// </summary>
        /// <param name="utilisateur"></param>
        public void CreerUtilisateur(Utilisateur utilisateur)
        {
            try { 
                context.Utilisateur.Add(utilisateur);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupèrer la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        public List<Utilisateur> GetListUtilisateurs()
        {
            try { 
                return context.Utilisateur.ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet d'enregister la modification d'un utilisateur
        /// </summary>
        public void SaveBDD()
        {
            try { 
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de supprimer un utilisateur
        /// </summary>
        /// <param name="utilisateur"></param>
        public void SupprimerUtilisateur(Utilisateur utilisateur)
        {
            try { 
                context.Utilisateur.Remove(utilisateur);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupérer la liste de LC
        /// </summary>
        /// <returns></returns>
        public List<LC> GetListLc()
        {
            try { 
                return context.LC.ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupèrer la liste de LC
        /// a signer
        /// </summary>
        /// <returns></returns>
        public List<LC> GetListLcASigner()
        {
            try { 
                return (from lc in context.LC
                        join etat in context.Etat
                        on lc.id_etat equals etat.id_etat
                        where etat.libelle_etat == "C"
                        || etat.libelle_etat == "R"
                        select lc).ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui renvoie une LC en fonction de son nom
        /// </summary>
        /// <param name="etat"></param>
        /// <returns></returns>
        public LC GetListLCByName(string nom)
        {
            try { 
                List<LC> lcs = (from lc in context.LC
                        where lc.nom_lc == nom
                        select lc).ToList();

                return lcs.First();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de suppirmer une LC
        /// </summary>
        /// <param name="lc"></param>
        public void DeleteLC(LC lc)
        {
            try { 
                LC lcASupp = context.LC.Find(lc.id_lc);
                context.LC.Remove(lcASupp);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupérer la liste des clients
        /// </summary>
        /// <returns></returns>
        public List<Client> GetListClient()
        {
            try { 
                return context.Client.ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupérer les LC
        /// liées a un client
        /// </summary>
        /// <param name="indexClient"></param>
        /// <returns></returns>
        public List<LC> GestLcFromClient(int indexClient)
        {
            try { 
                return context.LC.Where(a => a.id_client == indexClient).ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
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
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

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
            try { 
                return context.Etat.Find(index);
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de rechercher un utilisateur
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Utilisateur GetUser(int? index)
        {
            try { 
                return context.Utilisateur.Find(index);
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de créer un client
        /// </summary>
        /// <param name="client"></param>
        public void CreerClient(Client client)
        {
            try { 
                context.Client.Add(client);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de créer une adresse
        /// </summary>
        /// <param name="adresse"></param>
        public void CreerAdresse(Adresse adresse)
        {
            try { 
                context.Adresse.Add(adresse);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de récuprérer la liste des LC
        /// en attente d'envoie
        /// </summary>
        /// <returns></returns>
        public List<LC> GetListLCWaitingSend()
        {

            try { 
                return (from lc in context.LC
                       join etat in context.Etat
                       on lc.id_etat equals etat.id_etat
                       where etat.libelle_etat == "SE" 
                       select lc).ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }

        
        /// <summary>
        /// Méthode qui permet de trouver un client avec son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client FindClient(int id)
        {
            try { 
                return context.Client.Find(id);
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de trouver un utilisateur
        /// avec son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Utilisateur FindUtilisateur(int? id)
        {

            try { 
                Utilisateur u = context.Utilisateur.Find(id);

                if (u == null)
                    return new Utilisateur();

                return u;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de changer l'Etat d'un LC
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="etat"></param>
        public void UpdateEtatLc(LC lc, int etat)
        {
            try { 
                lc.id_etat = etat;
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de changer le chemin du fichier
        /// aprés envoie au client
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="path"></param>
        public void UpdatePathLc(LC lc, string path)
        {
            try { 
                lc.chemin_lc = path;
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
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
                try { 
                    context.Client.Remove(client);
                    context.SaveChanges();
                    return true;
                }
                catch (System.Data.Entity.Core.EntityException e)
                {
                    MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                        "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                    return false;
                }
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

            try { 
                IEnumerable<Client> client_sql = from c
                                    in context.Client
                                                 where c.raison_sociale == raisonSociale
                                                 select c;

                return client_sql.First();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupèrer la liste
        /// des modèles présent dans la base de données
        /// </summary>
        /// <returns></returns>
        public List<Modele> GetModeles()
        {
            try {
                return context.Modele.ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet d'ajouter une nouvelle LC dans
        /// la base de données
        /// </summary>
        /// <param name="lc"></param>
        public void SaveLC(LC lc)
        {
            try { 
                context.LC.Add(lc);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de récupèrer un état en fonction
        /// de son clés primaire
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Etat GetEtatById(int? i)
        {
            try { 
                return context.Etat.Find(i);
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null; 
            } 
        }

         
        /// <summary>
        /// Méthode qui eprmet de changer l'état d'une LC
        /// en 'LC_Signer'
        /// </summary>
        /// <param name="i"></param>
        public void ChangerEtatLC_Signer(int i)
        {
            try { 
                LC lc = context.LC.Find(i);
                lc.id_etat = 7;
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter le signataire
        /// de la LC dans la base de données
        /// </summary>
        /// <param name="lc"></param>
        /// <param name="utilisateur"></param>
        public void AjoutSignataire(LC lc, Utilisateur utilisateur)
        {
            try { 
                LC lcFromDB = context.LC.Find(lc.id_lc);

                //MessageBox.Show("Utilisateur signataire id : " + utilisateur.id_utilisateur
                  //  + " Nom :" + utilisateur.nom_utilisateur);

                lcFromDB.id_signataire = utilisateur.id_utilisateur;
                context.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }
        }


        /// <summary>
        /// Méthode qui permet de convertir une image en tableau
        /// de Byte
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try { 
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Méthode qui permet l'ajout d'un modele
        /// dans la base de donnée
        /// </summary>
        /// <param name="pathDestination"></param>
        /// <param name="nomFichier"></param>
        /// <param name="nomMission"></param>
        /// <param name="typeLettre"></param>
        public void AjouterModel(string pathDestination, string nomFichier, string nomMission, string typeLettre)
        {
            try
            {
                context.Modele.Add(new Modele { chemin_modele = pathDestination, nom_fichier = nomFichier, nom_mission = nomMission, type_lettre = typeLettre });
                context.SaveChanges();
                MessageBox.Show("Le modéle de LC " + nomFichier + " a était ajoutée");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return;
            }

        }


        /// <summary>
        /// Méthode qui permet de retourner la liste des
        /// etat des LC
        /// </summary>
        /// <returns></returns>
        public List<Etat> GetLesEtatsLC()
        {
            try { 
                return (from Etat in context.Etat
                       select Etat).ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        /// <summary>
        /// Retourner l'id de l'état 'Archive'
        /// </summary>
        /// <returns></returns>
        public int GetIdEtatArchiver()
        {
            try { 
                var idEtatArchiver =  from etat in context.Etat
                        where etat.libelle_etat == "A"
                        select etat.id_etat;

                return idEtatArchiver.First();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return -1;
            }

        }


        /// <summary>
        /// Méthode qui permet de retourner l'Id
        /// de l'état 'Refuser'
        /// </summary>
        /// <returns></returns>
        public int GetIdEtatRefuser()
        {
            try { 
                var idEtatArchiver = from etat in context.Etat
                                     where etat.libelle_etat == "R"
                                     select etat.id_etat;

                return idEtatArchiver.First();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return -1;
            }
        }


        public List<Client> GetListClientRetour()
        {
            try { 
                return (from client in context.Client
                        join lc in context.LC
                        on client.id_client equals lc.id_client
                        where lc.id_etat == 8
                        select client).Distinct().ToList();

            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }

        }



        public List<Client> GetListClientArchive()
        {
            try { 
                return (from client in context.Client
                        join lc in context.LC
                        on client.id_client equals lc.id_client
                        where lc.id_etat == 10
                        select client).Distinct().ToList();

            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }

        }


        public List<LC> GetListLCFromClienteRetour(int id)
        {
            try { 
                return (from client in context.Client
                        join lc in context.LC
                        on client.id_client equals lc.id_client
                        join e in context.Etat
                        on lc.id_etat equals e.id_etat
                        where e.libelle_etat == "AC"
                        && client.id_client == id
                        select lc).ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }


        public List<LC> GetListLCFromClienteArchive(int id)
        {
            try { 
                return (from lc in context.LC
                        where lc.id_client == id
                        && lc.id_etat == 10
                        select lc).ToList();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                MessageBox.Show("Vous n'êtes pas connecter à la base de données. Merci" +
                    "de vérifier votre connexion internet ou vérifier que le port 1433 de votre Box soit bien ouvert.");

                return null;
            }
        }
    }
}
