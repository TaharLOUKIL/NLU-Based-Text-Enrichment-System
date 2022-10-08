// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Counts
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties? properties { get; set; }
    }

   
}