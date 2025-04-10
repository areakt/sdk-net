namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of a key-value store memory
/// </summary>
[DataContract]
public record KeyValueMemoryDefinition
{

    /// <summary>
    /// Gets/sets the name of the key-value memory provider
    /// </summary>
    [Required, AllowedValues(KeyValueMemoryProvider.Memory, KeyValueMemoryProvider.Redis)]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual string Provider { get; set; } = null!;

    /// <summary>
    /// Gets/sets the key-value memory's endpoint
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual EndpointDefinition Endpoint
    {
        get => EndpointValue.T1Value ?? new() { Uri = EndpointUri };
        set => EndpointValue = value;
    }

    /// <summary>
    /// Gets/sets the key-value memory's endpoint
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual Uri EndpointUri
    {
        get => EndpointValue.T1Value?.Uri ?? EndpointValue.T2Value!;
        set => EndpointValue = value;
    }

    /// <summary>
    /// Gets/sets the key-value memory's endpoint
    /// </summary>
    [Required]
    [DataMember(Name = "endpoint", Order = 2), JsonInclude, JsonPropertyName("endpoint"), JsonPropertyOrder(2), YamlMember(Alias = "endpoint", Order = 2)]
    protected virtual OneOf<EndpointDefinition, Uri> EndpointValue { get; set; } = null!;

    /// <summary>
    /// Gets/sets a key/value mapping, if any, of the provider-specific properties used to configure the key-value memory
    /// </summary>
    [DataMember(Name = "configuration", Order = 3), JsonPropertyName("configuration"), JsonPropertyOrder(3), YamlMember(Alias = "configuration", Order = 3)]
    public virtual EquatableDictionary<string, object>? Configuration { get; set; }

}
