namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of a static memory
/// </summary>
[DataContract]
public record StaticMemoryDefinition
{

    /// <summary>
    /// Gets/sets a list of memory entries that will always be returned, typically pre-defined messages such as instructions or role definitions.
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "entries", Order = 1), JsonPropertyName("entries"), JsonPropertyOrder(1), YamlMember(Alias = "entries", Order = 1)]
    public virtual EquatableList<MemoryEntryDefinition>? Entries { get; set; } = null!;

}
