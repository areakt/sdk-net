namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of an HTTP transport for the Model Context Protocol
/// </summary>
[DataContract]
public record McpHttpTransportDefinition
{

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
    [DataMember(Name = "endpoint", Order = 1), JsonInclude, JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    protected virtual OneOf<EndpointDefinition, Uri> EndpointValue { get; set; } = null!;

    /// <summary>
    /// Gets/sets a key/value mapping, if any, of the headers to use to connect to the MCP server
    /// </summary>
    [DataMember(Name = "headers", Order = 2), JsonInclude, JsonPropertyName("headers"), JsonPropertyOrder(2), YamlMember(Alias = "headers", Order = 2)]
    public virtual EquatableDictionary<string, string>? Headers { get; set; }

}
