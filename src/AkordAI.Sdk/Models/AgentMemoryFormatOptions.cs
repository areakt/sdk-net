namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents an object used to define how matched memory entries are rendered into the prompt,
/// </summary>
[DataContract]
public record AgentMemoryFormatOptions
{

    /// <summary>
    /// Gets/sets a value that indicates where to inject the entries into the prompt
    /// </summary>
    [AllowedValues(MemoryInjectionPosition.After, MemoryInjectionPosition.Before, MemoryInjectionPosition.System), DefaultValue(MemoryInjectionPosition.After)]
    [DataMember(Name = "position", Order = 1), JsonPropertyName("position"), JsonPropertyOrder(1), YamlMember(Alias = "position", Order = 1)]
    public virtual string? Position { get; set; }

    /// <summary>
    /// Gets/sets the optional template to apply per memory entry (e.g., "- {{ content }}").
    /// </summary>
    [DataMember(Name = "template", Order = 2), JsonPropertyName("template"), JsonPropertyOrder(2), YamlMember(Alias = "template", Order = 2)]
    public virtual string? Template { get; set; }

    /// <summary>
    /// Gets/sets the separator to use between formatted memory entries
    /// </summary>
    [DefaultValue(AkordAIDefaults.MemoryEntrySeparator)]
    [DataMember(Name = "separator", Order = 3), JsonPropertyName("separator"), JsonPropertyOrder(3), YamlMember(Alias = "separator", Order = 3)]
    public virtual string? Separator { get; set; }

}