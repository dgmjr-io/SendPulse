/*
 * ApiToken.cs
 *
 *   Created: 2022-12-06-01:47:14
 *   Modified: 2022-12-06-01:47:15
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Models;

public class ApiToken
{
    public string access_token { get; set; }
    public int expires_in { get; set; }
    public string token_type { get; set; }

    public DateTime DateTimeAcquired { get; set; } = DateTime.UtcNow;
    public DateTime DateTimeExpires => DateTimeAcquired.AddSeconds(expires_in);
    public bool IsExpired => DateTimeExpires <= DateTime.UtcNow;
}
