// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Nodes
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

   
}