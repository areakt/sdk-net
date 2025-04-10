namespace Areakt.Sdk;

/// <summary>
/// Enumerates all supported vector memory providers
/// </summary>
public static class VectorMemoryProvider
{

    /// <summary>
    /// Indicates Chroma
    /// </summary>
    public const string Chroma = "chroma";
    /// <summary>
    /// Indicates Milvus
    /// </summary>
    public const string Milvus = "milvus";
    /// <summary>
    /// Indicates Pinecone
    /// </summary>
    public const string Pinecone = "pinecone";
    /// <summary>
    /// Indicates Qdrant
    /// </summary>
    public const string Qdrant = "qdrant";
    /// <summary>
    /// Indicates Redis
    /// </summary>
    public const string Redis = "redis";
    /// <summary>
    /// Indicates Weaviate
    /// </summary>
    public const string Weaviate = "weaviate";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Chroma;
        yield return Milvus;
        yield return Pinecone;
        yield return Qdrant;
        yield return Redis;
        yield return Weaviate;
    }

}
