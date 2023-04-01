/*
 * VariableTypeEnum.cs
 *
 *   Created: 2022-12-06-12:46:57
 *   Modified: 2022-12-06-12:46:58
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

/// <summary>
///                  this type of variable can have the following values:                      * &#x60;1&#x60; - string                      * &#x60;2&#x60; - number                      * &#x60;3&#x60; - date                      * &#x60;4&#x60; - boolean                      * &#x60;5&#x60; - phone                      * &#x60;6&#x60; - email                      * &#x60;7&#x60; - url
/// </summary>
/// <value>                 this type of variable can have the following values:                      * &#x60;1&#x60; - string                      * &#x60;2&#x60; - number                      * &#x60;3&#x60; - date                      * &#x60;4&#x60; - boolean                      * &#x60;5&#x60; - phone                      * &#x60;6&#x60; - email                      * &#x60;7&#x60; - url                  </value>
[JsonConverter(typeof(StringEnumConverter))]
public enum VariableDataTypeEnum
{
    /// <summary>
    /// Enum String for value: 1
    /// </summary>
    [EnumMember(Value = "String")]
    String = 1,

    /// <summary>
    /// Enum Number for value: 2
    /// </summary>
    [EnumMember(Value = "Number")]
    Number = 2,

    /// <summary>
    /// Enum Date for value: 3
    /// </summary>
    [EnumMember(Value = "Date")]
    Date = 3,

    /// <summary>
    /// Enum Boolean for value: 4
    /// </summary>
    [EnumMember(Value = "Boolean")]
    Boolean = 4,

    /// <summary>
    /// Enum PhoneNumber for value: 5
    /// </summary>
    [EnumMember(Value = "PhoneNumber")]
    PhoneNumber = 5,

    /// <summary>
    /// Enum EmailAddress for value: 6
    /// </summary>
    [EnumMember(Value = "EmailAddress")]
    EmailAddress = 6,

    /// <summary>
    /// Enum Url for value: 7
    /// </summary>
    [EnumMember(Value = "Url")]
    Url = 7
}
