﻿// Copyright © 2025-Present The AkordAI Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Neuroglia.Serialization.Json;
using YamlDotNet.Core;

namespace AkordAI.Sdk.Serialization.Yaml;

/// <summary>
/// Represents the service used to deserialize <see cref="OneOf{T1, T2}"/>s from YAML
/// </summary>
/// <param name="inner">The inner <see cref="INodeDeserializer"/></param>
public class OneOfScalarDeserializer(INodeDeserializer inner)
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
        if (!Inner.Deserialize(reader, typeof(object), nestedObjectDeserializer, out value, rootDeserializer)) return false;
        value = JsonSerializer.Default.Deserialize(JsonSerializer.Default.SerializeToText(value!), expectedType);
        return true;
    }

}