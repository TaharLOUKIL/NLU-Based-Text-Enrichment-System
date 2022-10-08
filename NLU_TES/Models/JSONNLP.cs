// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class JSONNLP
    {
        [JsonProperty("$schema")]
        public String? Schema { get; set; }
        public String? Title { get; set; }
        public String? Type { get; set; }
        public Definitions? definitions { get; set; }
        public List<String>? Required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties? properties { get; set; }
    }

    public class DCRights
    {
        public String? type { get; set; }
    }

    public class DCSource
    {
        public String? type { get; set; }
        public String? escription { get; set; }
        public List<String>? examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCSubject
    {
        public String? type { get; set; }
    }

    public class DCTitle
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCType
    {
        public String? type { get; set; }
    }

    public class Definition
    {
        public String? type { get; set; }
    }

    public class Definitions
    {
        public Meta? meta { get; set; }
        public TokenIdList tokenIdList { get; set; }
        public TokenIdsWithHead tokenIdsWithHead { get; set; }
        public Grammar grammar { get; set; }
        public NodeIdList nodeIdList { get; set; }
        public Scores scores { get; set; }
        public Features features { get; set; }
        public Misc misc { get; set; }
        public Label label { get; set; }
        public Labels labels { get; set; }
        public Embeddings embeddings { get; set; }
    }

    public class Dependencies
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? description { get; set; }
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Dependency
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public String? pattern { get; set; }
    }

    public class Dependent
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }

    public class Documents
    {
        public String? type { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Dominates
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Embeddings
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public Items? items { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Entities
    {
        public String? type { get; set; }
    }

    public class Entity
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class EntityIob
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class EnumeratedLabeledBracketing
    {
        public String? type { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class Examples
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Expressions
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public String? description { get; set; }
        public Items? items { get; set; }
    }

    public class Features
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public PatternProperties patternProperties { get; set; }
        public bool additionalProperties { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Fragment
    {
        public String? type { get; set; }
        public bool @default { get; set; }
    }

    public class FrameId
    {
        public String? type { get; set; }
    }

    public class Frames
    {
        public String? type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class From
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Governor
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }

    public class Governs
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Grammar
    {
        public String? type { get; set; }
        public List<String> required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties properties { get; set; }
    }

    public class Head
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }

    public class Hypernyms
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Hyponyms
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Id
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public String? pattern { get; set; }
        public int minimum { get; set; }
    }

    public class IndirectObject
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class LabeledBracketing
    {
        public String? type { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class Labels
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public int minItems { get; set; }
        public Items? items { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Lang
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public String? pattern { get; set; }
    }

    public class Lemma
    {
        public String? type { get; set; }
        public String? pattern { get; set; }
    }

    public class MainVerb
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class MCommands
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Meta
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String> required { get; set; }
        public Properties properties { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

   
}