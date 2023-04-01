namespace SendPulse.Api;
using System;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

public sealed class UnixEpochDateTimeConverter
    : System.Text.Json.Serialization.JsonConverter<DateTime>
{
    static readonly DateTime s_epoch = new DateTime(1970, 1, 1, 0, 0, 0);
    static readonly Regex s_regex = new Regex(
        @"^(?:/Date\()?([+-]*\d+)(?:\/)?$",
        RegexOptions.CultureInvariant
    );

    public override DateTime Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (
            reader.TokenType == JsonTokenType.String
            && long.TryParse(reader.GetString(), out var unixTime)
        )
            return s_epoch.AddSeconds(unixTime);
        else if (reader.TokenType == JsonTokenType.Number)
            return s_epoch.AddSeconds(reader.GetInt64());
        else if (
            reader.TokenType == JsonTokenType.String
            && DateTime.TryParse(reader.GetString(), out var dt)
        )
            return dt;
        else
            throw new JsonException("Error parsing value into a value of type DateTime.");
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        long unixTime = Convert.ToInt64((value - s_epoch).TotalMilliseconds);

        string formatted = FormattableString.Invariant($"/Date({unixTime})/");
        writer.WriteStringValue(formatted);
    }
}
