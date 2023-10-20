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

public enum ClaimType
{
    /// <inheritdoc cref="ClaimTypeNames.ApiBaseUri" />
    [Display(
        Name = "API Base URI",
        ShortName = nameof(ApiBaseUri),
        Description = "The base URI for the SendPulse API."
    )]
    [Uri(ClaimTypeNames.ApiBaseUri)]
    ApiBaseUri,

    /// <inheritdoc cref="ClaimTypeNames.TelegramApi" />
    [Display(
        Name = "Telegram API Base URI",
        ShortName = nameof(TelegramApi),
        Description = "The base URI for the SendPulse Telegram Chatbot API."
    )]
    [Uri(ClaimTypeNames.TelegramApi)]
    TelegramApi,

    /// <inheritdoc cref="ClaimTypeNames.BaseUri" />
    [Display(
        Name = "The SendPulsee base URI",
        ShortName = nameof(BaseUri),
        Description = "The base URI for the SendPulse domain."
    )]
    [Uri(ClaimTypeNames.BaseUri)]
    BaseUri,

    /// <inheritdoc cref="ClaimTypeNames.Identity" />
    [Display(
        Name = "The base URI for all identity claims",
        ShortName = nameof(Identity),
        Description = "The base URI for the SendPulse identity domain."
    )]
    [Uri(ClaimTypeNames.Identity)]
    Identity,

    /// <inheritdoc cref="ClaimTypeNames.ContactId" />
    [Display(
        Name = "The URI for a contact ID",
        ShortName = nameof(ContactId),
        Description = "The base URI for the SendPulse domain."
    )]
    [Uri(ClaimTypeNames.ContactId)]
    ContactId,

    /// <inheritdoc cref="ClaimTypeNames.ObjectId" />
    [Display(
        Name = "The URI for a contact ID",
        ShortName = nameof(ObjectId),
        Description = "The base URI for a SendPulse object ID."
    )]
    [Uri(ClaimTypeNames.ObjectId)]
    ObjectId,

    /// <inheritdoc cref="ClaimTypeNames.OAuth2EndpointUri" />
    [Display(
        Name = "The OAuth2 Endpoint URI",
        ShortName = nameof(OAuth2EndpointUri),
        Description = "The URI for the SendPulse API's OAuth2 endpoint."
    )]
    [Uri(ClaimTypeNames.OAuth2EndpointUri)]
    OAuth2EndpointUri
}
