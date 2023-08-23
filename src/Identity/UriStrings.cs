/*
 * UriStrings.cs
 *
 *   Created: 2023-03-19-02:52:53
 *   Modified: 2023-03-25-08:46:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Identity;
public static partial class ClaimTypeNames
{
    /// <summary>The base URI for the SendPulse API.</summary>
    /// <value>https://api.sendpulse.com/</value>
    public const string ApiBaseUri = "https://api.sendpulse.com/";

    /// <summary>The base URI for the SendPulse API.</summary>
    /// <value><inheritdoc cref="ApiBaseUri" /><inheritdoc cref="UriFragments.Telegram" /></value>
    public const string TelegramApi = ApiBaseUri + UriFragments.Telegram;

    /// <summary>The base URI for the SendPulse domain.</summary>
    /// <value>https://sendpulse.com/</value>
    public const string BaseUri = "https://sendpulse.com/";

    /// <summary>The base URI for the SendPulse identity domain.</summary>
    /// <value><inheritdoc cref="BaseUri" /><inheritdoc cref="UriFragments.Identity" /></value>
    public const string Identity = BaseUri + SpIdFrags.Identity;

    /// <summary>A URI for a SendPulse object ID.</summary>
    /// <value><inheritdoc cref="BaseUri" /><inheritdoc cref="UriFragments.ObjectId" /></value>
    public const string ObjectId = Identity + SpIdFrags.ObjectId;

    /// <summary>The base URI for the SendPulse domain.</summary>
    /// <value><inheritdoc cref="Identity" /><inheritdoc cref="UriFragments.ContactId"  /></value>
    public const string ContactId = Identity + SpIdFrags.ContactId;

    /// <summary>The base URI for the SendPulse API's oauth endpoint.</summary>
    /// <value><inheritdoc cref="ApiBaseUri" /><inheritdoc cref="UriFragments.OAuth" /></value>
    public const string OAuth = ApiBaseUri + UriFragments.OAuth;

    /// <summary>The URI for the SendPulse API's OAuth2 endpoint.</summary>
    /// <value><inheritdoc cref="OAuth" /><inheritdoc cref="UriFragments.AccessToken" /></value>
    public const string OAuth2EndpointUri = ApiBaseUri + UriFragments.OAuth + UriFragments.AccessToken;
}
