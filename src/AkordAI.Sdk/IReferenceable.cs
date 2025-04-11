namespace AkordAI.Sdk;

/// <summary>
/// Defines the fundamentals of a referencing object
/// </summary>
public interface IReferenceable
{

    /// <summary>
    /// Gets an URI, if any, that references the object's definition
    /// </summary>
    Uri? Use { get; }

}
