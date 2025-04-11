namespace AkordAI.Sdk;

/// <summary>
/// Enumerates all supported key-value memory providers
/// </summary>
public static class KeyValueMemoryProvider
{

    /// <summary>
    /// Indicates an in-memory key-value store
    /// </summary>
    public const string Memory = "memory";
    /// <summary>
    /// Indicates Redis
    /// </summary>
    public const string Redis = "redis";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Memory;
        yield return Redis;
    }

}
