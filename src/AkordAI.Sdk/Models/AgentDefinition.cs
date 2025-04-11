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
/// Represents the definition of an agent
/// </summary>
[DataContract]
public record AgentDefinition
{

    /// <summary>
    /// Gets/sets a short human-readable description of the agent's role or purpose, which is used for documentation, UI display, and prompt composition
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "description", Order = 1), JsonPropertyName("description"), JsonPropertyOrder(1), YamlMember(Alias = "description", Order = 1)]
    public virtual string Description { get; set; } = null!;

    /// <summary>
    /// Gets/sets the specific instructions that guide the agent's behavior
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "instructions", Order = 2), JsonPropertyName("instructions"), JsonPropertyOrder(2), YamlMember(Alias = "instructions", Order = 2)]
    public virtual string Instructions { get; set; } = null!;

    /// <summary>
    /// Gets/sets the runtime configuration that powers the agent's capabilities
    /// </summary>
    [Required]
    [DataMember(Name = "runtime", Order = 3), JsonPropertyName("runtime"), JsonPropertyOrder(3), YamlMember(Alias = "runtime", Order = 3)]
    public virtual RuntimeDefinition Runtime { get; set; } = null!;

    /// <summary>
    /// Gets/sets the definition of the agent's memory, if any
    /// </summary>
    [DataMember(Name = "memory", Order = 4), JsonPropertyName("memory"), JsonPropertyOrder(4), YamlMember(Alias = "memory", Order = 4)]
    public virtual AgentMemoryOptions? Memory { get; set; }

}
