// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using NLU_Aggregator.Models;

namespace NLU_Aggregator.Models
{
    public class JsonNlpEnrichi  : JSONNLP
    {
        public Intents? intents { get; set; }
    }


}