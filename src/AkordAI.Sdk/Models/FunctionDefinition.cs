namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a function
/// </summary>
[DataContract]
public record FunctionDefinition
{

    /// <summary>
    /// Gets/sets the function's prompt template
    /// </summary>
    [Required, MinLength(3)]
    [DataMember(Name = "template", Order = 1), JsonPropertyName("template"), JsonPropertyOrder(1), YamlMember(Alias = "template", Order = 1)]
    public virtual string Template { get; set; } = null!;

    /// <summary>
    /// Gets/sets a list containing the names of the parameters, if any, to exclude from being encoded
    /// </summary>
    [DataMember(Name = "parameters", Order = 2), JsonPropertyName("parameters"), JsonPropertyOrder(2), YamlMember(Alias = "parameters", Order = 2)]
    public virtual EquatableList<string>? Parameters { get; set; }

}