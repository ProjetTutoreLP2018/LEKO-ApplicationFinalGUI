using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.modele
{
    public partial class Utilisateur
    {
        public int IdUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string PrenomUtilisateur { get; set; }
        public string EmailUtilisateur { get; set; }
        public int IdDroit { get; set; }
        public string MdpUtilisateur { get; set; }

        public Droit IdDroitNavigation { get; set; }


        public override string ToString()
        {

            string valeur = "Nom : " + this.NomUtilisateur;
            valeur += "\nPrenom : " + this.PrenomUtilisateur;
            valeur += "\nEmail : " + this.EmailUtilisateur;
            valeur += "\nDroit : " + this.IdDroit;
            valeur += "\nMot de passe : " + this.MdpUtilisateur;

            return valeur;
        }
    }
}
