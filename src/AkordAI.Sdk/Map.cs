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

namespace AkordAI.Sdk;

/// <summary>
/// Represents an ordered key/value map
/// </summary>
/// <typeparam name="TKey">The type of keys to use</typeparam>
/// <typeparam name="TValue">The type of values to use</typeparam>
public record Map<TKey, TValue>
    : ICollection<MapEntry<TKey, TValue>>
    where TKey : notnull
{

    readonly Dictionary<TKey, TValue> _entries = [];

    /// <summary>
    /// Gets an <see cref="IReadOnlyList{T}"/> that contains all the map's keys
    /// </summary>
    public IReadOnlyList<TKey> Keys => [.. _entries.Keys];

    /// <summary>
    /// Gets an <see cref="IReadOnlyList{T}"/> that contains all the map's values
    /// </summary>
    public IReadOnlyList<TValue> Values => [.. _entries.Values];

    /// <inheritdoc/>
    public int Count => _entries.Count;

    /// <inheritdoc/>
    public bool IsReadOnly => ((IDictionary<TKey, TValue>)_entries).IsReadOnly;

    /// <summary>
    /// Gets/sets the value with the specified key
    /// </summary>
    /// <param name="key">Tje key of the value to set</param>
    /// <returns>The value at the specified key</returns>
    public TValue this[TKey key]
    {
        get
        {
            if (!_entries.TryGetValue(key, out TValue? value)) throw new KeyNotFoundException($"The key '{key}' was not found in the map.");
            return value;
        }
        set
        {
            if (!_entries.TryAdd(key, value)) _entries[key] = value;
        }
    }

    /// <summary>
    /// Gets the <see cref="MapEntry{TKey, TValue}"/> with the specified key
    /// </summary>
    /// <param name="key">The key of the <see cref="MapEntry{TKey, TValue}"/> to get</param>
    /// <returns>The <see cref="MapEntry{TKey, TValue}"/> with the specified key</returns>
    public virtual MapEntry<TKey, TValue>? GetEntry(TKey key)
    {
        var kvp = _entries.FirstOrDefault(e => e.Key.Equals(key));
        if (kvp.Key.Equals(default(TKey))) return null;
        else return new(kvp.Key, kvp.Value);
    }

    /// <inheritdoc/>
    public virtual void Add(MapEntry<TKey, TValue> item) => _entries[item.Key] = item.Value;

    /// <inheritdoc/>
    public virtual void Clear() => _entries.Clear();

    /// <inheritdoc/>
    public virtual bool Contains(MapEntry<TKey, TValue> item) => _entries.ContainsKey(item.Key);

    /// <inheritdoc/>
    public virtual void CopyTo(MapEntry<TKey, TValue>[] array, int arrayIndex)
    {
        ArgumentNullException.ThrowIfNull(array);
        ArgumentOutOfRangeException.ThrowIfLessThan(arrayIndex, 0);
        if (arrayIndex + Count > array.Length) throw new ArgumentException("The number of elements in the source collection is greater than the available space from arrayIndex to the end of the destination array.");
        foreach (var entry in this) array[arrayIndex++] = entry;
    }

    /// <inheritdoc/>
    public virtual bool Remove(MapEntry<TKey, TValue> item) => _entries.Remove(item.Key);

    /// <summary>
    /// Attempts to get the value with the specified key
    /// </summary>
    /// <param name="key">The kye of the value to get</param>
    /// <param name="value">The value at the specified key, if any</param>
    /// <returns>A boolean indicating whether or not the map contains the specified key</returns>
    public virtual bool TryGetValue(TKey key, out TValue? value) => _entries.TryGetValue(key, out value);

    /// <inheritdoc/>
    public virtual IEnumerator<MapEntry<TKey, TValue>> GetEnumerator()
    {
        foreach (var kvp in _entries) yield return new(kvp.Key, kvp.Value);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

}
