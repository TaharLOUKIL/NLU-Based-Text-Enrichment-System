// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class PatternProperties
    {
        private const String? patron = "^[A-Z0-9][A-Z0-9a-z]*([[a-z0-9]+])?$";

        [JsonProperty("^[A-Za-z]+$")]
        public AZaZ? aZaZ { get; set; }

        [JsonProperty(patron)]
        public AZ09AZ09aZAZ09? aZ09AZ09aZAZ09 { get; set; }
    }

   
}