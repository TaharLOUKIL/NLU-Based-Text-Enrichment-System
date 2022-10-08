// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class NodeIdList
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public bool uniqueItems { get; set; }
        public Items? items { get; set; }
    }

   
}