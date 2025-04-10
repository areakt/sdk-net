namespace Areakt.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of a basic authentication scheme
/// </summary>
[DataContract]
public record BasicAuthenticationSchemeDefinition
    : AuthenticationSchemeDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.Basic;

    /// <summary>
    /// Gets/sets the username used for authentication
    /// </summary>
    [DataMember(Name = "username", Order = 1), JsonPropertyName("username"), JsonPropertyOrder(1), YamlMember(Alias = "username", Order = 1)]
    public virtual string? Username { get; set; }

    /// <summary>
    /// Gets/sets the password used for authentication
    /// </summary>
    [DataMember(Name = "password", Order = 2), JsonPropertyName("password"), JsonPropertyOrder(2), YamlMember(Alias = "password", Order = 2)]
    public virtual string? Password { get; set; }

}
