// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Label
    {
        public String? type { get; set; }
        public List<String>? required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties? properties { get; set; }
        public List<String>? examples { get; set; }
        public String? description { get; set; }
    }
}