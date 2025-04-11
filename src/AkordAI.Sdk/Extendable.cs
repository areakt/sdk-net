namespace AkordAI.Sdk;

/// <summary>
/// Represents the base class of extendable objects
/// </summary>
public abstract record Extendable
    : IExtendable
{

    /// <summary>
    /// Gets/sets a key/value mapping of the object's extension data, if any
    /// </summary>
    [DataMember(Name = "extensions", Order = 99), JsonPropertyName("extensions"), JsonPropertyOrder(99), YamlMember(Alias = "extensions", Order = 99)]
    public virtual EquatableDictionary<string, object>? Extensions { get; set; }

}
