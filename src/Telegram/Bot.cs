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

using System;
using System.Text.Json;
using Newtonsoft.Json;

public partial class Bot
{
    [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("external_id")]
    public long? TelegramId { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("id")]
    public ObjectId ObjectId { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public string Url { get; set; }
}
