namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of the client implementation to use to connect to an MCP server
/// </summary>
[DataContract]
public record McpClientImplementationDefinition
{

    /// <summary>
    /// Gets/sets the client name
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets/sets the version of the client to use 
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "version", Order = 2), JsonPropertyName("version"), JsonPropertyOrder(2), YamlMember(Alias = "version", Order = 2)]
    public virtual string Version { get; set; } = null!;

}