﻿namespace Areakt.Sdk.Models;

/// <summary>
/// Represents structured metadata describing a memory entry,
/// </summary>
[DataContract]
public record MemoryEntryMetadata
{

    /// <summary>
    /// Gets/sets the primary topic or subject of the memory entry
    /// </summary>
    [DataMember(Name = "topic", Order = 1), JsonPropertyName("topic"), JsonPropertyOrder(1), YamlMember(Alias = "topic", Order = 1)]
    public virtual string? Topic { get; set; }

    /// <summary>
    /// Gets/sets the category or type of content represented by this entry
    /// </summary>
    [DataMember(Name = "category", Order = 2), JsonPropertyName("category"), JsonPropertyOrder(2), YamlMember(Alias = "category", Order = 2)]
    public virtual string? Category { get; set; }

    /// <summary>
    /// Gets/sets a list of tags, if any, used to annotate or describe the memory entry
    /// </summary>
    [DataMember(Name = "tags", Order = 3), JsonPropertyName("tags"), JsonPropertyOrder(3), YamlMember(Alias = "tags", Order = 3)]
    public virtual EquatableList<string>? Tags { get; set; }

    /// <summary>
    /// Gets/sets the locale or language tag associated with the entry, if applicable
    /// </summary>
    [DataMember(Name = "locale", Order = 4), JsonPropertyName("locale"), JsonPropertyOrder(4), YamlMember(Alias = "locale", Order = 4)]
    public virtual string? Locale { get; set; }

    /// <summary>
    /// Gets/sets additional arbitrary key-value data, if any, associated to the memory entry
    /// </summary>
    [DataMember(Name = "properties", Order = 5), JsonPropertyName("properties"), JsonPropertyOrder(5), YamlMember(Alias = "properties", Order = 5)]
    public virtual EquatableDictionary<string, string>? Properties { get; set; }

}