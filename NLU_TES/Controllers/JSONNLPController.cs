using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NLU_Aggregator.Models;
using Ocelot.RequestId;
using Ocelot.Responses;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace NLU_Aggregator.Controllers
{
    public class JSONNLPController : Controller
    {
        /// <summary>
        /// Méthode qui se charge de l'appel du borpress NLU pour la détermination des intentions et similarités
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public String Index(string data)
        {

            // 1. Instanciation du modèle principal
            JSONNLP jSONNLP = new JSONNLP();
            jSONNLP.Title = data; 


            // 2. Connexion à la WEBAPI BOTPRESS Datasphera en Production

            string UrlAuth = "https://automation.datasphera.com/api/v1/auth/login/basic/default";
            HttpClient httpClient = new HttpClient();
            var headers = new Dictionary<string, string>();
            string email = "";// Email utilisateur et mot de passe ne sont pas fournit dans ce code source
            string password = "";// ils seront communiqués directement au prof pour débogage
            headers.Add("email", email);
            headers.Add("password", password);

            
            var response = httpClient.PostAsJsonAsync(UrlAuth, headers).Result.Content.ReadAsStringAsync().Result;
            var jsonToken = JObject.Parse(response);


            // 3. extraction des intentions
            
            
            string UrlIntents = "automation.datasphera.com/api/v1/bots/test-bot-one/converse/123456/secured?include=nlu";
            headers.Clear(); // remise à zéro des paramètres
            headers.Add("Content-Type", "application/json");
            headers.Add("Authorization", jsonToken.ToString());

                       
            response = httpClient.PostAsJsonAsync(UrlIntents, headers).Result.Content.ReadAsStringAsync().Result;

            JsonNlpEnrichi? jsonNlpEnrichi = new JsonNlpEnrichi();
            jsonNlpEnrichi = System.Text.Json.JsonSerializer.Deserialize<JsonNlpEnrichi>(response) as JsonNlpEnrichi;//JObject.Parse(response) as JsonNlpEnrichi;

            var Resultat = System.Text.Json.JsonSerializer.Serialize(jsonNlpEnrichi);
           
            return Resultat;
           
        }
        /// <summary>
        /// Validation du Schema JSON NLP
        /// </summary>
        /// <returns></returns>
        Boolean JsonValidate(string JsonData) 
        {
            // extraction du shcema Json du fichier JSON-NLP.schema.json  pour la vlaidation // https://www.jsonschemavalidator.net/

            var JsonSchemaFile = Path.Combine("JSON-NLP.schema.json");
            var r = new StreamReader(JsonSchemaFile);
            var myJsonSchema = r.ReadToEnd();
            JSchema schema = JSchema.Parse(@myJsonSchema);

            // Vérification de la data fournie.
            JObject JsonNlp = JObject.Parse(JsonData);

            bool valid = JsonNlp.IsValid(schema);
            return valid;    
        }
    }
}