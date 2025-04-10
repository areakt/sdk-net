namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of an STDIO transport for the Model Context Protocol
/// </summary>
[DataContract]
public record McpStdioTransportDefinition
{

    /// <summary>
    /// Gets/sets the Command to execute the MCP tool
    /// </summary>
    [Required]
    [DataMember(Name = "command", Order = 1), JsonInclude, JsonPropertyName("command"), JsonPropertyOrder(1), YamlMember(Alias = "command", Order = 1)]
    public virtual string Command { get; set; } = null!;

    /// <summary>
    /// Gets/sets a list of arguments, if any, to pass to the command.
    /// </summary>
    [DataMember(Name = "args", Order = 2), JsonInclude, JsonPropertyName("args"), JsonPropertyOrder(2), YamlMember(Alias = "args", Order = 2)]
    public virtual EquatableList<string>? Args { get; set; }

}
