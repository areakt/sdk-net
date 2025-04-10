namespace Areakt.Sdk.Models;

/// <summary>
/// Represents the configuration of a reasoning capability within a runtime environment
/// </summary>
[DataContract]
public record ReasoningCapabilityDefinition
{

    /// <summary>
    /// Gets/sets the identifier of the model provider to use for reasoning
    /// </summary>
    [Required, MinLength(1), AllowedValues(ReasoningModelProvider.AzureOpenAI, ReasoningModelProvider.Gemini, ReasoningModelProvider.HuggingFace, ReasoningModelProvider.MistralAI, ReasoningModelProvider.Ollama, ReasoningModelProvider.Onnx, ReasoningModelProvider.OpenAI)]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual string Provider { get; set; } = null!;

    /// <summary>
    /// Gets/sets the model name to be used for the reasoning operation
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "model", Order = 2), JsonPropertyName("model"), JsonPropertyOrder(2), YamlMember(Alias = "model", Order = 2)]
    public virtual string Model { get; set; } = null!;

    /// <summary>
    /// Gets/sets the definition of the reasoning API to use
    /// </summary>
    [Required]
    [DataMember(Name = "api", Order = 3), JsonPropertyName("api"), JsonPropertyOrder(3), YamlMember(Alias = "api", Order = 3)]
    public virtual RuntimeCapabilityApiDefinition Api { get; set; } = null!;

}
