namespace AkordAI.Sdk;

/// <summary>
/// Enumerates all supported locations for the placement of an authentication parameter
/// </summary>
public static class AuthenticationParameterPlacementLocation
{

    /// <summary>
    /// Indicates that the authentication parameter is placed in a cookie
    /// </summary>
    public const string Cookie = "cookie";
    /// <summary>
    /// Indicates that the authentication parameter is placed in a header
    /// </summary>
    public const string Header = "header";
    /// <summary>
    /// Indicates that the authentication parameter is placed in the request's query
    /// </summary>
    public const string Query = "query";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Cookie;
        yield return Header;
        yield return Query;
    }

}