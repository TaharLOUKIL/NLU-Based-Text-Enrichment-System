﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Id
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public String? pattern { get; set; }
        public int minimum { get; set; }
    }

   
}