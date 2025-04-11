namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a collection of reusable resources
/// </summary>
[DataContract]
public record ResourceCollectionDefinition
{

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable toolsets
    /// </summary>
    [DataMember(Name = "toolsets", Order = 1), JsonPropertyName("toolsets"), JsonPropertyOrder(1), YamlMember(Alias = "toolsets", Order = 1)]
    public virtual Map<string, ToolsetDefinition>? Toolsets { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable functions
    /// </summary>
    [DataMember(Name = "functions", Order = 2), JsonPropertyName("functions"), JsonPropertyOrder(2), YamlMember(Alias = "functions", Order = 2)]
    public virtual Map<string, FunctionDefinition>? Functions { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable runtimes
    /// </summary>
    [DataMember(Name = "runtimes", Order = 3), JsonPropertyName("runtimes"), JsonPropertyOrder(3), YamlMember(Alias = "runtimes", Order = 3)]
    public virtual Map<string, RuntimeDefinition>? Runtimes { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable memories
    /// </summary>
    [DataMember(Name = "memories", Order = 4), JsonPropertyName("memories"), JsonPropertyOrder(4), YamlMember(Alias = "memories", Order = 4)]
    public virtual Map<string, MemoryDefinition>? Memories { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable agents
    /// </summary>
    [DataMember(Name = "agents", Order = 5), JsonPropertyName("agents"), JsonPropertyOrder(5), YamlMember(Alias = "agents", Order = 5)]
    public virtual Map<string, AgentDefinition>? Agents { get; set; }

}