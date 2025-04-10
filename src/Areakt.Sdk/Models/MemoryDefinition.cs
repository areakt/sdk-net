namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of a memory capability
/// </summary>
[DataContract]
public record MemoryDefinition
{

    /// <summary>
    /// Gets/sets the definition of a file-backed memory that loads entries from structured files in the local or remote file system
    /// </summary>
    [DataMember(Name = "file", Order = 1), JsonPropertyName("file"), JsonPropertyOrder(1), YamlMember(Alias = "file", Order = 1)]
    public virtual FileMemoryDefinition? File { get; set; }

    /// <summary>
    /// Gets/sets the definition of a key-value store memory that retrieves entries based on keys or tags
    /// </summary>
    [DataMember(Name = "Keyvalue", Order = 1), JsonPropertyName("Keyvalue"), JsonPropertyOrder(1), YamlMember(Alias = "Keyvalue", Order = 1)]
    public virtual KeyValueMemoryDefinition? KeyValue { get; set; }

    /// <summary>
    /// Gets/sets the definition of a static memory that returns predefined values without runtime lookup
    /// </summary>
    [DataMember(Name = "static", Order = 1), JsonPropertyName("static"), JsonPropertyOrder(1), YamlMember(Alias = "static", Order = 1)]
    public virtual StaticMemoryDefinition? Static { get; set; }

    /// <summary>
    /// Gets/sets the definition of a vector memory that retrieves entries using semantic similarity and vector search
    /// </summary>
    [DataMember(Name = "vector", Order = 1), JsonPropertyName("vector"), JsonPropertyOrder(1), YamlMember(Alias = "vector", Order = 1)]
    public virtual VectorMemoryDefinition? Vector { get; set; }

    /// <summary>
    /// Gets the memory's type based on which definition is present
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => File != null ? MemoryType.File : KeyValue != null ? MemoryType.KeyValue : Static != null ? MemoryType.Static : Vector != null ? MemoryType.Vector : null!;

}
