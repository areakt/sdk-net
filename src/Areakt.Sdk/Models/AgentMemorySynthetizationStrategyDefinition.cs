namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of a strategy that defines how an agent should synthesize its output before storing it into memory
/// </summary>
[DataContract]
public record AgentMemorySynthetizationStrategyDefinition
{

    /// <summary>
    /// Gets/sets the name of the function used to perform the synthesis
    /// </summary>
    [Required]
    [DataMember(Name = "function", Order = 1), JsonPropertyName("function"), JsonPropertyOrder(1), YamlMember(Alias = "function", Order = 1)]
    public virtual FunctionDefinition Function { get; set; } = null!;

}
