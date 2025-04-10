namespace Areakt.Sdk;

/// <summary>
/// Enumerates all supported MCP transport types
/// </summary>
public static class McpTransportType
{

    /// <summary>
    /// Indicates the HTTP transport type
    /// </summary>
    public const string Http = "http";
    /// <summary>
    /// Indicates an STDIO transport type
    /// </summary>
    public const string Stdio = "stdio";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Http;
        yield return Stdio;
    }

}
