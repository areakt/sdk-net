namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a file-backed memory
/// </summary>
[DataContract]
public record FileMemoryDefinition
{

    /// <summary>
    /// Gets/sets the path to the directory used as the memory source
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "path", Order = 1), JsonPropertyName("path"), JsonPropertyOrder(1), YamlMember(Alias = "path", Order = 1)]
    public virtual string Path { get; set; } = null!;

    /// <summary>
    /// Gets/sets the optional file glob pattern to match files in the directory
    /// </summary>
    [DataMember(Name = "pattern", Order = 2), JsonPropertyName("pattern"), JsonPropertyOrder(2), YamlMember(Alias = "pattern", Order = 2)]
    public virtual string? Pattern { get; set; }

}
