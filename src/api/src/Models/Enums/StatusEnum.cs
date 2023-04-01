namespace SendPulse.Api.Enums;

/// <summary>
///                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive
/// </summary>
/// <value>                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  </value>
[JsonConverter(typeof(StringEnumConverter))]
public enum StatusEnum
{
    /// <summary>
    /// Enum Active for value: 1
    /// </summary>
    [EnumMember(Value = "Active")]
    Active = 1,

    /// <summary>
    /// Enum Inactive for value: 2
    /// </summary>
    [EnumMember(Value = "Inactive")]
    Inactive = 2,

    [EnumMember(Value = "BotActive")]
    BotActive = 3,

    [EnumMember(Value = "BotInactive")]
    BotInactive = 4
}
