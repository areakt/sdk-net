namespace Areakt.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of a bearer authentication scheme
/// </summary>
[DataContract]
public record BearerAuthenticationSchemeDefinition
    : AuthenticationSchemeDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.Bearer;

    /// <summary>
    /// Gets/sets the bearer token used for authentication
    /// </summary>
    [DataMember(Name = "token", Order = 1), JsonPropertyName("token"), JsonPropertyOrder(1), YamlMember(Alias = "token", Order = 1)]
    public virtual string? Token { get; set; }

}
