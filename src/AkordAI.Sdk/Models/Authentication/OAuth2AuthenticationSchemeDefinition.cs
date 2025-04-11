namespace AkordAI.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of an OAUTH2 authentication scheme
/// </summary>
[DataContract]
public record OAuth2AuthenticationSchemeDefinition
    : OAuth2AuthenticationSchemeDefinitionBase
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.OAuth2;

    /// <summary>
    /// Gets/sets the configuration of the OAUTH2 endpoints to use
    /// </summary>
    [DataMember(Name = "endpoints", Order = 2), JsonPropertyName("endpoints"), JsonPropertyOrder(2), YamlMember(Alias = "endpoints", Order = 2)]
    public virtual OAuth2AuthenticationEndpointsDefinition Endpoints { get; set; } = new();

}
