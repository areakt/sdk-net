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

using AkordAI.Sdk.Serialization.Json;

namespace AkordAI.Sdk;

/// <summary>
/// Represents a map entry
/// </summary>
/// <typeparam name="TKey">The type of the entry's key</typeparam>
/// <typeparam name="TValue">The type of the entry's value</typeparam>
[JsonConverter(typeof(MapEntryJsonConverter))]
public record MapEntry<TKey, TValue>
{

    /// <summary>
    /// Initializes a new <see cref="MapEntry{TKey, TValue}"/>
    /// </summary>
    public MapEntry() { }

    /// <summary>
    /// Initializes a new <see cref="MapEntry{TKey, TValue}"/>
    /// </summary>
    /// <param name="key">The entry key</param>
    /// <param name="value">The entry value</param>
    public MapEntry(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    /// <summary>
    /// Gets/sets the entry key
    /// </summary>
    public TKey Key { get; set; } = default!;

    /// <summary>
    /// Gets/sets the entry value
    /// </summary>
    public TValue Value { get; set; } = default!;

}