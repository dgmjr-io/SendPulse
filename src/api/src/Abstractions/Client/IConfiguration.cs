/*
 * IConfiguration.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:40:05
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Client.Abstractions;

public interface IConfiguration : IReadOnlyConfiguration
{
    IApiClient ApiClient { get; }
    new string BasePath { get; set; }
    new IStringDictionary DefaultHeader { get; set; }
    new int Timeout { get; set; }
    new string UserAgent { get; set; }
    new string ClientId { get; set; }
    new string ClientSecret { get; set; }
    new string AccessToken { get; set; }
    new string TempFolderPath { get; set; }
    new string DateTimeFormat { get; set; }
    new IStringDictionary ApiKeyPrefix { get; set; }
    new IStringDictionary ApiKey { get; set; }

    void AddApiKey(string key, string value);
    void AddApiKeyPrefix(string key, string value);
    void AddDefaultHeader(string key, string value);
    new IApiClient CreateApiClient();
    new string GetApiKeyWithPrefix(string apiKeyIdentifier);
}
