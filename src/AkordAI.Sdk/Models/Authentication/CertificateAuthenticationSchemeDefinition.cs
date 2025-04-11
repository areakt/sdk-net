namespace AkordAI.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of a certificate authentication scheme
/// </summary>
[DataContract]
public record CertificateAuthenticationSchemeDefinition
    : AuthenticationSchemeDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.Certificate;

}
