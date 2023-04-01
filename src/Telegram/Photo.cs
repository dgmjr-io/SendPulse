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

public partial class Photo
{
    [JsonProperty("width")]
    public long Width { get; set; }

    [JsonProperty("height")]
    public long Height { get; set; }

    [JsonProperty("file_id")]
    [JProp("file_id")]
    public string FileId { get; set; }

    [JsonProperty("file_unique_id")]
    [JProp("file_unique_id")]
    public string FileUniqueId { get; set; }

    [JsonProperty("file_size")]
    [JProp("file_size")]
    public long FileSize { get; set; }
}
