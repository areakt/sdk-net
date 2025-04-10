using Neuroglia.Serialization.Json;
using Neuroglia.Serialization.Yaml;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace Areakt.Sdk.Serialization.Yaml;

/// <summary>
/// Represents the <see cref="IYamlTypeConverter"/> used to serialize and deserialize <see cref="OneOf{T1, T2}"/> instances
/// </summary>
public class OneOfConverter
    : IYamlTypeConverter
{

    /// <inheritdoc/>
    public virtual bool Accepts(Type type) => type.GetGenericType(typeof(OneOf<,>)) != null;

    /// <inheritdoc/>
    public virtual object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer) => throw new NotImplementedException();

    /// <inheritdoc/>
    public virtual void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer rootSerializer)
    {
        if (value == null || value is not IOneOf oneOf)
        {
            emitter.Emit(new Scalar(null, null, string.Empty));
            return;
        }
        var toSerialize = oneOf.GetValue();
        if (toSerialize == null)
        {
            emitter.Emit(new Scalar(null, null, string.Empty));
            return;
        }
        var jsonNode = JsonSerializer.Default.SerializeToNode(toSerialize);
        new JsonNodeTypeConverter().WriteYaml(emitter, jsonNode, toSerialize.GetType(), rootSerializer);
    }

}