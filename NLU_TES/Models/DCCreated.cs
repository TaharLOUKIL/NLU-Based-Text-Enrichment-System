// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class DCCreated
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<DateTime>? examples { get; set; }
        public String? pattern { get; set; }
    }

   
}