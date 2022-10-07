// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace JSON_NLP_SCHEMA
{
    public class AdditionalProperties
    {
        public string? Type { get; set; }
        public bool additionalProperties { get; set; }
        public List<string>? Required { get; set; }
        public Properties? Properties { get; set; }

        [JsonProperty("$id")]
        public string? Id { get; set; }

        public string? Description { get; set; }
        public Items? items { get; set; }
    }

    public class AlternatePhrasing
    {
        public string? Type { get; set; }
        public string? Pattern { get; set; }
    }

    public class Antonyms
    {
        public string? Type { get; set; }
        public Items? items { get; set; }
    }

    public class Arcs
    {
        public string? Type { get; set; }
        public string? Description { get; set; }
        public AdditionalProperties? additionalProperties { get; set; }
    }

    public class AZ09AZ09aZAZ09
    {
        public string type { get; set; }
        public string pattern { get; set; }
    }

    public class AZaZ
    {
        public string? Type { get; set; }
    }

    public class Binds
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class CCommands
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class CharacterEmbeddings
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        public string type { get; set; }
        public string description { get; set; }
        public Items items { get; set; }
    }

    public class CharacterOffsetBegin
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class CharacterOffsetEnd
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Children
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class ClassId
    {
        public string type { get; set; }
    }

    public class Clauses
    {
        public string type { get; set; }

        [JsonProperty("$id")]
        public string Id { get; set; }

        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Complex
    {
        public string type { get; set; }
        public bool @default { get; set; }
    }

    public class Compound
    {
        public string type { get; set; }
        public bool @default { get; set; }
    }

    public class Conll
    {
        public string description { get; set; }
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties properties { get; set; }
    }

    public class ConllId
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Constituents
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Coreferences
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Counts
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public Properties properties { get; set; }
    }

    public class DCConformsTo
    {
        public string type { get; set; }
        public string description { get; set; }
        public string pattern { get; set; }
    }

    public class DCContributors
    {
        public string type { get; set; }
    }

    public class DCCoverage
    {
        public string type { get; set; }
    }

    public class DCCreated
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<DateTime> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCCreator
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCDate
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<DateTime> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCDescription
    {
        public string type { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCFormat
    {
        public string type { get; set; }
    }

    public class DCIdentifier
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCLanguage
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCPublisher
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCRelation
    {
        public string type { get; set; }
    }

    public class DCRights
    {
        public string type { get; set; }
    }

    public class DCSource
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCSubject
    {
        public string type { get; set; }
    }

    public class DCTitle
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class DCType
    {
        public string type { get; set; }
    }

    public class Definition
    {
        public string type { get; set; }
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
        public string Id { get; set; }

        public string description { get; set; }
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Dependency
    {
        public string type { get; set; }
        public string description { get; set; }
        public string pattern { get; set; }
    }

    public class Dependent
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Documents
    {
        public string type { get; set; }

        [JsonProperty("$id")]
        public string Id { get; set; }

        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Dominates
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Embeddings
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items items { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Entities
    {
        public string type { get; set; }
    }

    public class Entity
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class EntityIob
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class EnumeratedLabeledBracketing
    {
        public string type { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class Examples
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Expressions
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        public string type { get; set; }
        public string description { get; set; }
        public Items items { get; set; }
    }

    public class Features
    {
        public string description { get; set; }
        public string type { get; set; }
        public PatternProperties patternProperties { get; set; }
        public bool additionalProperties { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Fragment
    {
        public string type { get; set; }
        public bool @default { get; set; }
    }

    public class FrameId
    {
        public string type { get; set; }
    }

    public class Frames
    {
        public string type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class From
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Governor
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Governs
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Grammar
    {
        public string type { get; set; }
        public List<string> required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties properties { get; set; }
    }

    public class Head
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Hypernyms
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Hyponyms
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string description { get; set; }
        public string pattern { get; set; }
        public int minimum { get; set; }
    }

    public class IndirectObject
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Items
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public List<string> required { get; set; }
        public Properties properties { get; set; }
        public Items items { get; set; }

        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Label
    {
        public string type { get; set; }
        public List<string> required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties properties { get; set; }
        public List<string> examples { get; set; }
        public string description { get; set; }
    }

    public class LabeledBracketing
    {
        public string type { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class Labels
    {
        public string description { get; set; }
        public string type { get; set; }
        public int minItems { get; set; }
        public Items items { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Lang
    {
        public string type { get; set; }
        public string description { get; set; }
        public string pattern { get; set; }
    }

    public class Lemma
    {
        public string type { get; set; }
        public string pattern { get; set; }
    }

    public class MainVerb
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class MCommands
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Meta
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public List<string> required { get; set; }
        public Properties properties { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Misc
    {
        public string description { get; set; }
        public string type { get; set; }
        public PatternProperties patternProperties { get; set; }
        public bool additionalProperties { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Modality
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Model
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class Morphemes
    {
        public string type { get; set; }
        public int minItems { get; set; }
        public bool uniqueItems { get; set; }
        public Items items { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
    }

    public class Negated
    {
        public string type { get; set; }
        public bool @default { get; set; }
    }

    public class Neighbors
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class NodeIdList
    {
        public string type { get; set; }
        public string description { get; set; }
        public bool uniqueItems { get; set; }
        public Items items { get; set; }
    }

    public class Nodes
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Object
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Paragraphs
    {
        public string type { get; set; }

        [JsonProperty("$id")]
        public string Id { get; set; }

        public AdditionalProperties additionalProperties { get; set; }
    }

    public class ParentClauseId
    {
        public string? Type { get; set; }
        public string? Description { get; set; }
    }

    public class PatternProperties
    {
        private const string patron = "^[A-Z0-9][A-Z0-9a-z]*([[a-z0-9]+])?$";

        [JsonProperty("^[A-Za-z]+$")]
        public AZaZ? aZaZ { get; set; }

        [JsonProperty(patron)]
        public AZ09AZ09aZAZ09? aZ09AZ09aZAZ09 { get; set; }
    }

    public class Phrase
    {
        [JsonProperty("$ref")]
        public string? Ref { get; set; }
    }

    public class Precedes
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Predicate
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
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
        public Root root { get; set; }
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
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Relations
    {
        public string type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Representative
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public List<string> required { get; set; }
        public Properties properties { get; set; }
    }

    public class JSONNLPModel
    {
        [JsonProperty("$schema")]
        public string Schema { get; set; }

        public string title { get; set; }
        public string type { get; set; }
        public Definitions definitions { get; set; }
        public List<string> required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties properties { get; set; }
    }

    public class Root2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Scopes
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Scores
    {
        public string description { get; set; }
        public string type { get; set; }
        public PatternProperties patternProperties { get; set; }
        public bool additionalProperties { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Semantic
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class SentenceId
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class SentenceIds
    {
        public string description { get; set; }
        public string type { get; set; }
        public bool @default { get; set; }
    }

    public class Sentences
    {
        public string type { get; set; }

        [JsonProperty("$id")]
        public string Id { get; set; }

        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Shape
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class Speaker
    {
        public string type { get; set; }
        public List<string> examples { get; set; }
    }

    public class Stem
    {
        public string type { get; set; }
        public string pattern { get; set; }
    }

    public class Style
    {
        public string type { get; set; }
        public List<string> examples { get; set; }
    }

    public class Subject
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Synonyms
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Synsets
    {
        public string type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Tense
    {
        public string type { get; set; }
        public string pattern { get; set; }
    }

    public class Text
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class To
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class TokenFrom
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class TokenId
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class TokenIdList
    {
        public string type { get; set; }
        public string description { get; set; }
        public int minItems { get; set; }
        public bool uniqueItems { get; set; }
        public Items items { get; set; }
    }

    public class TokenIdsWithHead
    {
        public string type { get; set; }
        public bool additionalProperties { get; set; }
        public List<string> required { get; set; }
        public Properties properties { get; set; }
    }

    public class TokenList
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        public string type { get; set; }
        public string description { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Tokens
    {
        public string type { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }

        public Items items { get; set; }
        public int minItems { get; set; }
    }

    public class TokenTo
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Transitivity
    {
        public string type { get; set; }
        public string pattern { get; set; }
    }

    public class Translations
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Type
    {
        public string type { get; set; }
        public string pattern { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
    }

    public class Upos
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class Vector
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class VerbFrames
    {
        public string type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class WordnetId
    {
        public string type { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }

    public class Xpos
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string pattern { get; set; }
    }
}