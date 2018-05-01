using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace app_lp
{/// <summary>
/// cette classe permet de gérer api
/// </summary>
    class typeFormApi
    {


        public string token { get; set; }


        public typeFormApi(string token)
        {
            this.token = token;
        }



        public async Task<FormTypeForm.FormObject> getForm(string id_form)
        {

            string url = "https://api.typeform.com/forms/" + id_form;
            string outputJson = await getJson(url, token);

            FormTypeForm.FormObject res = JsonConvert.DeserializeObject<FormTypeForm.FormObject>(outputJson);


            return res;
        }

        public async static Task<AnswerTypeForm.AnswerObject> getAnswers(string token, string id_form)
        {


            string url = "https://api.typeform.com/forms/" + id_form + "/responses";


            string outputJson = await getJson(url, token);
            AnswerTypeForm.AnswerObject res = JsonConvert.DeserializeObject<AnswerTypeForm.AnswerObject>(outputJson);
            return res;

        }

        public async static Task<string> getJson(string url, string token)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("authorization", "bearer " + token);

                var response = await client.GetAsync(url);
                Task<string> responseString = response.Content.ReadAsStringAsync();
                string outputJson = await responseString;
                return outputJson;
            }
        }

        /*public List<string> getQuestions(string id_form)
        {
            List<string> questions = new List<string>();


            FormTypeForm.RootObject json_form = getForm(id_form).Result;
            foreach (FormTypeForm.Field field in json_form.fields)
            {

                if (field.title != null)
                {
                    questions.Add(field.title);
                    Console.WriteLine("Question: " + field.title + " : " + field.id + "\n");
                }
                if (field.properties != null && field.properties.fields != null)
                {


                    foreach (FormTypeForm.Field sous_question in field.properties.fields)
                    {
                        questions.Add(sous_question.title);

                        Console.WriteLine("Question: " + sous_question.title + " : " + sous_question.id);


                    }

                }

            }
            return questions;
        }*/

    }
}