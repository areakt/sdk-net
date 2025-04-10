namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the configuration of a runtime system capable of performing AI inference operations, such as language model completions, chat interactions, or vector embeddings
/// </summary>
[DataContract]
public record RuntimeDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets/sets the uri of the runtime definition to extend, if any
    /// </summary>
    [DataMember(Name = "extends", Order = 1), JsonPropertyName("extends"), JsonPropertyOrder(1), YamlMember(Alias = "extends", Order = 1)]
    public virtual Uri? Extends { get; set; }

    /// <summary>
    /// Gets/sets the configuration of the runtime's reasoning capability, if any
    /// </summary>
    [DataMember(Name = "reasoning", Order = 2), JsonPropertyName("reasoning"), JsonPropertyOrder(2), YamlMember(Alias = "reasoning", Order = 2)]
    public virtual ReasoningCapabilityDefinition? Reasoning { get; set; }

    /// <summary>
    /// Gets/sets the configuration of the runtime's embedding capability, if any
    /// </summary>
    [DataMember(Name = "embedding", Order = 3), JsonPropertyName("embedding"), JsonPropertyOrder(3), YamlMember(Alias = "embedding", Order = 3)]
    public virtual EmbeddingCapabilityDefinition? Embedding { get; set; }

}
