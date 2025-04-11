namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of the transport to use to connect to an MCP server
/// </summary>
[DataContract]
public record McpTransportDefinition
{

    /// <summary>
    /// Gets/sets the definition of an HTTP transport for the Model Context Protocol
    /// </summary>
    [DataMember(Name = "http", Order = 1), JsonPropertyName("http"), JsonPropertyOrder(1), YamlMember(Alias = "http", Order = 1)]
    public virtual McpHttpTransportDefinition? Http { get; set; }

    /// <summary>
    /// Gets/sets the definition of an STDIO transport for the Model Context Protocol
    /// </summary>
    [DataMember(Name = "stdio", Order = 1), JsonPropertyName("stdio"), JsonPropertyOrder(1), YamlMember(Alias = "stdio", Order = 1)]
    public virtual McpStdioTransportDefinition? Stdio { get; set; }

    /// <summary>
    /// Gets the MCP transport's type based on which definition is present (either `Http` or `Stdio`)
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Http != null ? McpTransportType.Http : Stdio != null ? McpTransportType.Stdio : null!;

}
