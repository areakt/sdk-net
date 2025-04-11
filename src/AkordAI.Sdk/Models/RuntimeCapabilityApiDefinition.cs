namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of the API used by a runtime capability
/// </summary>
[DataContract]
public record RuntimeCapabilityApiDefinition
{

    /// <summary>
    /// Gets/sets the API's endpoint
    /// </summary>
    [Required]
    [DataMember(Name = "endpoint", Order = 1), JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual EndpointDefinition Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets/sets a key/value mapping of the additional properties required, if any, to configure the API
    /// </summary>
    [DataMember(Name = "properties", Order = 2), JsonPropertyName("properties"), JsonPropertyOrder(2), YamlMember(Alias = "properties", Order = 2)]
    public virtual EquatableDictionary<string, object>? Properties { get; set; }

}