namespace Areakt.Sdk.Models;

/// <summary>
/// Represents a component definition that can be referenced
/// </summary>
[DataContract]
public abstract record ReferenceableComponentDefinition
    : ComponentDefinition, IReferenceable
{

    /// <summary>
    /// Gets/sets an URI, if any, that reference the component's definition
    /// </summary>
    [DataMember(Order = 0, Name = "use"), JsonPropertyOrder(0), JsonPropertyName("use"), YamlMember(Order = 0, Alias = "use")]
    public virtual Uri? Use { get; set; }

}
