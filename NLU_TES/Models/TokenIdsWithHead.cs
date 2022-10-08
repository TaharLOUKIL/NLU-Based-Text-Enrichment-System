// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class TokenIdsWithHead
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String>? required { get; set; }
        public Properties? properties { get; set; }
    }
}