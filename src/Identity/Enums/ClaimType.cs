/*
 * ClaimType.cs
 *
 *   Created: 2023-03-25-08:34:08
 *   Modified: 2023-03-25-08:34:08
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Identity.Enums;

using System.ComponentModel.DataAnnotations;

[GenerateEnumerationRecordClass("ClaimType", "SendPulse.Identity.ClaimTypes")]
public enum ClaimType
{
    /// <inheritdoc cref="SpId.ApiBaseUri" />
    [Display(
        Name = "API Base URI",
        ShortName = nameof(ApiBaseUri),
        Description = "The base URI for the SendPulse API."
    )]
    [Uri(SpId.ApiBaseUri)]
    ApiBaseUri,

    /// <inheritdoc cref="SpId.TelegramApi" />
    [Display(
        Name = "Telegram API Base URI",
        ShortName = nameof(TelegramApi),
        Description = "The base URI for the SendPulse Telegram Chatbot API."
    )]
    [Uri(SpId.TelegramApi)]
    TelegramApi,

    /// <inheritdoc cref="SpId.BaseUri" />
    [Display(
        Name = "The SendPulse base URI",
        ShortName = nameof(BaseUri),
        Description = "The base URI for the SendPulse domain."
    )]
    [Uri(SpId.BaseUri)]
    BaseUri,

    /// <inheritdoc cref="SpId.Identity" />
    [Display(
        Name = "The base URI for all identity claims",
        ShortName = nameof(Identity),
        Description = "The base URI for the SendPulse identity domain."
    )]
    [Uri(SpId.Identity)]
    Identity,

    /// <inheritdoc cref="SpId.ContactId" />
    [Display(
        Name = "The URI for a contact ID",
        ShortName = nameof(ContactId),
        Description = "The base URI for the SendPulse domain."
    )]
    [Uri(SpId.ContactId)]
    ContactId,

    /// <inheritdoc cref="SpId.ObjectId" />
    [Display(
        Name = "The URI for a contact ID",
        ShortName = nameof(ObjectId),
        Description = "The base URI for a SendPulse object ID."
    )]
    [Uri(SpId.ObjectId)]
    ObjectId,

    /// <inheritdoc cref="SpId.OAuth2EndpointUri" />
    [Display(
        Name = "The OAuth2 Endpoint URI",
        ShortName = nameof(OAuth2EndpointUri),
        Description = "The URI for the SendPulse API's OAuth2 endpoint."
    )]
    [Uri(SpId.OAuth2EndpointUri)]
    OAuth2EndpointUri
}
