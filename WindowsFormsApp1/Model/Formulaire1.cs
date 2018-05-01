
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_lp
{

    class Formulaire1 : FormulaireAbstract
    {
        /*new public const string id_question_nom_entreprise = "KA17sOqFVIRs";
        public const string id_question_activite = "vT94Udur6LMJ";

        public const string id_question_date_creation = "f3w8Ii7p0VOa";
        public const string id_question_statut_entreprise = "rLCJ9PsJ6sE3";
        public const string id_question_statut_commercial = "ex044se03tDA";
        public const string id_question_adresse1 = "bfyd1jJxP8H7";
        public const string id_question_code_postal = "gxrPRaKSzYpd";
        public const string id_question_commune = "U7ezEa0RKVs9";
        public const string id_question_nom_contact = "S8LVVheHTFP2";
        public const string id_question_prenom_contact = "cCIgtabVm6XW";*/


        new public const string id_question_nom_entreprise = "UAf5QFJ35gGb";
        public const string id_question_secteurs_activite = "ekfAkmQd77ZJ";

        public const string id_question_date_creation = "JekNTYQkC8Up";
        //public const string id_question_statut_entreprise = "U6Zn5SW4ip7M";
        public const string id_question_statut_commercial = "E561CeQ5GMQi";
        public const string id_question_adresse1 = "XR7DYXOSYLkd";
        public const string id_question_code_postal = "Fuagyjr7JxPY";
        public const string id_question_commune = "fa6QmdXeIG2N";
        public const string id_question_nom_contact = "vP87oJuz3xS2";
        public const string id_question_prenom_contact = "Gb8BN5BCl9p0";




        /// <summary>
        /// cette fonction permet de remplir les informations d'une entreprise (par rapport au  Formulaires 1)
        /// </summary>
        /// <param name="info_entreprise"></param>
        /// <param name="landing_id"></param>


        public override void AddInfos(InfoEntreprise info_entreprise, string landing_id)
        {

            info_entreprise.nomEntreprise = getEntrepriseReponses(landing_id, id_question_nom_entreprise).FirstOrDefault();


            info_entreprise.statut_commercial = getEntrepriseReponses(landing_id, id_question_statut_commercial).FirstOrDefault();//facultatif, 
            info_entreprise.nom_contact = getEntrepriseReponses(landing_id, id_question_nom_contact).FirstOrDefault();
            info_entreprise.prenom = getEntrepriseReponses(landing_id, id_question_prenom_contact).FirstOrDefault();
            info_entreprise.ville = getEntrepriseReponses(landing_id, id_question_commune).FirstOrDefault();
            info_entreprise.code_postal = getEntrepriseReponses(landing_id, id_question_code_postal).FirstOrDefault();
            info_entreprise.adresse1 = getEntrepriseReponses(landing_id, id_question_adresse1).FirstOrDefault();

            List<string> activites = getEntrepriseReponses(landing_id, id_question_secteurs_activite);
            if (activites.Count > 0)
            {
                info_entreprise.activites = string.Join(", ", activites);
            }
            //List<string> activites = getEntrepriseReponses(landing_id, id_question_secteurs_activite);
            
            info_entreprise.date_creation = getEntrepriseReponses(landing_id, id_question_date_creation).FirstOrDefault();


        }


    }
}