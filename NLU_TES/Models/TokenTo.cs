﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class TokenTo
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }
}