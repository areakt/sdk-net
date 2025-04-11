namespace AkordAI.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of an OAUTH2 token
/// </summary>
[DataContract]
public record OAuth2TokenDefinition
{

    /// <summary>
    /// Gets/sets the security token to use
    /// </summary>
    [DataMember(Name = "token", Order = 1), JsonPropertyName("token"), JsonPropertyOrder(1), YamlMember(Alias = "token", Order = 1)]
    public required virtual string Token { get; set; }

    /// <summary>
    /// Gets/sets the type of security token to use
    /// </summary>
    [DataMember(Name = "type", Order = 2), JsonPropertyName("type"), JsonPropertyOrder(2), YamlMember(Alias = "type", Order = 2)]
    public required virtual string Type { get; set; }

}