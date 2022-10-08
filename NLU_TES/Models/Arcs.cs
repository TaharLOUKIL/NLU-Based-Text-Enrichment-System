// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Arcs
    {
        public String? Type { get; set; }
        public String? Description { get; set; }
        public AdditionalProperties? additionalProperties { get; set; }
    }
}