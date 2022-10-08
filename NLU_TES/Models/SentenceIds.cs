// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class SentenceIds
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public bool @default { get; set; }
    }

   
}