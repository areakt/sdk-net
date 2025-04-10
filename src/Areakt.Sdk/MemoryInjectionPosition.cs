namespace Areakt.Sdk;

/// <summary>
/// Enumerates all supported memory injection positions
/// </summary>
public static class MemoryInjectionPosition
{

    /// <summary>
    /// Indicates that memory is injected after the prompt it enriches
    /// </summary>
    public const string After = "after";
    /// <summary>
    /// Indicates that memory is injected before the prompt it enriches
    /// </summary>
    public const string Before = "before";
    /// <summary>
    /// Indicates that memory is injected at the bottom of the system prompt
    /// </summary>
    public const string System = "system";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return After;
        yield return Before;
        yield return System;
    }

}