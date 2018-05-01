
using System;
using System.Collections.Generic;
using System.Text;

namespace app_lp
{/// <summary>
/// cette classe permet implementer les methodes des deux formulaires
/// </summary>
    abstract class FormulaireAbstract
    {
        public AnswerTypeForm.AnswerObject json_answers { get; set; }



        public abstract void AddInfos(InfoEntreprise info_entreprise, string landing_id);

        /// <summary>
        /// cette foncton verifie si le nom existe dans la liste des informations de l'entreprise
        /// </summary>
        /// <param name="nom">nom de l'entreprise </param>
        /// <returns>InfoEntreprise|null</returns>
        public InfoEntreprise getInfosEntrepriseByNom(string nom)
        {
            foreach (InfoEntreprise item in getInfoEntreprises())
            {
                if (item.nomEntreprise != null)
                {
                    if (item.nomEntreprise.Trim().ToLower().Equals(nom.Trim().ToLower()))
                    {
                        return item;
                    }
                }

            }
            return null;
        }
        /// <summary>
        /// cette fonction récupere la liste des informations des entreprises
        /// </summary>
        /// <returns>une liste</returns>
        public List<InfoEntreprise> getInfoEntreprises()
        {



            List<string> id_list = getEntreprisesIdList();
            List<InfoEntreprise> infos_list = new List<InfoEntreprise>();
            foreach (string id_entreprise in id_list)
            {
                infos_list.Add(getInfoEntreprise(id_entreprise));
            }

            return infos_list;

        }
        /// <summary>
        /// A partir de landing_id, cette fonction retourne les informations d'une entreprise
        /// </summary>
        /// <param name="landing_id"></param>
        /// <returns>info entreprise</returns>

        public InfoEntreprise getInfoEntreprise(string landing_id)
        {

            InfoEntreprise info_entreprise = new InfoEntreprise();


            AddInfos(info_entreprise, landing_id);

            return info_entreprise;
        }

        /// <summary>
        /// cette fonction permet de récuperer la liste des landing_id
        /// </summary>
        /// <returns>une liste de landing_id</returns>
        public List<string> getEntreprisesIdList()
        {
            List<string> list_id_entreprises = new List<string>();
            if (json_answers != null && json_answers.items != null)
            {
                foreach (AnswerTypeForm.Item field in json_answers.items)
                {
                    if (field.answers != null)
                    {
                        if (!list_id_entreprises.Contains(field.landing_id))
                        {
                            list_id_entreprises.Add(field.landing_id);
                        }
                    }
                }
            }
            return list_id_entreprises;
        }

        /// <summary>
        /// cette fonction permet de recupérer les réponses d'une question d'un client
        /// </summary>
        /// <param name="landing_id"></param>
        /// <param name="id_question"></param>
        /// <returns>une liste de reponses de type string  | null</returns>

        public List<string> getEntrepriseReponses(string landing_id, string id_question)
        {
            List<string> mylist = new List<string>();
            if (json_answers != null && json_answers.items != null)
            {
                foreach (AnswerTypeForm.Item field in json_answers.items)
                {
                    if (field.answers != null)
                    {


                        foreach (AnswerTypeForm.Answer answer in field.answers)
                        {

                            if (answer != null && field.landing_id == landing_id && answer.field.id == id_question)
                            {
                                if (answer.choice != null)
                                {
                                    mylist.Add(answer.choice.label);

                                }

                                else if (answer.choices != null)
                                {
                                    if (answer.choices.labels != null)
                                    {
                                        foreach (string choix in answer.choices.labels)
                                        {
                                            mylist.Add(choix);

                                        }
                                    }
                                }

                                if (answer.text != null)
                                {
                                    mylist.Add(answer.text);
                                }

                                if (answer.url != null)
                                {
                                    mylist.Add(answer.url);
                                }

                                if (answer.boolean != null)
                                {

                                    mylist.Add(answer.boolean.ToString());
                                }

                                if (answer.number != null)
                                {
                                    mylist.Add(answer.number.ToString());
                                }

                                if (answer.date != null)
                                {
                                    mylist.Add(answer.date.ToString());
                                }

                                if (answer.email != null)
                                {
                                    mylist.Add(answer.email);
                                }

                                if (answer.file_url != null)
                                {
                                    mylist.Add(answer.file_url);
                                }

                            }

                        }
                    }



                }



            }
            else
            {
                return null;

            }
            return mylist;
        }

        /// <summary>
        /// cette fonction permet de recuperer les noms des entreprises
        /// </summary>
        /// <param name="id_question_nom_entreprise"></param>
        /// <returns> une liste des noms des entreprises </returns>


        public List<string> getNomEntreprises(string id_question_nom_entreprise)
        {
            List<string> nom_entreprises = new List<string>();

            if(json_answers.items == null)
            {
                return null;
            }

            foreach (AnswerTypeForm.Item field in json_answers.items)
            {
                if (field.answers != null)
                {
                    foreach (AnswerTypeForm.Answer answer in field.answers)
                    {
                        if (answer.field.id == id_question_nom_entreprise)
                        {
                            if (answer.text != null)
                            {
                                nom_entreprises.Add(answer.text);

                            }
                        }

                    }
                }
            }
            return nom_entreprises;

        }

        /// <summary>
        /// cette fonction permet de lier les informations des deux formulaires 
        /// puis retourner un objet entreprise
        /// </summary>
        /// <param name="form1"></param>
        /// <param name="form2"></param>
        /// <param name="nom_entreprise"></param>
        /// <returns>infos entreprise</returns>
        public static InfoEntreprise getInfoEntrepriseForm1Form2(Formulaire1 form1, Formulaire2 form2, string nom_entreprise)
        {
            InfoEntreprise entreprise_form1 = form1.getInfosEntrepriseByNom(nom_entreprise);
            InfoEntreprise entreprise_form2 = form2.getInfosEntrepriseByNom(nom_entreprise);
            string landing_id1 = form1.getLandingIdByNom(nom_entreprise);
            string landing_id2 = form2.getLandingIdByNom(nom_entreprise);

            if(landing_id1 == null && landing_id2 == null )
            {
                return null;
            }

            InfoEntreprise merge_info_entreprise = new InfoEntreprise();
            if(landing_id1 != null)
            {
                form1.AddInfos(merge_info_entreprise, landing_id1);
            }
            
            if(landing_id2 != null)
            {
                form2.AddInfos(merge_info_entreprise, landing_id2);
            }
            

            return merge_info_entreprise;
        }

        /// <summary>
        /// cette fonction permet de recuper un landing_id
        /// </summary>
        /// <param name="name"></param>
        /// <returns>landing_id | null</returns>
        public string getLandingIdByNom(string name)
        {
            List<string> landing_id_list = getEntreprisesIdList();
            InfoEntreprise info = new InfoEntreprise();
            foreach (string landing_id in landing_id_list)
            {
                info = getInfoEntreprise(landing_id);
                //item.nomEntreprise.Trim().ToLower().Equals(nom.Trim().ToLower())
                if (info != null && info.nomEntreprise != null && info.nomEntreprise.Trim().ToLower().Equals(name.Trim().ToLower()))

                    return landing_id;
            }
            return null;
        }



    }



}
