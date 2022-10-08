using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Properties
    {
        [JsonProperty("DC.conformsTo")]
        public DCConformsTo? DCConformsTo { get; set; }

        [JsonProperty("DC.source")]
        public DCSource? DCSource { get; set; }

        [JsonProperty("DC.created")]
        public DCCreated? DCCreated { get; set; }

        [JsonProperty("DC.date")]
        public DCDate? DCDate { get; set; }

        [JsonProperty("DC.creator")]
        public DCCreator? DCCreator { get; set; }

        [JsonProperty("DC.publisher")]
        public DCPublisher? DCPublisher { get; set; }

        [JsonProperty("DC.title")]
        public DCTitle? DCTitle { get; set; }

        [JsonProperty("DC.description")]
        public DCDescription? DCDescription { get; set; }

        [JsonProperty("DC.identifier")]
        public DCIdentifier? DCIdentifier { get; set; }

        [JsonProperty("DC.language")]
        public DCLanguage? DCLanguage { get; set; }

        [JsonProperty("DC.subject")]
        public DCSubject? DCSubject { get; set; }

        [JsonProperty("DC.contributors")]
        public DCContributors? DCContributors { get; set; }

        [JsonProperty("DC.type")]
        public DCType? DCType { get; set; }

        [JsonProperty("DC.format")]
        public DCFormat? DCFormat { get; set; }

        [JsonProperty("DC.relation")]
        public DCRelation? DCRelation { get; set; }

        [JsonProperty("DC.coverage")]
        public DCCoverage? DCCoverage { get; set; }

        [JsonProperty("DC.rights")]
        public DCRights? DCRights { get; set; }

        public Counts? counts { get; set; }
        public Id? id { get; set; }
        public ConllId? conllId { get; set; }
        public Tokens? tokens { get; set; }
        public Embeddings? embeddings { get; set; }
        public Features? features { get; set; }
        public Scores? scores { get; set; }
        public Labels? labels { get; set; }
        public Text? text { get; set; }
        public Translations? translations { get; set; }
        public Tense? tense { get; set; }
        public Transitivity? transitivity { get; set; }
        public Negated? negated { get; set; }
        public JSONNLP? JsonNlp { get; set; }
        public MainVerb? mainVerb { get; set; }
        public Subject? subject { get; set; }
        public Object? @object { get; set; }
        public IndirectObject? indirectObject { get; set; }
        public TokenFrom? tokenFrom { get; set; }
        public TokenTo? tokenTo { get; set; }
        public Complex? complex { get; set; }
        public Compound? compound { get; set; }
        public Fragment? fragment { get; set; }
        public Type? type { get; set; }
        public Lang? lang { get; set; }
        public SentenceId? sentenceId { get; set; }
        public ParentClauseId? parentClauseId { get; set; }
        public Misc? misc { get; set; }
        public Lemma? lemma { get; set; }
        public Stem? stem { get; set; }
        public CharacterOffsetBegin? characterOffsetBegin { get; set; }
        public CharacterOffsetEnd? characterOffsetEnd { get; set; }
        public Upos? upos { get; set; }
        public Xpos? xpos { get; set; }
        public Morphemes? morphemes { get; set; }
        public Shape? shape { get; set; }
        public Entity? entity { get; set; }
        public EntityIob? entity_iob { get; set; }
        public Speaker? speaker { get; set; }
        public Synsets? synsets { get; set; }
        public VerbFrames? verbFrames { get; set; }
        public Frames? frames { get; set; }
        public CharacterEmbeddings? characterEmbeddings { get; set; }
        public WordnetId? wordnetId { get; set; }
        public Neighbors? neighbors { get; set; }
        public Synonyms? synonyms { get; set; }
        public Antonyms? antonyms { get; set; }
        public Hypernyms? hypernyms { get; set; }
        public Hyponyms? hyponyms { get; set; }
        public Examples? examples { get; set; }
        public Definition? definition { get; set; }
        public ClassId? classId { get; set; }
        public Name? name { get; set; }
        public FrameId? frameId { get; set; }
        public Model? model { get; set; }
        public Vector? vector { get; set; }
        public Style? style { get; set; }
        public Arcs? arcs { get; set; }
        public Sentences? sentences { get; set; }
        public Clauses? clauses { get; set; }
        public Paragraphs? paragraphs { get; set; }
        public Documents? documents { get; set; }
        public Entities? entities { get; set; }
        public Label? label { get; set; }
        public Governor? governor { get; set; }
        public Dependent? dependent { get; set; }
        public Representative? representative { get; set; }
        public Referents? referents { get; set; }
        public Head? head { get; set; }
        public LabeledBracketing? labeledBracketing { get; set; }
        public EnumeratedLabeledBracketing? enumeratedLabeledBracketing { get; set; }
        public Nodes? nodes { get; set; }
        public TokenId? tokenId { get; set; }
        public Children? children { get; set; }
        public Dominates? dominates { get; set; }
        public Precedes? precedes { get; set; }
        public Scopes? scopes { get; set; }
        public CCommands? cCommands { get; set; }
        public MCommands? mCommands { get; set; }
        public Binds? binds { get; set; }
        public Governs? governs { get; set; }
        public AlternatePhrasing? alternatePhrasing { get; set; }
        public Dependency? dependency { get; set; }
        public Predicate? predicate { get; set; }
        public From? from { get; set; }
        public To? to { get; set; }
        public Modality? modality { get; set; }
        public Semantic? semantic { get; set; }
        public Phrase? phrase { get; set; }
        public Meta? meta { get; set; }
        public Conll? conll { get; set; }
        public SentenceIds? sentence_ids { get; set; }
        public TokenList? tokenList { get; set; }
        public Dependencies? dependencies { get; set; }
        public Coreferences? coreferences { get; set; }
        public Constituents? constituents { get; set; }
        public Expressions? expressions { get; set; }
        public Relations? relations { get; set; }
    }
}
