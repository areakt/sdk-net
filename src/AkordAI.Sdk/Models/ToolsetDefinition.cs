namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a toolset
/// </summary>
[DataContract]
public record ToolsetDefinition
    : ComponentDefinition
{

    /// <summary>
    /// Gets/sets the definition of a toolset based on the Model Context Protocol (MCP)
    /// </summary>
    [DataMember(Name = "mcp", Order = 1), JsonPropertyName("mcp"), JsonPropertyOrder(1), YamlMember(Alias = "mcp", Order = 1)]
    public virtual McpToolsetDefinition? Mcp { get; set; }

    /// <summary>
    /// Gets/sets the definition of a toolset based on an OpenAPI specification document
    /// </summary>
    [DataMember(Name = "openapi", Order = 1), JsonPropertyName("openapi"), JsonPropertyOrder(1), YamlMember(Alias = "openapi", Order = 1)]
    public virtual OpenApiToolsetDefinition? OpenApi { get; set; }

    /// <summary>
    /// Gets the toolset's type based on which definition is present (either MCP or OpenAPI)
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Mcp != null ? ToolsetType.Mcp : OpenApi != null ? ToolsetType.OpenApi : null!;

}
