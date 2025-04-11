namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a toolset based on an OpenAPI specification document
/// </summary>
[DataContract]
public record OpenApiToolsetDefinition
{

    /// <summary>
    /// Gets/sets the OpenAPI document to use
    /// </summary>
    [Required]
    [DataMember(Name = "document", Order = 1), JsonPropertyName("document"), JsonPropertyOrder(1), YamlMember(Alias = "document", Order = 1)]
    public virtual ExternalResourceDefinition Document { get; set; } = null!;

}
