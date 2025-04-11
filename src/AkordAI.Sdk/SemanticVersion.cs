namespace AkordAI.Sdk;

/// <summary>
/// Exposes constants and helpers to handle semantic versions
/// </summary>
public static class SemanticVersion
{

    /// <summary>
    /// Gets the Regex pattern used to validate semantic versions
    /// </summary>
    public const string Pattern = "^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a-zA-Z-]+)*))?$";

}
