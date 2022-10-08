// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class TokenIdList
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public int minItems { get; set; }
        public bool uniqueItems { get; set; }
        public Items? items { get; set; }
    }
}