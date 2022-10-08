// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class DCSource
    {
        public String? type { get; set; }
        public String? escription { get; set; }
        public List<String>? examples { get; set; }
        public String? pattern { get; set; }
    }

   
}