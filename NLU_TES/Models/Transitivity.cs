// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Transitivity
    {
        public String? type { get; set; }
        public String? pattern { get; set; }
    }
}