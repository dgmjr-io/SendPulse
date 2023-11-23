/*
 * Claims.cs
 *
 *   Created: 2022-11-27-08:09:19
 *   Modified: 2022-11-27-08:09:19
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Identity.ClaimTypes;

using Dgmjr.Identity;

/// <summary>The URI for a claim that specifies the SendPulse ID</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class SendPulseId : ClaimType<DgmjrCvt.ObjectId>, IClaimType
{
    public static readonly IClaimType Instance = new SendPulseId();

    private SendPulseId() { }

    /// <value><inheritdoc cref="SpId.ObjectId" path="/value" /></value>
    public new const string UriString = SpId.ObjectId;

    /// <value>sp:<inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = "sp:" + Name;

    /// <value>object_id</value>
    public const string Name = "object_id";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}
