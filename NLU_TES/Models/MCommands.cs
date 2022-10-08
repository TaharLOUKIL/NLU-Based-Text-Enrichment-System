// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class MCommands
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

   
}