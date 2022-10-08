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

    public class Binds
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class CCommands
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class CharacterEmbeddings
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public String? description { get; set; }
        public Items? items { get; set; }
    }

    public class CharacterOffsetBegin
    {
        public String? Type { get; set; }
        public String? Description { get; set; }
    }

    public class CharacterOffsetEnd
    {
        public String? Type { get; set; }
        public String? Description { get; set; }
    }

    public class Children
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class ClassId
    {
        public String? Type { get; set; }
    }

    public class Clauses
    {
        public String? Type { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        public AdditionalProperties? additionalProperties { get; set; }
    }

    public class Complex
    {
        public String? Type { get; set; }
        public bool @default { get; set; }
    }

    public class Compound
    {
        public String? Type { get; set; }
        public bool @default { get; set; }
    }

    public class Conll
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties? properties { get; set; }
    }

    public class ConllId
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }

    public class Constituents
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Coreferences
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Counts
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties? properties { get; set; }
    }

    public class DCConformsTo
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public String? pattern { get; set; }
    }

    public class DCContributors
    {
        public String? type { get; set; }
    }

    public class DCCoverage
    {
        public String? type { get; set; }
    }

    public class DCCreated
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<DateTime>? examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCCreator
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCDate
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<DateTime> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCDescription
    {
        public String? type { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCFormat
    {
        public String? type { get; set; }
    }

    public class DCIdentifier
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCLanguage
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCPublisher
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class DCRelation
    {
        public String? type { get; set; }
    }

    public class DCRights
    {
        public String? type { get; set; }
    }

    public class DCSource
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
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

    public class Items
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String> required { get; set; }
        public Properties properties { get; set; }
        public Items? items { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Label
    {
        public String? type { get; set; }
        public List<String> required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties properties { get; set; }
        public List<String> examples { get; set; }
        public String? description { get; set; }
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

    public class Misc
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public PatternProperties patternProperties { get; set; }
        public bool additionalProperties { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Modality
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Model
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class Morphemes
    {
        public String? type { get; set; }
        public int minItems { get; set; }
        public bool uniqueItems { get; set; }
        public Items? items { get; set; }
    }

    public class Name
    {
        public String? type { get; set; }
    }

    public class Negated
    {
        public String? type { get; set; }
        public bool @default { get; set; }
    }

    public class Neighbors
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class NodeIdList
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public bool uniqueItems { get; set; }
        public Items? items { get; set; }
    }

    public class Nodes
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Object
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Paragraphs
    {
        public String? type { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        public AdditionalProperties? additionalProperties { get; set; }
    }

    public class ParentClauseId
    {
        public String? Type { get; set; }
        public String? Description { get; set; }
    }

    public class PatternProperties
    {
        private const String? patron = "^[A-Z0-9][A-Z0-9a-z]*([[a-z0-9]+])?$";

        [JsonProperty("^[A-Za-z]+$")]
        public AZaZ? aZaZ { get; set; }

        [JsonProperty(patron)]
        public AZ09AZ09aZAZ09? aZ09AZ09aZAZ09 { get; set; }
    }

    public class Phrase
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Precedes
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Predicate
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Properties
    {
        [JsonProperty("DC.conformsTo")]
        public DCConformsTo DCConformsTo { get; set; }

        [JsonProperty("DC.source")]
        public DCSource DCSource { get; set; }

        [JsonProperty("DC.created")]
        public DCCreated DCCreated { get; set; }

        [JsonProperty("DC.date")]
        public DCDate DCDate { get; set; }

        [JsonProperty("DC.creator")]
        public DCCreator DCCreator { get; set; }

        [JsonProperty("DC.publisher")]
        public DCPublisher DCPublisher { get; set; }

        [JsonProperty("DC.title")]
        public DCTitle DCTitle { get; set; }

        [JsonProperty("DC.description")]
        public DCDescription DCDescription { get; set; }

        [JsonProperty("DC.identifier")]
        public DCIdentifier DCIdentifier { get; set; }

        [JsonProperty("DC.language")]
        public DCLanguage DCLanguage { get; set; }

        [JsonProperty("DC.subject")]
        public DCSubject DCSubject { get; set; }

        [JsonProperty("DC.contributors")]
        public DCContributors DCContributors { get; set; }

        [JsonProperty("DC.type")]
        public DCType DCType { get; set; }

        [JsonProperty("DC.format")]
        public DCFormat DCFormat { get; set; }

        [JsonProperty("DC.relation")]
        public DCRelation DCRelation { get; set; }

        [JsonProperty("DC.coverage")]
        public DCCoverage DCCoverage { get; set; }

        [JsonProperty("DC.rights")]
        public DCRights DCRights { get; set; }

        public Counts counts { get; set; }
        public Id id { get; set; }
        public ConllId conllId { get; set; }
        public Tokens tokens { get; set; }
        public Embeddings embeddings { get; set; }
        public Features features { get; set; }
        public Scores scores { get; set; }
        public Labels labels { get; set; }
        public Text text { get; set; }
        public Translations translations { get; set; }
        public Tense tense { get; set; }
        public Transitivity transitivity { get; set; }
        public Negated negated { get; set; }
        public JSONNLP? JsonNlp { get; set; }
        public MainVerb mainVerb { get; set; }
        public Subject subject { get; set; }
        public Object @object { get; set; }
        public IndirectObject indirectObject { get; set; }
        public TokenFrom tokenFrom { get; set; }
        public TokenTo tokenTo { get; set; }
        public Complex complex { get; set; }
        public Compound compound { get; set; }
        public Fragment fragment { get; set; }
        public Type type { get; set; }
        public Lang lang { get; set; }
        public SentenceId sentenceId { get; set; }
        public ParentClauseId parentClauseId { get; set; }
        public Misc misc { get; set; }
        public Lemma lemma { get; set; }
        public Stem stem { get; set; }
        public CharacterOffsetBegin characterOffsetBegin { get; set; }
        public CharacterOffsetEnd characterOffsetEnd { get; set; }
        public Upos upos { get; set; }
        public Xpos xpos { get; set; }
        public Morphemes morphemes { get; set; }
        public Shape shape { get; set; }
        public Entity entity { get; set; }
        public EntityIob entity_iob { get; set; }
        public Speaker speaker { get; set; }
        public Synsets synsets { get; set; }
        public VerbFrames verbFrames { get; set; }
        public Frames frames { get; set; }
        public CharacterEmbeddings characterEmbeddings { get; set; }
        public WordnetId wordnetId { get; set; }
        public Neighbors neighbors { get; set; }
        public Synonyms synonyms { get; set; }
        public Antonyms antonyms { get; set; }
        public Hypernyms hypernyms { get; set; }
        public Hyponyms hyponyms { get; set; }
        public Examples examples { get; set; }
        public Definition definition { get; set; }
        public ClassId classId { get; set; }
        public Name name { get; set; }
        public FrameId frameId { get; set; }
        public Model model { get; set; }
        public Vector vector { get; set; }
        public Style style { get; set; }
        public Arcs arcs { get; set; }
        public Sentences sentences { get; set; }
        public Clauses clauses { get; set; }
        public Paragraphs paragraphs { get; set; }
        public Documents documents { get; set; }
        public Entities entities { get; set; }
        public Label label { get; set; }
        public Governor governor { get; set; }
        public Dependent dependent { get; set; }
        public Representative representative { get; set; }
        public Referents referents { get; set; }
        public Head head { get; set; }
        public LabeledBracketing labeledBracketing { get; set; }
        public EnumeratedLabeledBracketing enumeratedLabeledBracketing { get; set; }
        public Nodes nodes { get; set; }
        public TokenId tokenId { get; set; }
        public Children children { get; set; }
        public Dominates dominates { get; set; }
        public Precedes precedes { get; set; }
        public Scopes scopes { get; set; }
        public CCommands cCommands { get; set; }
        public MCommands mCommands { get; set; }
        public Binds binds { get; set; }
        public Governs governs { get; set; }
        public AlternatePhrasing alternatePhrasing { get; set; }
        public Dependency dependency { get; set; }
        public Predicate predicate { get; set; }
        public From from { get; set; }
        public To to { get; set; }
        public Modality modality { get; set; }
        public Semantic semantic { get; set; }
        public Phrase phrase { get; set; }
        public Meta meta { get; set; }
        public Conll conll { get; set; }
        public SentenceIds sentence_ids { get; set; }
        public TokenList tokenList { get; set; }
        public Dependencies dependencies { get; set; }
        public Coreferences coreferences { get; set; }
        public Constituents constituents { get; set; }
        public Expressions expressions { get; set; }
        public Relations relations { get; set; }
    }

    public class Referents
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Relations
    {
        public String? type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Representative
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String> required { get; set; }
        public Properties properties { get; set; }
    }

  

    public class Root2
    {
        public String? description { get; set; }
        public String? type { get; set; }
    }

    public class Scopes
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Scores
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public PatternProperties patternProperties { get; set; }
        public bool additionalProperties { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Semantic
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class SentenceId
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }

    public class SentenceIds
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public bool @default { get; set; }
    }

    public class Sentences
    {
        public String? type { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Shape
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class Speaker
    {
        public String? type { get; set; }
        public List<String> examples { get; set; }
    }

    public class Stem
    {
        public String? type { get; set; }
        public String? pattern { get; set; }
    }

    public class Style
    {
        public String? type { get; set; }
        public List<String> examples { get; set; }
    }

    public class Subject
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class Synonyms
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Synsets
    {
        public String? type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Tense
    {
        public String? type { get; set; }
        public String? pattern { get; set; }
    }

    public class Text
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class To
    {
        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

    public class TokenFrom
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }

    public class TokenId
    {
        public String? description { get; set; }
        public String? type { get; set; }
    }

    public class TokenIdList
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public int minItems { get; set; }
        public bool uniqueItems { get; set; }
        public Items? items { get; set; }
    }

    public class TokenIdsWithHead
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String> required { get; set; }
        public Properties properties { get; set; }
    }

    public class TokenList
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public String? description { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Tokens
    {
        public String? type { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }

        public Items? items { get; set; }
        public int minItems { get; set; }
    }

    public class TokenTo
    {
        public String? type { get; set; }
        public String? description { get; set; }
    }

    public class Transitivity
    {
        public String? type { get; set; }
        public String? pattern { get; set; }
    }

    public class Translations
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class Type
    {
        public String? type { get; set; }
        public String? pattern { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
    }

    public class Upos
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class Vector
    {
        public String? type { get; set; }
        public Items? items { get; set; }
    }

    public class VerbFrames
    {
        public String? type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class WordnetId
    {
        public String? type { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }

    public class Xpos
    {
        public String? type { get; set; }
        public String? description { get; set; }
        public List<String> examples { get; set; }
        public String? pattern { get; set; }
    }
}