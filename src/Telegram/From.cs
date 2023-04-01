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

public partial class From
{
    [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("is_bot", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("is_bot")]
    public bool? IsBot { get; set; }

    [JsonProperty("is_premium", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("is_premium")]
    public bool? IsPremium { get; set; }

    [JsonProperty("language_code", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("language_code")]
    public string LanguageCode { get; set; }

    [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("last_name")]
    public string LastName { get; set; }

    [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
    public string Username { get; set; }
}
