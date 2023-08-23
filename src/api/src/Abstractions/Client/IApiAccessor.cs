/*
 * IApiAccessor.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:39:47
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;

namespace SendPulse.Api.Client.Abstractions;

/// <summary>
/// Represents configuration aspects required to interact with the API endpoints.
/// </summary>
public interface IApiAccessor
{
    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    IConfiguration Configuration { get; set; }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    string GetBasePath();

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    ExceptionFactory ExceptionFactory { get; set; }
}
