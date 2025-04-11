namespace AkordAI.Sdk;

/// <summary>
/// Enumerates all supported embedding model providers
/// </summary>
public static class EmbeddingModelProvider
{

    /// <summary>
    /// Indicates Azure OpenAI
    /// </summary>
    public const string AzureOpenAI = "azure-openai";
    /// <summary>
    /// Indicates Google Gemini
    /// </summary>
    public const string Gemini = "gemini";
    /// <summary>
    /// Indicates Hugging Face
    /// </summary>
    public const string HuggingFace = "hugging-face";
    /// <summary>
    /// Indicates Mistral AI
    /// </summary>
    public const string MistralAI = "mistral";
    /// <summary>
    /// Indicates Ollama
    /// </summary>
    public const string Ollama = "ollama";
    /// <summary>
    /// Indicates Onnx
    /// </summary>
    public const string Onnx = "onnx";
    /// <summary>
    /// Indicates OpenAI
    /// </summary>
    public const string OpenAI = "openai";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return AzureOpenAI;
        yield return Gemini;
        yield return HuggingFace;
        yield return MistralAI;
        yield return Ollama;
        yield return Onnx;
        yield return OpenAI;
    }

}