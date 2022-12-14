// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Type
    {
        public String? type { get; set; }
        public String? pattern { get; set; }
        public String? description { get; set; }
        public List<String>? examples { get; set; }
    }
}