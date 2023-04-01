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

public partial class ReplyMarkup
{
    [JsonProperty("inline_keyboard", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("inline_keyboard")]
    public InlineKeyboard[][] InlineKeyboard { get; set; }
}
