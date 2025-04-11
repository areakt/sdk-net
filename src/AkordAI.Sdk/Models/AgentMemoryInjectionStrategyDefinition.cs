namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of the strategy used to enrich an agent's prompt context
/// </summary>
[DataContract]
public record AgentMemoryInjectionStrategyDefinition
{

    /// <summary>
    /// Gets/sets the definition of the search and filtering strategy, if any, to match relevant memory entries
    /// </summary>
    [DataMember(Name = "match", Order = 1), JsonPropertyName("match"), JsonPropertyOrder(1), YamlMember(Alias = "match", Order = 1)]
    public virtual AgentMemorySearchDefinition? Match { get; set; }

    /// <summary>
    /// Gets/sets an object, if any, that defines how the matched memory entries should be formatted and injected
    /// </summary>
    [DataMember(Name = "format", Order = 2), JsonPropertyName("format"), JsonPropertyOrder(2), YamlMember(Alias = "format", Order = 2)]
    public virtual AgentMemoryFormatOptions? Format { get; set; }

}
