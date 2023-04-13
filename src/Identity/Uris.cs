/* 
 * Uris.cs
 * 
 *   Created: 2023-03-19-02:52:53
 *   Modified: 2023-03-25-10:29:06
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */ 

namespace SendPulse.Identity;

public static partial class ClaimTypeNames
{
    public static partial class Uris
    {
        /// <summary><inheritdoc cref="SpId.BaseUri" path="/summary" /></summary>
        /// <value><inheritdoc cref="SpId.BaseUri" path="/value" /></value>
        public static readonly uri BaseUri = new(SpId.BaseUri);
        /// <inheritdoc cref="SpId.ApiBaseUri"/>
        public static readonly uri ApiBaseUri = new(SpId.ApiBaseUri);
        /// <inheritdoc cref="SpId.OAuth2EncpointUri"/>
        public static readonly uri OAuth2EncpointUri = new(SpId.OAuth2EncpointUri);
    }
}
