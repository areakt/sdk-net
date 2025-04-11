namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of an agent memory
/// </summary>
[DataContract]
public record AgentMemoryOptions
{

    /// <summary>
    /// Gets/sets the source of the agent's memory
    /// </summary>
    [Required]
    [DataMember(Name = "source", Order = 1), JsonPropertyName("source"), JsonPropertyOrder(1), YamlMember(Alias = "source", Order = 1)]
    public virtual MemoryDefinition Source { get; set; } = null!;

    /// <summary>
    /// Gets/sets an object, if any, that defines how memory is used to enrich the agent's prompt context
    /// </summary>
    [DataMember(Name = "inject", Order = 2), JsonPropertyName("inject"), JsonPropertyOrder(2), YamlMember(Alias = "inject", Order = 2)]
    public virtual AgentMemoryInjectionStrategyDefinition? Inject { get; set; }

    /// <summary>
    /// Gets/sets an object, if any, that defines how the agent's output is persisted to memory
    /// </summary>
    [DataMember(Name = "store", Order = 3), JsonPropertyName("store"), JsonPropertyOrder(3), YamlMember(Alias = "store", Order = 3)]
    public virtual AgentMemoryStoragePolicyDefinition? Store { get; set; }

}
