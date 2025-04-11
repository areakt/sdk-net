// Copyright © 2025-Present The AkordAI Authors
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

namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a key-value store memory
/// </summary>
[DataContract]
public record KeyValueMemoryDefinition
{

    /// <summary>
    /// Gets/sets the name of the key-value memory provider
    /// </summary>
    [Required, AllowedValues(KeyValueMemoryProvider.Memory, KeyValueMemoryProvider.Redis)]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual string Provider { get; set; } = null!;

    /// <summary>
    /// Gets/sets the key-value memory's endpoint
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual EndpointDefinition Endpoint
    {
        get => EndpointValue.T1Value ?? new() { Uri = EndpointUri };
        set => EndpointValue = value;
    }

    /// <summary>
    /// Gets/sets the key-value memory's endpoint
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual Uri EndpointUri
    {
        get => EndpointValue.T1Value?.Uri ?? EndpointValue.T2Value!;
        set => EndpointValue = value;
    }

    /// <summary>
    /// Gets/sets the key-value memory's endpoint
    /// </summary>
    [Required]
    [DataMember(Name = "endpoint", Order = 2), JsonInclude, JsonPropertyName("endpoint"), JsonPropertyOrder(2), YamlMember(Alias = "endpoint", Order = 2)]
    protected virtual OneOf<EndpointDefinition, Uri> EndpointValue { get; set; } = null!;

    /// <summary>
    /// Gets/sets a key/value mapping, if any, of the provider-specific properties used to configure the key-value memory
    /// </summary>
    [DataMember(Name = "configuration", Order = 3), JsonPropertyName("configuration"), JsonPropertyOrder(3), YamlMember(Alias = "configuration", Order = 3)]
    public virtual EquatableDictionary<string, object>? Configuration { get; set; }

}
