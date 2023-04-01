/*
 * MessageStatusEnum.cs
 *
 *   Created: 2022-12-06-12:43:17
 *   Modified: 2022-12-06-12:43:18
 *
 *   Author:  <justin@Dgmjr.com>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Enums;

/// <summary>
///                      * &#x60;1&#x60; - new
/// </summary>
/// <value>                     * &#x60;1&#x60; - new                  </value>
[JsonConverter(typeof(StringEnumConverter))]
public enum MessageStatusEnum
{
    /// <summary>
    /// Enum New for value: 1
    /// </summary>
    [EnumMember(Value = "1")]
    New = 1
}
