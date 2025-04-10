namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of an endpoint
/// </summary>
[DataContract]
public record EndpointDefinition
{

    /// <summary>
    /// Gets/sets the endpoint's uri
    /// </summary>
    [Required]
    [DataMember(Name = "uri", Order = 1), JsonPropertyName("uri"), JsonPropertyOrder(1), YamlMember(Alias = "uri", Order = 1)]
    public required virtual Uri Uri { get; set; }

    /// <summary>
    /// Gets/sets the endpoint's authentication policy, if any
    /// </summary>
    [DataMember(Name = "authentication", Order = 2), JsonPropertyName("authentication"), JsonPropertyOrder(2), YamlMember(Alias = "authentication", Order = 2)]
    public virtual AuthenticationPolicyDefinition? Authentication { get; set; }

}
