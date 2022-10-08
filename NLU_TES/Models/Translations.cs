// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Translations
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }
}