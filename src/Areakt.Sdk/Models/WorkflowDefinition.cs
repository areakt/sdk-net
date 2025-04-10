namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the definition of a workflow
/// </summary>
[DataContract]
public record WorkflowDefinition
{

    /// <summary>
    /// Gets/sets the metadata used to describe the workflow
    /// </summary>
    [Required]
    [DataMember(Name = "metadata", Order = 1), JsonPropertyName("metadata"), JsonPropertyOrder(1), YamlMember(Alias = "metadata", Order = 1)]
    public virtual WorkflowDefinitionMetadata Metadata { get; set; } = null!;

    /// <summary>
    /// Gets/sets the workflow's reusable resource collection, if any
    /// </summary>
    [DataMember(Name = "resources", Order = 2), JsonPropertyName("resources"), JsonPropertyOrder(2), YamlMember(Alias = "resources", Order = 2)]
    public virtual ResourceCollectionDefinition? Resources { get; set; }

}
