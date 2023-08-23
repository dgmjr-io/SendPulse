/*
 * IReadOnlyConfiguration.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:40:13
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Collections.Generic;

namespace SendPulse.Api.Client.Abstractions
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadOnlyConfiguration
    {
        /// <summary>
        /// Gets the access token.
        /// </summary>
        /// <value>Access token.</value>
        string AccessToken { get; }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value>
        IStringDictionary ApiKey { get; }

        /// <summary>
        /// Gets the API key prefix.
        /// </summary>
        /// <value>API key prefix.</value>
        IStringDictionary ApiKeyPrefix { get; }

        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>Base path.</value>
        string BasePath { get; }

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time format.</value>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <value>Default header.</value>
        IStringDictionary DefaultHeader { get; }

        /// <summary>
        /// Gets the temp folder path.
        /// </summary>
        /// <value>Temp folder path.</value>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; }

        /// <summary>
        /// Gets the user agent.
        /// </summary>
        /// <value>User agent.</value>
        string UserAgent { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>Username.</value>
        string ClientId { get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>Password.</value>
        string ClientSecret { get; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        string GetApiKeyWithPrefix(string apiKeyIdentifier);

        IApiClient CreateApiClient();

        /// <summary>Sets the <see cref="AccessToken" /> property.</summary>
        void SetAccessToken(string accessToken);
    }
}
