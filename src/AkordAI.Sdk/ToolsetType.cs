namespace AkordAI.Sdk;

/// <summary>
/// Enumerates all supported toolset types
/// </summary>
public static class ToolsetType
{

    /// <summary>
    /// Indicates a Model Context Protocol toolset
    /// </summary>
    public const string Mcp = "mcp";
    /// <summary>
    /// Indicates an OpenAPI toolset
    /// </summary>
    public const string OpenApi = "openapi";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Mcp;
        yield return OpenApi;
    }

}
