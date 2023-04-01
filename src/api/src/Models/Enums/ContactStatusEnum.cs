/*
 * ContactStatusEnum.cs
 *
 *   Created: 2022-12-06-12:41:39
 *   Modified: 2022-12-06-12:41:40
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Enums;

/// <summary>
///                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - unsubscribed                      * &#x60;3&#x60; - disabled                      * &#x60;4&#x60; - blocked by user
/// </summary>
/// <value>                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - unsubscribed                      * &#x60;3&#x60; - disabled                      * &#x60;4&#x60; - blocked by user                  </value>
[JsonConverter(typeof(StringEnumConverter))]
public enum ContactStatusEnum
{
    /// <summary>
    /// Enum Active for value: 1
    /// </summary>
    [EnumMember(Value = "Active")]
    Active = 1,

    /// <summary>
    /// Enum Unsubscribed for value: 2
    /// </summary>
    [EnumMember(Value = "Unsubscribed")]
    Unsubscribed = 2,

    /// <summary>
    /// Enum Disabled for value: 3
    /// </summary>
    [EnumMember(Value = "Disabled")]
    Disabled = 3,

    /// <summary>
    /// Enum BlockedByUser for value: 4
    /// </summary>
    [EnumMember(Value = "BlockedByUser")]
    BlockedByUser = 4
}
