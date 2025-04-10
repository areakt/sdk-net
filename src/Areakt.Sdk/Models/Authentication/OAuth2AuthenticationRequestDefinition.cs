namespace Areakt.Sdk.Models.Authentication;

/// <summary>
/// Represents the configuration of an OAUTH2 authentication request
/// </summary>
[DataContract]
public record OAuth2AuthenticationRequestDefinition
{

    /// <summary>
    /// Gets/sets the encoding of the authentication request. Defaults to 'application/x-www-form-urlencoded'. See <see cref="OAuth2RequestEncoding"/>
    /// </summary>
    [DataMember(Name = "encoding", Order = 1), JsonPropertyName("encoding"), JsonPropertyOrder(1), YamlMember(Alias = "encoding", Order = 1)]
    public virtual string Encoding { get; set; } = OAuth2RequestEncoding.FormUrl;

}