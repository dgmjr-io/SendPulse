/*
 * Video.cs
 *
 *   Created: 2022-12-15-07:01:56
 *   Modified: 2022-12-15-07:01:57
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Telegram;

using Newtonsoft.Json;

public partial class Video
{
    [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
    public long? Duration { get; set; }

    [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("file_id")]
    public string FileId { get; set; }

    [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("file_name")]
    public string FileName { get; set; }

    [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("file_size")]
    public long? FileSize { get; set; }

    [JsonProperty("file_unique_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("file_unique_id")]
    public string FileUniqueId { get; set; }

    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    public long? Height { get; set; }

    [JsonProperty("mime_type", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("mime_type")]
    public string MimeType { get; set; }

    [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
    public Thumb Thumb { get; set; }

    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    public long? Width { get; set; }
}
