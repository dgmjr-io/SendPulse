/*
 * WrappedConfiguration.cs
 *
 *   Created: 2022-12-08-02:50:09
 *   Modified: 2022-12-08-02:50:10
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Client;
using SendPulse.Api.Client.Abstractions;

public class WrappedConfiguration : Abstractions.IConfiguration
{
    public Abstractions.IConfiguration Configuration { get; }

    public WrappedConfiguration(IConfiguration configuration) => Configuration = configuration;

    public IApiClient ApiClient => Configuration.ApiClient;
    public string BasePath
    {
        get => Configuration.BasePath;
        set => Configuration.BasePath = value;
    }
    public IStringDictionary DefaultHeader
    {
        get => Configuration.DefaultHeader;
        set => Configuration.DefaultHeader = value;
    }
    public int Timeout
    {
        get => Configuration.Timeout;
        set => Configuration.Timeout = value;
    }
    public string UserAgent
    {
        get => Configuration.UserAgent;
        set => Configuration.UserAgent = value;
    }
    public string ClientId
    {
        get => Configuration.ClientId;
        set => Configuration.ClientId = value;
    }
    public string ClientSecret
    {
        get => Configuration.ClientSecret;
        set => Configuration.ClientSecret = value;
    }
    public string AccessToken
    {
        get => Configuration.AccessToken;
        set => Configuration.AccessToken = value;
    }
    public string TempFolderPath
    {
        get => Configuration.TempFolderPath;
        set => Configuration.TempFolderPath = value;
    }
    public string DateTimeFormat
    {
        get => Configuration.DateTimeFormat;
        set => Configuration.DateTimeFormat = value;
    }
    public IStringDictionary ApiKeyPrefix
    {
        get => Configuration.ApiKeyPrefix;
        set => Configuration.ApiKeyPrefix = value;
    }
    public IStringDictionary ApiKey
    {
        get => Configuration.ApiKey;
        set => Configuration.ApiKey = value;
    }

    public void AddApiKey(string key, string value) => Configuration.AddApiKey(key, value);

    public void AddApiKeyPrefix(string key, string value) =>
        Configuration.AddApiKeyPrefix(key, value);

    public void AddDefaultHeader(string key, string value) =>
        Configuration.AddDefaultHeader(key, value);

    public IApiClient CreateApiClient() => Configuration.CreateApiClient();

    public string GetApiKeyWithPrefix(string apiKeyIdentifier) =>
        Configuration.GetApiKeyWithPrefix(apiKeyIdentifier);

    public void SetAccessToken(string accessToken) => Configuration.SetAccessToken(accessToken);
}
