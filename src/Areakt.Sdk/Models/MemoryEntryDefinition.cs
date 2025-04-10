namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of a memory entry
/// </summary>
[DataContract]
public record MemoryEntryDefinition
{

    /// <summary>
    /// Gets/sets the actual content or message of the memory entry
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "content", Order = 1), JsonPropertyName("content"), JsonPropertyOrder(1), YamlMember(Alias = "content", Order = 1)]
    public virtual string Content { get; set; } = null!;

    /// <summary>
    /// Gets/sets a list of tags associated with the memory entry
    /// </summary>
    [DataMember(Name = "metadata", Order = 2), JsonPropertyName("metadata"), JsonPropertyOrder(2), YamlMember(Alias = "metadata", Order = 2)]
    public virtual MemoryEntryMetadata? Metadata { get; set; }

}
