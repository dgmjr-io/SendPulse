/*
 * TelegramWebhookMessage.cs
 *
 *   Created: 2022-12-01-11:48:58
 *   Modified: 2022-12-01-11:48:59
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Telegram;
using System.Text.Json;
using Newtonsoft.Json;

public partial class LastMessageData
{
    [JsonProperty("chat_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("chat_id")]
    public long? ChatId { get; set; }

    [JsonProperty("contact")]
    public object Contact { get; set; }

    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public Message Message { get; set; }

    [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("message_id")]
    public long? MessageId { get; set; }
}
