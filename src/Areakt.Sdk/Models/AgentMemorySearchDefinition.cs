﻿namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of the search an agent should perform on its memory to enrich its prompt context
/// </summary>
[DataContract]
public record AgentMemorySearchDefinition
{

    /// <summary>
    /// Gets/sets the maximum number, if any, of memory entries to match
    /// </summary>
    [DataMember(Name = "max", Order = 1), JsonPropertyName("max"), JsonPropertyOrder(1), YamlMember(Alias = "max", Order = 1)]
    public virtual int? Max { get; set; }

    /// <summary>
    /// Gets/sets the minimum similarity score required for a vector match (0.0 to 1.0)<para></para>
    /// Only applies to vector memory sources.
    /// </summary>
    [DataMember(Name = "similarity", Order = 2), JsonPropertyName("similarity"), JsonPropertyOrder(2), YamlMember(Alias = "similarity", Order = 2)]
    public virtual float? Similarity { get; set; }

    /// <summary>
    /// Gets/sets the key to retrieve in key-value memory stores, or to pattern-match for file-based memory sources
    /// </summary>
    [DataMember(Name = "key", Order = 3), JsonPropertyName("key"), JsonPropertyOrder(3), YamlMember(Alias = "key", Order = 3)]
    public virtual string? Key { get; set; }

    /// <summary>
    /// Gets/sets the file path or glob pattern used to restrict the search in file-based memory sources
    /// </summary>
    [DataMember(Name = "path", Order = 4), JsonPropertyName("path"), JsonPropertyOrder(4), YamlMember(Alias = "path", Order = 4)]
    public virtual string? Path { get; set; }

    /// <summary>
    /// Gets/sets the list of tags used to filter memory entries
    /// </summary>
    [DataMember(Name = "tags", Order = 5), JsonPropertyName("tags"), JsonPropertyOrder(5), YamlMember(Alias = "tags", Order = 5)]
    public virtual EquatableList<string>? Tags { get; set; }

    /// <summary>
    /// Gets/sets an optional topic used to filter or group memory entries semantically
    /// </summary>
    [DataMember(Name = "topic", Order = 6), JsonPropertyName("topic"), JsonPropertyOrder(6), YamlMember(Alias = "topic", Order = 6)]
    public virtual string? Topic { get; set; }

    /// <summary>
    /// Gets/sets optional metadata filters where keys must match specified values
    /// </summary>
    [DataMember(Name = "filters", Order = 7), JsonPropertyName("filters"), JsonPropertyOrder(7), YamlMember(Alias = "filters", Order = 7)]
    public virtual EquatableDictionary<string, string>? Filters { get; set; }

}
