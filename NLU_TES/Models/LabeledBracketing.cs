﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace NLU_Aggregator.Models
{
    public class LabeledBracketing
    {
        public String? type { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

   
}