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
/// Enumerates all supported toolset types
/// </summary>
public static class ToolsetType
{

    /// <summary>
    /// Indicates a Model Context Protocol toolset
    /// </summary>
    public const string Mcp = "mcp";
    /// <summary>
    /// Indicates an OpenAPI toolset
    /// </summary>
    public const string OpenApi = "openapi";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Mcp;
        yield return OpenApi;
    }

}
