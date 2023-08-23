/*
 * TriggerTypeEnum.cs
 *
 *   Created: 2022-12-06-12:45:39
 *   Modified: 2022-12-06-12:45:40
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace SendPulse.Api.Enums;

/// <summary>
///                      * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing
/// </summary>
/// <value>                     * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing                  </value>
[JsonConverter(typeof(StringEnumConverter))]
public enum TriggerTypeEnum
{
    /// <summary>
    /// Enum StartsImmediatelyUponSubscription for value: 1
    /// </summary>
    [EnumMember(Value = "StartsImmediatelyUponSubscription")]
    StartsImmediatelyUponSubscription = 1,

    /// <summary>
    /// Enum StartsWhenUnsubscribed for value: 2
    /// </summary>
    [EnumMember(Value = "StartsWhenUnsubscribed")]
    StartsWhenUnsubscribed = 2,

    /// <summary>
    /// Enum DefaultReply for value: 3
    /// </summary>
    [EnumMember(Value = "DefaultReply")]
    DefaultReply = 3,

    /// <summary>
    /// Enum StartsWhenTheSpecifiedKeywordIsEntered for value: 4
    /// </summary>
    [EnumMember(Value = "StartsWhenTheSpecifiedKeywordIsEntered")]
    StartsWhenTheSpecifiedKeywordIsEntered = 4,

    /// <summary>
    /// Enum StartsAtTheSpecifiedTimeWhenSubscribing for value: 5
    /// </summary>
    [EnumMember(Value = "StartsAtTheSpecifiedTimeWhenSubscribing")]
    StartsAtTheSpecifiedTimeWhenSubscribing = 5
}
