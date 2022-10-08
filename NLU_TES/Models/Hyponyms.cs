// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Hyponyms
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

   
}