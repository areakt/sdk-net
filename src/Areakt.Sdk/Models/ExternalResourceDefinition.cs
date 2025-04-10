namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of an external resource
/// </summary>
[DataContract]
public record ExternalResourceDefinition
{

    /// <summary>
    /// Gets/sets the external resource's name, if any
    /// </summary>
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string? Name { get; set; }

    /// <summary>
    /// Gets/sets the endpoint at which to get the defined resource
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual EndpointDefinition Endpoint
    {
        get => EndpointValue.T1Value ?? new() { Uri = EndpointUri };
        set => EndpointValue = value;
    }

    /// <summary>
    /// Gets/sets the endpoint at which to get the defined resource
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual Uri EndpointUri
    {
        get => EndpointValue.T1Value?.Uri ?? EndpointValue.T2Value!;
        set => EndpointValue = value;
    }

    /// <summary>
    /// Gets/sets the endpoint at which to get the defined resource
    /// </summary>
    [Required]
    [DataMember(Name = "endpoint", Order = 2), JsonInclude, JsonPropertyName("endpoint"), JsonPropertyOrder(2), YamlMember(Alias = "endpoint", Order = 2)]
    protected virtual OneOf<EndpointDefinition, Uri> EndpointValue { get; set; } = null!;

}
