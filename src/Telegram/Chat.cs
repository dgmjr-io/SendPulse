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

public partial class Chat
{
    [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("last_name")]
    public string LastName { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
    public string Username { get; set; }
}
