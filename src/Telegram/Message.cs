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

public partial class Message
{
    [JsonProperty("caption", NullValueHandling = NullValueHandling.Ignore)]
    public string Caption { get; set; }

    [JsonProperty("caption_entities", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("caption_entities")]
    public CaptionEntity[] CaptionEntities { get; set; }

    [JsonProperty("chat", NullValueHandling = NullValueHandling.Ignore)]
    public Chat Chat { get; set; }

    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public long? Date { get; set; }

    [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
    public From From { get; set; }

    [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("message_id")]
    public long? MessageId { get; set; }

    [JsonProperty("reply_markup", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("reply_markup")]
    public ReplyMarkup ReplyMarkup { get; set; }

    [JsonProperty("via_bot", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("via_bot")]
    public ViaBot ViaBot { get; set; }

    [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
    public Video Video { get; set; }

    [JsonProperty("photo", NullValueHandling = NullValueHandling.Ignore)]
    public Photo[] Photo { get; set; }
}
