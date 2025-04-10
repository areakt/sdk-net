namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of the metadata of the memory entries produced by an agent's output
/// </summary>
[DataContract]
public record AgentMemoryEntryMetadataDefinition
{

    /// <summary>
    /// Gets/sets the definition of the strategy, if any, used to dynamically resolve the metadata of a memory entry
    /// </summary>
    [DataMember(Name = "resolution", Order = 1), JsonPropertyName("resolution"), JsonPropertyOrder(1), YamlMember(Alias = "resolution", Order = 1)]
    public virtual AgentMemoryEntryMetadataDefinition? Resolution { get; set; }

    /// <summary>
    /// Gets/sets the static values to use when initializing a memory entry produced by the agent
    /// </summary>
    [DataMember(Name = "values", Order = 2), JsonPropertyName("values"), JsonPropertyOrder(2), YamlMember(Alias = "values", Order = 2)]
    public virtual MemoryEntryMetadata? Values { get; set; }

}
