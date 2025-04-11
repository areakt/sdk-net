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
/// Enumerates all supported MCP transport types
/// </summary>
public static class McpTransportType
{

    /// <summary>
    /// Indicates the HTTP transport type
    /// </summary>
    public const string Http = "http";
    /// <summary>
    /// Indicates an STDIO transport type
    /// </summary>
    public const string Stdio = "stdio";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Http;
        yield return Stdio;
    }

}
