using Neuroglia.Serialization.Json;
using YamlDotNet.Core;

namespace Areakt.Sdk.Serialization.Yaml;

/// <summary>
/// Represents the service used to deserialize <see cref="OneOf{T1, T2}"/>s from YAML
/// </summary>
/// <param name="inner">The inner <see cref="INodeDeserializer"/></param>
public class OneOfNodeDeserializer(INodeDeserializer inner)
    : INodeDeserializer
{

    /// <summary>
    /// Gets the inner <see cref="INodeDeserializer"/>
    /// </summary>
    protected INodeDeserializer Inner { get; } = inner;

    /// <inheritdoc/>
    public virtual bool Deserialize(IParser reader, Type expectedType, Func<IParser, Type, object?> nestedObjectDeserializer, out object? value, ObjectDeserializer rootDeserializer)
    {
        if (!typeof(IOneOf).IsAssignableFrom(expectedType)) return Inner.Deserialize(reader, expectedType, nestedObjectDeserializer, out value, rootDeserializer);
        if (!Inner.Deserialize(reader, typeof(Dictionary<object, object>), nestedObjectDeserializer, out value, rootDeserializer)) return false;
        value = JsonSerializer.Default.Deserialize(JsonSerializer.Default.SerializeToText(value!), expectedType);
        return true;
    }

}
