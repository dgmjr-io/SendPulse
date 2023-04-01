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

public partial class CaptionEntity
{
    [JsonProperty("length")]
    public long Length { get; set; }

    [JsonProperty("offset")]
    public long Offset { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}
