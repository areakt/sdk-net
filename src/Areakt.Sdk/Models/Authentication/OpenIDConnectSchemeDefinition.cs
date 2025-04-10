namespace Areakt.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of an OpenIDConnect authentication scheme
/// </summary>
[DataContract]
public record OpenIDConnectSchemeDefinition
    : OAuth2AuthenticationSchemeDefinitionBase
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.OpenIDConnect;

}