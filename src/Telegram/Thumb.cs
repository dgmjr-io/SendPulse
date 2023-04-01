namespace SendPulse.Telegram;
using Newtonsoft.Json;

public partial class Thumb
{
    [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("file_id")]
    public string FileId { get; set; }

    [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("file_size")]
    public long? FileSize { get; set; }

    [JsonProperty("file_unique_id", NullValueHandling = NullValueHandling.Ignore)]
    [JProp("file_unique_id")]
    public string FileUniqueId { get; set; }

    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    public long? Height { get; set; }

    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    public long? Width { get; set; }
}
