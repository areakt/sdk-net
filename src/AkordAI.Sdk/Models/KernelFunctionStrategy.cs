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

namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the definition of a kernel function–based strategy
/// </summary>
[DataContract]
public record KernelFunctionStrategy
{

    /// <inheritdoc/>
    [Required]
    [DataMember(Name = "function", Order = 1), JsonPropertyName("function"), JsonPropertyOrder(1), YamlMember(Alias = "function", Order = 1)]
    public virtual KernelFunctionDefinition Function { get; set; } = null!;

    /// <inheritdoc/>
    [DataMember(Name = "kernel", Order = 2), JsonPropertyName("kernel"), JsonPropertyOrder(2), YamlMember(Alias = "kernel", Order = 2)]
    public virtual KernelDefinition Kernel { get; set; } = null!;

}