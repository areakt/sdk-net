namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a strategy that defines how an agent should resolve the metadata of memory entries
/// </summary>
[DataContract]
public record AgentMemoryMetadataResolutionStrategyDefinition
{

    /// <summary>
    /// Gets/sets the name of the function used to perform the synthesis
    /// </summary>
    [Required]
    [DataMember(Name = "function", Order = 1), JsonPropertyName("function"), JsonPropertyOrder(1), YamlMember(Alias = "function", Order = 1)]
    public virtual FunctionDefinition Function { get; set; } = null!;

}
