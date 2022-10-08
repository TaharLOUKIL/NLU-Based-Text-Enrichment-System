// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Conll
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties? properties { get; set; }
    }

   
}