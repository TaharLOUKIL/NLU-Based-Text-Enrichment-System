// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Definitions
    {
        public Meta? meta { get; set; }
        public TokenIdList? tokenIdList { get; set; }
        public TokenIdsWithHead? tokenIdsWithHead { get; set; }
        public Grammar? grammar { get; set; }
        public NodeIdList? nodeIdList { get; set; }
        public Scores? scores { get; set; }
        public Features? features { get; set; }
        public Misc? misc { get; set; }
        public Label? label { get; set; }
        public Labels? labels { get; set; }
        public Embeddings? embeddings { get; set; }
    }

   
}