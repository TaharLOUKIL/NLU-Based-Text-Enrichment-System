﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class Speaker
    {
        public String? type { get; set; }
        public List<String>? examples { get; set; }
    }

   
}