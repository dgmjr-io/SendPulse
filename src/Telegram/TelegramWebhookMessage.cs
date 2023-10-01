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

public partial class WebhookMessage
{
    [JsonProperty("bot", NullValueHandling = NullValueHandling.Ignore)]
    public Bot Bot { get; set; }

    [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
    public SendPulseContact Contact { get; set; }

    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public long? Date { get; set; }

    [JsonProperty("info")]
    public object Info { get; set; }

    [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
    public string Service { get; set; }

    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }
}
